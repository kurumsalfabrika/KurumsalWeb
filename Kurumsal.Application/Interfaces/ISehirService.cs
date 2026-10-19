// ISehirService.cs
using Kurumsal.Application.DTOs.Sehir;

namespace Kurumsal.Application.Interfaces;

public interface ISehirService
{
    Task<List<SehirDto>> GetAllAsync();
    Task<List<SehirDto>> GetByUlkeIdAsync(Guid ulkeId);
    Task<SehirDto?> GetByIdAsync(Guid id);
    Task<SehirDto> CreateAsync(SehirCreateDto dto);
    Task<SehirDto> UpdateAsync(SehirUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
}
