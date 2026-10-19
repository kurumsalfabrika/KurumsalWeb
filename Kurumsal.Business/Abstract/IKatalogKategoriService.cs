using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IKatalogKategoriService
    {
        Task<List<KatalogKategori>> GetAllAsync();
        Task<KatalogKategori> GetByIdAsync(int katalogkategoriId);
        Task<KatalogKategori> GetByNameAsync(string katalogkategoriName);
        Task AddAsync(KatalogKategori katalogkategori);
        Task UpdateAsync(KatalogKategori katalogkategori);
        Task DeleteAsync(int katalogkategoriId);
    }
}
