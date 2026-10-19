using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kurumsal.Application.DTOs.AppUser;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Kurumsal.Infrastructure.Tenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services
{
    public sealed class AppUserService : IAppUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db; // ek sorgular için
        private readonly ITenantProvider _tenantProvider;
        private readonly IMapper _mapper;

        public AppUserService(UserManager<AppUser> userManager,
                              AppDbContext db,
                              ITenantProvider tenantProvider,
                              IMapper mapper)
        {
            _userManager = userManager;
            _db = db;
            _tenantProvider = tenantProvider;
            _mapper = mapper;
        }

        // Geçerli tenant kullanıcıları
        public async Task<List<AppUserDto>> GetAllAsync()
        {
            var tenantId = _tenantProvider.TenantId;
            return await _userManager.Users
                .AsNoTracking()
                .Where(u => tenantId != null && u.TenantId == tenantId.Value)
                .ProjectTo<AppUserDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        // Belirli tenant kullanıcıları (admin amaçlı)
        public async Task<List<AppUserDto>> GetByTenantIdAsync(Guid tenantId)
        {
            return await _userManager.Users
                .AsNoTracking()
                .Where(u => u.TenantId == tenantId)
                .ProjectTo<AppUserDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<AppUserDto?> GetByIdAsync(Guid id)
        {
            var tenantId = _tenantProvider.TenantId;
            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == id && (tenantId == null || u.TenantId == tenantId.Value));

            return user is null ? null : _mapper.Map<AppUserDto>(user);
        }

        public async Task<AppUserDto> CreateAsync(AppUserCreateDto dto)
        {
            // Tenant doğrulaması
            var currentTenant = _tenantProvider.TenantId;
            var tenantId = dto.TenantId != Guid.Empty ? dto.TenantId
                          : currentTenant ?? throw new InvalidOperationException("TenantId bulunamadı.");

            if (currentTenant != null && dto.TenantId != Guid.Empty && dto.TenantId != currentTenant.Value)
                throw new InvalidOperationException("Tenant uyuşmazlığı: istekteki TenantId ile mevcut tenant farklı.");

            // Uniq kontroller (Identity default indexleri globaldir; tenant-bazlı uniq istiyorsan indexi ayrıca modelde düzenle)
            if (await _userManager.FindByNameAsync(dto.KullaniciAdi) is not null)
                throw new InvalidOperationException("Kullanıcı adı zaten mevcut.");
            if (!string.IsNullOrWhiteSpace(dto.Email) &&
                await _userManager.FindByEmailAsync(dto.Email!) is not null)
                throw new InvalidOperationException("E-posta zaten kayıtlı.");

            var user = _mapper.Map<AppUser>(dto);
            user.Id = Guid.NewGuid();
            user.TenantId = tenantId;
            user.UserName = dto.KullaniciAdi;

            var result = await _userManager.CreateAsync(user, dto.Parola);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            // E-posta / telefon normalizasyonu için UserManager setter'ları
            if (!string.IsNullOrWhiteSpace(dto.Email))
                await _userManager.SetEmailAsync(user, dto.Email!);
            if (!string.IsNullOrWhiteSpace(dto.Telefon))
                await _userManager.SetPhoneNumberAsync(user, dto.Telefon!);

            // Diğer alanlar zaten map edildi; final update
            await _userManager.UpdateAsync(user);

            return _mapper.Map<AppUserDto>(user);
        }

        public async Task<AppUserDto> UpdateAsync(AppUserUpdateDto dto)
        {
            var tenantId = _tenantProvider.TenantId;
            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == dto.Id && (tenantId == null || u.TenantId == tenantId.Value))
                ?? throw new KeyNotFoundException("Kullanıcı bulunamadı.");

            // Email/Telefon için UserManager metodları (normalize + security stamp akışı)
            if (!string.IsNullOrWhiteSpace(dto.Email) && !string.Equals(dto.Email, user.Email, StringComparison.OrdinalIgnoreCase))
            {
                var existingByEmail = await _userManager.FindByEmailAsync(dto.Email);
                if (existingByEmail is not null && existingByEmail.Id != user.Id)
                    throw new InvalidOperationException("Bu e-posta başka bir kullanıcı tarafından kullanılıyor.");
                await _userManager.SetEmailAsync(user, dto.Email);
            }

            if (!string.IsNullOrWhiteSpace(dto.Telefon) && dto.Telefon != user.PhoneNumber)
            {
                await _userManager.SetPhoneNumberAsync(user, dto.Telefon);
            }

            // Kimlik/profil alanları
            user.Ad = dto.Ad;
            user.Soyad = dto.Soyad;
            user.TcKimlikNo = dto.TcKimlikNo;
            user.DogumTarihi = dto.DogumTarihi;
            user.Cinsiyet = dto.Cinsiyet;
            user.AktifMi = dto.AktifMi;
            user.ProfilFotoUrl = dto.ProfilFotoUrl;

            // Personel alanları
            user.SicilNo = dto.SicilNo;
            user.Unvan = dto.Unvan;
            user.Departman = dto.Departman;
            user.IseBaslamaTarihi = dto.IseBaslamaTarihi;
            user.IstenAyrilmaTarihi = dto.IstenAyrilmaTarihi;

            // İletişim/adres
            user.Iban = dto.Iban;
            user.Adres = dto.Adres;
            user.PostaKodu = dto.PostaKodu;
            user.UlkeId = dto.UlkeId;
            user.SehirId = dto.SehirId;
            user.IlceId = dto.IlceId;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            return _mapper.Map<AppUserDto>(user);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var tenantId = _tenantProvider.TenantId;
            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == id && (tenantId == null || u.TenantId == tenantId.Value));

            if (user is null) return false;

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            return true;
        }
    }
}
