using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IRehberService
    {
        Task<List<Rehber>> GetAllAsync();
        Task<Rehber> GetByIdAsync(int rehberId);
        Task<Rehber> GetByNameAsync(string rehberName);
        Task AddAsync(Rehber rehber);
        Task UpdateAsync(Rehber rehber);
        Task DeleteAsync(int rehberId);
    }
}
