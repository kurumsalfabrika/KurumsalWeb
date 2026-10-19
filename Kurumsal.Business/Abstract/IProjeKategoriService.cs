using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IProjeKategoriService
    {
        Task<List<ProjeKategori>> GetAllAsync();
        Task<ProjeKategori> GetByIdAsync(int projekategoriId);
        Task<ProjeKategori> GetByNameAsync(string projekategoriName);
        Task AddAsync(ProjeKategori projekategori);
        Task UpdateAsync(ProjeKategori projekategori);
        Task DeleteAsync(int projekategoriId);
    }
}
