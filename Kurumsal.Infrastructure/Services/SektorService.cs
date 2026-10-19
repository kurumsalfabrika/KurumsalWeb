using AutoMapper;
using Kurumsal.Application.DTOs.Sektor;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services
{
    public class SektorService : ISektorService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SektorService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SektorDto>> GetAllAsync()
        {
            var sektorler = await _context.Sektorler
                .Where(x => !x.IsDeleted)
                .ToListAsync();

            return _mapper.Map<List<SektorDto>>(sektorler);
        }

        public async Task<SektorDto?> GetByIdAsync(Guid id)
        {
            var sektor = await _context.Sektorler
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            return _mapper.Map<SektorDto?>(sektor);
        }

        public async Task<SektorDto> CreateAsync(SektorCreateDto dto)
        {
            var entity = _mapper.Map<Sektor>(dto);
            _context.Sektorler.Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<SektorDto>(entity);
        }

        public async Task<SektorDto> UpdateAsync(SektorUpdateDto dto)
        {
            var entity = await _context.Sektorler
                .FirstOrDefaultAsync(x => x.Id == dto.Id && !x.IsDeleted);

            if (entity == null) throw new Exception("Kayıt bulunamadı");

            _mapper.Map(dto, entity);
            _context.Sektorler.Update(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<SektorDto>(entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Sektorler
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            if (entity == null) return false;

            entity.IsDeleted = true;
            entity.DeletedAt = DateTime.UtcNow;

            _context.Sektorler.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
