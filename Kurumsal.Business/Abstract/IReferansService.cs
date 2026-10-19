using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IReferansService
    {
        Task AddAsync(Referans referans);
        Task DeleteAsync(int referansId);
        Task<List<Referans>> GetAllAsync();
        Task<Referans> GetByIdAsync(int referansId);
        Task<Referans> GetByNameAsync(string referansName);
        Task UpdateAsync(Referans referans);
    }
}
