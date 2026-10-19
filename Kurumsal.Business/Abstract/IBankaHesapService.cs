using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IBankaHesapService
    {
        Task<List<BankaHesap>> GetAllAsync();
        Task<BankaHesap> GetByIdAsync(int bankahesapId);
        Task<BankaHesap> GetByNameAsync(string bankahesapName);
        Task AddAsync(BankaHesap bankahesap);
        Task UpdateAsync(BankaHesap bankahesap);
        Task DeleteAsync(int bankahesapId);
    }
}
