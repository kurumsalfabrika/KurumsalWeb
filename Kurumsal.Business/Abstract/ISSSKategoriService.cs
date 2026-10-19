using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISSSKategoriService
    {
        Task<List<SSSKategori>> GetAllAsync();
        Task<SSSKategori> GetByIdAsync(int sSSKategoriId);
        Task<SSSKategori> GetByNameAsync(string sSSKategoriName);
        Task AddAsync(SSSKategori sSSKategori);
        Task UpdateAsync(SSSKategori sSSKategori);
        Task DeleteAsync(int sSSKategoriId);
    }
}
