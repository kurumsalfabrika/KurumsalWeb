using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IHizmetService
    {
        Task<List<Hizmet>> GetAllAsync();
        Task<Hizmet> GetByIdAsync(int hizmetId);
        Task<Hizmet> GetByNameAsync(string hizmetName);
        Task AddAsync(Hizmet hizmet);
        Task UpdateAsync(Hizmet hizmet);
        Task DeleteAsync(int hizmetId);
    }
}
