using Kurumsal.Application.DTOs.Ilce;

namespace Kurumsal.Application.Interfaces
{
    public interface IIlceService
    {
        Task<List<IlceDto>> GetAllAsync();
        Task<List<IlceDto>> GetBySehirIdAsync(Guid sehirId); 
        Task<IlceDto?> GetByIdAsync(Guid id);
        Task<IlceDto> CreateAsync(IlceCreateDto dto);
        Task<IlceDto> UpdateAsync(IlceUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
