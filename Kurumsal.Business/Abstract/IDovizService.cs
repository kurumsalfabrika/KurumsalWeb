using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IDovizService
    {
        Task<List<Doviz>> GetAllAsync();
        Task<Doviz> GetByIdAsync(long entityId);
        Task<Doviz> GetByNameAsync(string entityName);
        Task AddAsync(Doviz entity);
        Task UpdateAsync(Doviz entity);
        Task DeleteAsync(int entityId);
    }
}
