using AutoMapper;
using Kurumsal.Application.DTOs.Tenant;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services
{
    public class TenantService : ITenantService
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public TenantService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<TenantDto>> GetAllAsync()
        {
            var list = await _db.Tenantler
                .AsNoTracking()
                .ToListAsync();

            return _mapper.Map<List<TenantDto>>(list);
        }

        public async Task<TenantDto?> GetByIdAsync(Guid id)
        {
            var ent = await _db.Tenantler
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return ent is null ? null : _mapper.Map<TenantDto>(ent);
        }

        public async Task<TenantDto> CreateAsync(TenantCreateDto dto)
        {
            // Kod tekilliği (opsiyonel ama faydalı)
            var kodExists = await _db.Tenantler.AnyAsync(x => x.Kod == dto.Kod);
            if (kodExists) throw new InvalidOperationException("Aynı KOD ile Tenant zaten mevcut.");

            var tenant = _mapper.Map<Tenant>(dto);
            _db.Tenantler.Add(tenant);

            // TRY dövizi otomatik ekle (bu context'te tenant filtresi yok; TenantId'yi kendimiz set ediyoruz)
            _db.Dovizler.Add(new Doviz
            {
                Id = Guid.NewGuid(),
                TenantId = tenant.Id,
                Kod = "TRY",
                Ad = "Türk Lirası",
                Sembol = "₺",
                Ulke = "Türkiye",
                AktifMi = true,
                IsDeleted = false,
                CreatedAt = DateTime.UtcNow
            });

            await _db.SaveChangesAsync();
            return _mapper.Map<TenantDto>(tenant);
        }

        public async Task<TenantDto> UpdateAsync(TenantUpdateDto dto)
        {
            var ent = await _db.Tenantler.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (ent is null) throw new KeyNotFoundException("Tenant bulunamadı.");

            // Kod tekilliği (kendisi hariç)
            var kodExists = await _db.Tenantler.AnyAsync(x => x.Kod == dto.Kod && x.Id != dto.Id);
            if (kodExists) throw new InvalidOperationException("Aynı KOD başka bir Tenant'ta mevcut.");

            _mapper.Map(dto, ent);
            await _db.SaveChangesAsync();

            return _mapper.Map<TenantDto>(ent);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var ent = await _db.Tenantler.FirstOrDefaultAsync(x => x.Id == id);
            if (ent is null) return false;

            ent.IsDeleted = true;
            ent.DeletedAt = DateTime.UtcNow;
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
