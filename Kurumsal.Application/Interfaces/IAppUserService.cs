using Kurumsal.Application.DTOs.AppUser;

namespace Kurumsal.Application.Interfaces
{
    public interface IAppUserService
    {
        Task<List<AppUserDto>> GetAllAsync();                     // geçerli tenant
        Task<List<AppUserDto>> GetByTenantIdAsync(Guid tenantId); // belirli tenant
        Task<AppUserDto?> GetByIdAsync(Guid id);
        Task<AppUserDto> CreateAsync(AppUserCreateDto dto);
        Task<AppUserDto> UpdateAsync(AppUserUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
