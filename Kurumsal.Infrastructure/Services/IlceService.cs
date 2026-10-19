using AutoMapper;
using Kurumsal.Application.DTOs.Ilce;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services;

public class IlceService : IIlceService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public IlceService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<IlceDto>> GetAllAsync()
    {
        var ilceler = await _context.Ilceler
            .Include(i => i.Sehir)
            .Where(x => !x.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<IlceDto>>(ilceler);
    }

    public async Task<List<IlceDto>> GetBySehirIdAsync(Guid sehirId)
    {
        var ilceler = await _context.Ilceler
            .Include(i => i.Sehir)
            .Where(x => !x.IsDeleted && x.SehirId == sehirId)
            .ToListAsync();

        return _mapper.Map<List<IlceDto>>(ilceler);
    }

    public async Task<IlceDto?> GetByIdAsync(Guid id)
    {
        var ilce = await _context.Ilceler
            .Include(i => i.Sehir)
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        return _mapper.Map<IlceDto>(ilce);
    }

    public async Task<IlceDto> CreateAsync(IlceCreateDto dto)
    {
        // (Opsiyonel) Şehir var mı kontrolü
        var sehirExists = await _context.Sehirler.AnyAsync(s => s.Id == dto.SehirId && !s.IsDeleted);
        if (!sehirExists) throw new Exception("Geçersiz SehirId");

        var entity = _mapper.Map<Ilce>(dto);
        _context.Ilceler.Add(entity);
        await _context.SaveChangesAsync();

        // SehirAd map’i için tekrar çekebiliriz (isteğe bağlı)
        await _context.Entry(entity).Reference(e => e.Sehir).LoadAsync();

        return _mapper.Map<IlceDto>(entity);
    }

    public async Task<IlceDto> UpdateAsync(IlceUpdateDto dto)
    {
        var entity = await _context.Ilceler
            .FirstOrDefaultAsync(x => x.Id == dto.Id && !x.IsDeleted);

        if (entity == null) throw new Exception("Kayıt bulunamadı");

        // (Opsiyonel) Şehir var mı kontrolü
        var sehirExists = await _context.Sehirler.AnyAsync(s => s.Id == dto.SehirId && !s.IsDeleted);
        if (!sehirExists) throw new Exception("Geçersiz SehirId");

        _mapper.Map(dto, entity);
        _context.Ilceler.Update(entity);
        await _context.SaveChangesAsync();

        await _context.Entry(entity).Reference(e => e.Sehir).LoadAsync();

        return _mapper.Map<IlceDto>(entity);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = await _context.Ilceler
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

        if (entity == null) return false;

        entity.IsDeleted = true;
        entity.DeletedAt = DateTime.UtcNow;

        _context.Ilceler.Update(entity);
        await _context.SaveChangesAsync();

        return true;
    }
}
