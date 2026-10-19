using Kurumsal.Application.DTOs.Doviz;

namespace Kurumsal.Application.Interfaces
{
    public interface IDovizService
    {
        Task<List<DovizDto>> GetAllAsync();
        Task<List<DovizDto>> GetByTenantIdAsync(Guid tenantId); 
        Task<DovizDto?> GetByIdAsync(Guid id);
        Task<DovizDto> CreateAsync(DovizCreateDto dto);
        Task<DovizDto> UpdateAsync(DovizUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
