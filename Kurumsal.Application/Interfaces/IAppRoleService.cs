using Kurumsal.Application.DTOs.Role;

namespace Kurumsal.Application.Interfaces
{
    public interface IAppRoleService
    {
        Task<List<AppRoleDto>> GetAllAsync();                         // geçerli tenant + global
        Task<List<AppRoleDto>> GetByTenantIdAsync(Guid tenantId);     // belirli tenant
        Task<AppRoleDto?> GetByIdAsync(Guid id);
        Task<AppRoleDto> CreateAsync(AppRoleCreateDto dto);
        Task<AppRoleDto> UpdateAsync(AppRoleUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
