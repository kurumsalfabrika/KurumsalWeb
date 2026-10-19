using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IPortfolyoKategoriService
    {
        Task<List<PortfolyoKategori>> GetAllAsync();
        Task<PortfolyoKategori> GetByIdAsync(int portfolyoKategoriId);
        Task<PortfolyoKategori> GetByNameAsync(string portfolyoKategoriName);
        Task AddAsync(PortfolyoKategori portfolyoKategori);
        Task UpdateAsync(PortfolyoKategori portfolyoKategori);
        Task DeleteAsync(int portfolyoKategoriId);
    }
}
