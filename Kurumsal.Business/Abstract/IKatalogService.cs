using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IKatalogService
    {
        Task<List<Katalog>> GetAllAsync();
        Task<Katalog> GetByIdAsync(int katalogId);
        Task<Katalog> GetByNameAsync(string katalogName);
        Task AddAsync(Katalog katalog);
        Task UpdateAsync(Katalog katalog);
        Task DeleteAsync(int katalogId);
    }
}
