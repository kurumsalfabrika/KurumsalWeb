using Kurumsal.Application.DTOs.Tenant;

namespace Kurumsal.Application.Interfaces
{
    public interface ITenantService
    {
        Task<List<TenantDto>> GetAllAsync();
        Task<TenantDto?> GetByIdAsync(Guid id);
        Task<TenantDto> CreateAsync(TenantCreateDto dto);
        Task<TenantDto> UpdateAsync(TenantUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
