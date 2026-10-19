
using Kurumsal.Application.DTOs.Ulke;

namespace Kurumsal.Application.Interfaces;

public interface IUlkeService
{
    Task<List<UlkeDto>> GetAllAsync();
    Task<UlkeDto?> GetByIdAsync(Guid id);
    Task<UlkeDto> CreateAsync(UlkeCreateDto dto);
    Task<UlkeDto> UpdateAsync(UlkeUpdateDto dto);
    Task<bool> DeleteAsync(Guid id);
}
