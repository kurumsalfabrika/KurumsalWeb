namespace Kurumsal.Application.DTOs.Auth;

public sealed class AuthResponseDto
{
    public string AccessToken { get; set; } = null!;
    public DateTime ExpiresAtUtc { get; set; }
    public Guid UserId { get; set; }
    public Guid TenantId { get; set; }
    public string KullaniciAdi { get; set; } = null!;
    public string? Email { get; set; }
    public string[] Roles { get; set; } = Array.Empty<string>();

    // NEW: client’a dönecek tek-seferlik refresh token (ham değer)
    public string RefreshToken { get; set; } = null!;
}
