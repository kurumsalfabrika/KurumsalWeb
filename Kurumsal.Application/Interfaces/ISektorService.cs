using Kurumsal.Application.DTOs.Sektor;

namespace Kurumsal.Application.Interfaces
{
    public interface ISektorService
    {
        Task<List<SektorDto>> GetAllAsync();
        Task<SektorDto?> GetByIdAsync(Guid id);
        Task<SektorDto> CreateAsync(SektorCreateDto dto);
        Task<SektorDto> UpdateAsync(SektorUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
