using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IGenelAyarService
    {
        Task<List<GenelAyar>> GetAllAsync();
        Task<GenelAyar> GetByIdAsync(int genelayarId);
        Task<GenelAyar> GetByNameAsync(string genelayarName);
        Task AddAsync(GenelAyar genelayar);
        Task UpdateAsync(GenelAyar genelayar);
        Task DeleteAsync(int genelayarId);
    }
}
