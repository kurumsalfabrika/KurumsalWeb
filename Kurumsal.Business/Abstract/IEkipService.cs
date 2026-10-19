using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IEkipService
    {
        Task AddAsync(Ekip ekip);
        Task DeleteAsync(int ekipId);
        Task<List<Ekip>> GetAllAsync();
        Task<Ekip> GetByIdAsync(int ekipId);
        Task<Ekip> GetByNameAsync(string ekipName);
        Task UpdateAsync(Ekip ekip);
    }
}
