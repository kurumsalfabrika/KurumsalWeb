using AutoMapper;
using Kurumsal.Application.DTOs.Doviz;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services;

public class DovizService : IDovizService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public DovizService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<DovizDto>> GetAllAsync()
    {
        var list = await _context.Dovizler
            .Where(x => !x.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<DovizDto>>(list);
    }

    public async Task<List<DovizDto>> GetByTenantIdAsync(Guid tenantId)
    {
        var list = await _context.Dovizler
            .Where(x => !x.IsDeleted && x.TenantId == tenantId)
            .ToListAsync();

        return _mapper.Map<List<DovizDto>>(list);
    }

    public async Task<DovizDto?> GetByIdAsync(Guid id)
    {
        var ent = await _context.Dovizler
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        return _mapper.Map<DovizDto>(ent);
    }

    public async Task<DovizDto> CreateAsync(DovizCreateDto dto)
    {
        var tenantExists = await _context.Tenantler.AnyAsync(t => t.Id == dto.TenantId && !t.IsDeleted);
        if (!tenantExists) throw new Exception("Geçersiz TenantId");

        var kodExists = await _context.Dovizler
            .AnyAsync(x => !x.IsDeleted && x.TenantId == dto.TenantId && x.Kod == dto.Kod);
        if (kodExists) throw new Exception("Aynı KOD bu tenant içinde zaten mevcut.");

        var ent = _mapper.Map<Doviz>(dto);
        _context.Dovizler.Add(ent);
        await _context.SaveChangesAsync();

        return _mapper.Map<DovizDto>(ent);
    }

    public async Task<DovizDto> UpdateAsync(DovizUpdateDto dto)
    {
        var ent = await _context.Dovizler
            .FirstOrDefaultAsync(x => x.Id == dto.Id && !x.IsDeleted);

        if (ent == null) throw new Exception("Kayıt bulunamadı");

        var tenantIdForCheck = dto.TenantId != Guid.Empty ? dto.TenantId : ent.TenantId;

        if (dto.TenantId != Guid.Empty && dto.TenantId != ent.TenantId)
        {
            var tenantExists = await _context.Tenantler.AnyAsync(t => t.Id == dto.TenantId && !t.IsDeleted);
            if (!tenantExists) throw new Exception("Geçersiz TenantId");
        }

        var kodExists = await _context.Dovizler
            .AnyAsync(x => !x.IsDeleted && x.Id != dto.Id && x.TenantId == tenantIdForCheck && x.Kod == dto.Kod);
        if (kodExists) throw new Exception("Aynı KOD bu tenant içinde başka bir kayıtta mevcut.");

        _mapper.Map(dto, ent);
        _context.Dovizler.Update(ent);
        await _context.SaveChangesAsync();

        return _mapper.Map<DovizDto>(ent);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var ent = await _context.Dovizler
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (ent == null) return false;

        ent.IsDeleted = true;
        ent.DeletedAt = DateTime.UtcNow;

        _context.Dovizler.Update(ent);
        await _context.SaveChangesAsync();

        return true;
    }
}
