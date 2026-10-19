using AutoMapper;
using Kurumsal.Application.DTOs.Ulke;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services;

public class UlkeService : IUlkeService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public UlkeService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<UlkeDto>> GetAllAsync()
    {
        var ulkeler = await _context.Ulkeler
            .Where(x => !x.IsDeleted)
            .ToListAsync();
        return _mapper.Map<List<UlkeDto>>(ulkeler);
    }

    public async Task<UlkeDto?> GetByIdAsync(Guid id)
    {
        var ulke = await _context.Ulkeler
            .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        return _mapper.Map<UlkeDto>(ulke);
    }

    public async Task<UlkeDto> CreateAsync(UlkeCreateDto dto)
    {
        var entity = _mapper.Map<Ulke>(dto);
        _context.Ulkeler.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<UlkeDto>(entity);
    }

    public async Task<UlkeDto> UpdateAsync(UlkeUpdateDto dto)
    {
        var entity = await _context.Ulkeler.FirstOrDefaultAsync(x => x.Id == dto.Id && !x.IsDeleted);
        if (entity == null) throw new Exception("Kayıt bulunamadı");

        _mapper.Map(dto, entity);
        _context.Ulkeler.Update(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<UlkeDto>(entity);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity = await _context.Ulkeler.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        if (entity == null) return false;

        entity.IsDeleted = true;
        entity.DeletedAt = DateTime.UtcNow;

        _context.Ulkeler.Update(entity);
        await _context.SaveChangesAsync();

        return true;
    }
}
