using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IApiAyarService
    {
        Task<List<ApiAyar>> GetAllAsync();
        Task<ApiAyar> GetByIdAsync(int apiayarId);
        Task<ApiAyar> GetByNameAsync(string apiayarName);
        Task AddAsync(ApiAyar apiayar);
        Task UpdateAsync(ApiAyar apiayar);
        Task DeleteAsync(int apiayarId);
    }
}
