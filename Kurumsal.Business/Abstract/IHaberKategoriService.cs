using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IHaberKategoriService
    {
        Task<List<HaberKategori>> GetAllAsync();
        Task<HaberKategori> GetByIdAsync(int haberKategoriId);
        Task<HaberKategori> GetByNameAsync(string haberKategoriName);
        Task AddAsync(HaberKategori haberKategori);
        Task UpdateAsync(HaberKategori haberKategori);
        Task DeleteAsync(int haberKategoriId);
    }
}
