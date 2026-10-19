using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISubeService
    {
        Task<List<Sube>> GetAllAsync();
        Task<Sube> GetByIdAsync(int subeId);
        Task<Sube> GetByNameAsync(string subeName);
        Task AddAsync(Sube sube);
        Task UpdateAsync(Sube sube);
        Task DeleteAsync(int subeId);
    }
}
