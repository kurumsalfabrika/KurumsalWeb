using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IPaketService
    {
        Task<List<Paket>> GetAllAsync();
        Task<Paket> GetByIdAsync(int paketId);
        Task<Paket> GetByNameAsync(string paketName);
        Task AddAsync(Paket paket);
        Task UpdateAsync(Paket paket);
        Task DeleteAsync(int paketId);
    }
}
