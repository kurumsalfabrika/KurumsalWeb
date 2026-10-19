using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IProjeService
    {
        Task<List<Proje>> GetAllAsync();
        Task<Proje> GetByIdAsync(int projeId);
        Task<Proje> GetByNameAsync(string projeName);
        Task AddAsync(Proje proje);
        Task UpdateAsync(Proje proje);
        Task DeleteAsync(int projeId);
    }
}
