using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISayfaKategoriService
    {
        Task<List<SayfaKategori>> GetAllAsync();
        Task<SayfaKategori> GetByIdAsync(int sayfaKategoriId);
        Task<SayfaKategori> GetByNameAsync(string sayfaKategoriName);
        Task AddAsync(SayfaKategori sayfaKategori);
        Task UpdateAsync(SayfaKategori sayfaKategori);
        Task DeleteAsync(int sayfaKategoriId);
    }
}
