using AutoMapper;
using Kurumsal.Application.DTOs.Role;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Kurumsal.Infrastructure.Tenancy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services
{
    public class AppRoleService : IAppRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly AppDbContext _db; // uniq kontrolü/extra sorgular
        private readonly ITenantProvider _tenantProvider;
        private readonly IMapper _mapper;

        public AppRoleService(RoleManager<AppRole> roleManager, AppDbContext db, ITenantProvider tenantProvider, IMapper mapper)
        {
            _roleManager = roleManager;
            _db = db;
            _tenantProvider = tenantProvider;
            _mapper = mapper;
        }

        public async Task<List<AppRoleDto>> GetAllAsync()
        {
            // DbContext'teki HasQueryFilter nedeniyle: tenant açıksa kendi tenant + global roller gelir
            var roles = await _roleManager.Roles
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<List<AppRoleDto>>(roles);
        }

        public async Task<List<AppRoleDto>> GetByTenantIdAsync(Guid tenantId)
        {
            var roles = await _roleManager.Roles
                .AsNoTracking()
                .Where(r => r.TenantId == tenantId || r.TenantId == null) // tenant + global
                .ToListAsync();

            return _mapper.Map<List<AppRoleDto>>(roles);
        }

        public async Task<AppRoleDto?> GetByIdAsync(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            return role is null ? null : _mapper.Map<AppRoleDto>(role);
        }

        public async Task<AppRoleDto> CreateAsync(AppRoleCreateDto dto)
        {
            Guid? tenantId = dto.GlobalRolMu ? null : _tenantProvider.TenantId;

            if (!dto.GlobalRolMu && tenantId == null)
                throw new InvalidOperationException("TenantId bulunamadı. Global rol oluşturmak için GlobalRolMu=true gönderin.");

            var normalized = Normalize(dto.Name);

            // Aynı tenant içinde (veya globalde) isim tekil olsun
            var exists = await _db.Set<AppRole>()
                .AnyAsync(r => r.NormalizedName == normalized && r.TenantId == tenantId);
            if (exists) throw new InvalidOperationException("Aynı isimde rol zaten mevcut.");

            var role = new AppRole
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                NormalizedName = normalized,
                TenantId = tenantId,
                Aciklama = dto.Aciklama
            };

            var result = await _roleManager.CreateAsync(role);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            return _mapper.Map<AppRoleDto>(role);
        }

        public async Task<AppRoleDto> UpdateAsync(AppRoleUpdateDto dto)
        {
            var role = await _roleManager.FindByIdAsync(dto.Id.ToString())
                       ?? throw new KeyNotFoundException("Rol bulunamadı.");

            var normalized = Normalize(dto.Name);

            // TenantId burada sabit kalır (değiştirmiyoruz)
            var exists = await _db.Set<AppRole>().AnyAsync(r =>
                r.Id != role.Id &&
                r.TenantId == role.TenantId &&
                r.NormalizedName == normalized);

            if (exists) throw new InvalidOperationException("Aynı isimde başka bir rol mevcut.");

            role.Name = dto.Name;
            role.NormalizedName = normalized;
            role.Aciklama = dto.Aciklama;

            var result = await _roleManager.UpdateAsync(role);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            return _mapper.Map<AppRoleDto>(role);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            if (role is null) return false;

            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => $"{e.Code}: {e.Description}")));

            return true;
        }

        private static string Normalize(string name) => name?.Trim().ToUpperInvariant() ?? string.Empty;
    }
}
