using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Kurumsal.Application.DTOs.Auth;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Kurumsal.Infrastructure.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace Kurumsal.Infrastructure.Services;

public sealed class AuthService : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IOptions<JwtOptions> _jwtOptions;
    private readonly AppDbContext _db;
    private readonly IHttpContextAccessor _http;

    public AuthService(UserManager<AppUser> userManager,
                       IOptions<JwtOptions> jwtOptions,
                       AppDbContext db,
                       IHttpContextAccessor http)
    {
        _userManager = userManager;
        _jwtOptions = jwtOptions;
        _db = db;
        _http = http;
    }

    public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
    {
        AppUser? user = await _userManager.FindByNameAsync(dto.KullaniciAdiVeyaEmail)
                        ?? await _userManager.FindByEmailAsync(dto.KullaniciAdiVeyaEmail);
        if (user is null)
            throw new UnauthorizedAccessException("Kullanıcı bulunamadı.");

        if (!await _userManager.CheckPasswordAsync(user, dto.Parola))
            throw new UnauthorizedAccessException("Kullanıcı adı/e-posta veya parola hatalı.");

        var roles = (await _userManager.GetRolesAsync(user)).ToArray();
        var accessToken = CreateJwt(user, roles, out var expiresUtc);

        // refresh token üret + db'ye kaydet
        var refreshPlain = CreateSecureRandomToken();
        var refreshHash = Sha256(refreshPlain);

        var opt = _jwtOptions.Value;
        var rt = new RefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            TenantId = user.TenantId,
            TokenHash = refreshHash,
            CreatedAtUtc = DateTime.UtcNow,
            CreatedByIp = ClientIp(),
            ExpiresAtUtc = DateTime.UtcNow.AddDays(opt.RefreshTokenDays)
        };
        _db.RefreshTokens.Add(rt);
        await _db.SaveChangesAsync();

        return new AuthResponseDto
        {
            AccessToken = accessToken,
            ExpiresAtUtc = expiresUtc,
            UserId = user.Id,
            TenantId = user.TenantId,
            KullaniciAdi = user.UserName!,
            Email = user.Email,
            Roles = roles,
            RefreshToken = refreshPlain
        };
    }

    public async Task<AuthResponseDto> RefreshAsync(RefreshRequestDto dto)
    {
        var hash = Sha256(dto.RefreshToken);
        var token = await _db.RefreshTokens.FirstOrDefaultAsync(t => t.TokenHash == hash);

        if (token is null || !token.IsActive)
            throw new UnauthorizedAccessException("Geçersiz veya süresi dolmuş refresh token.");

        var user = await _userManager.FindByIdAsync(token.UserId.ToString())
                   ?? throw new UnauthorizedAccessException("Kullanıcı bulunamadı.");

        // token rotasyonu: eski token'ı revoke et, yenisini üret
        var newPlain = CreateSecureRandomToken();
        var newHash = Sha256(newPlain);
        var opt = _jwtOptions.Value;

        token.RevokedAtUtc = DateTime.UtcNow;
        token.RevokedByIp = ClientIp();
        token.ReplacedByTokenHash = newHash;

        var newRt = new RefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            TenantId = user.TenantId,
            TokenHash = newHash,
            CreatedAtUtc = DateTime.UtcNow,
            CreatedByIp = ClientIp(),
            ExpiresAtUtc = DateTime.UtcNow.AddDays(opt.RefreshTokenDays)
        };

        _db.RefreshTokens.Add(newRt);

        var roles = (await _userManager.GetRolesAsync(user)).ToArray();
        var accessToken = CreateJwt(user, roles, out var accessExpires);

        await _db.SaveChangesAsync();

        return new AuthResponseDto
        {
            AccessToken = accessToken,
            ExpiresAtUtc = accessExpires,
            UserId = user.Id,
            TenantId = user.TenantId,
            KullaniciAdi = user.UserName!,
            Email = user.Email,
            Roles = roles,
            RefreshToken = newPlain
        };
    }

    public async Task<bool> LogoutAsync(LogoutRequestDto dto)
    {
        var hash = Sha256(dto.RefreshToken);
        var now = DateTime.UtcNow;
        var ip = ClientIp();

        var rt = await _db.RefreshTokens.FirstOrDefaultAsync(t => t.TokenHash == hash);
        if (rt is null) return false;

        // İstenirse kullanıcının tüm aktif tokenlarını da kapat
        if (dto.RevokeAllForUser)
        {
            var all = await _db.RefreshTokens
                .Where(t => t.UserId == rt.UserId && t.RevokedAtUtc == null && t.ExpiresAtUtc > now)
                .ToListAsync();

            foreach (var t in all)
            {
                t.RevokedAtUtc = now;
                t.RevokedByIp = ip;
            }
        }
        else
        {
            rt.RevokedAtUtc = now;
            rt.RevokedByIp = ip;
        }

        await _db.SaveChangesAsync();
        return true;
    }

    // ---------------- helpers ----------------

    private string CreateJwt(AppUser user, string[] roles, out DateTime expiresUtc)
    {
        var opt = _jwtOptions.Value;
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(opt.Key));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.UserName ?? string.Empty),
            new(ClaimTypes.Email, user.Email ?? string.Empty),
            new("tid", user.TenantId.ToString())
        };
        claims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));

        expiresUtc = DateTime.UtcNow.AddMinutes(opt.AccessTokenMinutes);

        var jwt = new JwtSecurityToken(
            issuer: opt.Issuer,
            audience: opt.Audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: expiresUtc,
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }

    private static string CreateSecureRandomToken()
    {
        Span<byte> bytes = stackalloc byte[64];
        RandomNumberGenerator.Fill(bytes);
        return Convert.ToBase64String(bytes);
    }

    private static string Sha256(string input)
    {
        using var sha = SHA256.Create();
        var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
        return Convert.ToHexString(hash); // uppercase hex
    }

    private string? ClientIp()
        => _http.HttpContext?.Connection.RemoteIpAddress?.ToString();
}
