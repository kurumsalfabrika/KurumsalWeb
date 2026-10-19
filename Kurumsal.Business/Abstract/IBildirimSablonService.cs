using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IBildirimSablonService
    {
        Task<List<BildirimSablon>> GetAllAsync();
        Task<BildirimSablon> GetByIdAsync(int bildirimsablonId);
        Task<BildirimSablon> GetByNameAsync(string bildirimsablonName);
        Task AddAsync(BildirimSablon bildirimsablon);
        Task UpdateAsync(BildirimSablon bildirimsablon);
        Task DeleteAsync(int bildirimsablonId);
    }
}
