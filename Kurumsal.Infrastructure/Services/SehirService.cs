using AutoMapper;
using Kurumsal.Application.DTOs.Sehir;
using Kurumsal.Application.Interfaces;
using Kurumsal.Domain.Entities;
using Kurumsal.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Services
{
    public class SehirService : ISehirService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SehirService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SehirDto>> GetAllAsync()
        {
            var sehirler = await _context.Sehirler
                .Include(s => s.Ulke)
                .Where(x => !x.IsDeleted)
                .ToListAsync();

            return _mapper.Map<List<SehirDto>>(sehirler);
        }


        public async Task<List<SehirDto>> GetByUlkeIdAsync(Guid ulkeId)
        {
            var sehirler = await _context.Sehirler
                .Include(s => s.Ulke)
                .Where(s => !s.IsDeleted && s.UlkeId == ulkeId)
                .ToListAsync();

            return _mapper.Map<List<SehirDto>>(sehirler);
        }

        public async Task<SehirDto?> GetByIdAsync(Guid id)
        {
            var sehir = await _context.Sehirler
                .Include(s => s.Ulke)
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            return _mapper.Map<SehirDto>(sehir);
        }

        public async Task<SehirDto> CreateAsync(SehirCreateDto dto)
        {
            var entity = _mapper.Map<Sehir>(dto);
            _context.Sehirler.Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<SehirDto>(entity);
        }

        public async Task<SehirDto> UpdateAsync(SehirUpdateDto dto)
        {
            var entity = await _context.Sehirler
                .FirstOrDefaultAsync(x => x.Id == dto.Id && !x.IsDeleted);

            if (entity == null) throw new Exception("Kayıt bulunamadı");

            _mapper.Map(dto, entity);
            _context.Sehirler.Update(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<SehirDto>(entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Sehirler
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            if (entity == null) return false;

            entity.IsDeleted = true;
            entity.DeletedAt = DateTime.UtcNow;

            _context.Sehirler.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
