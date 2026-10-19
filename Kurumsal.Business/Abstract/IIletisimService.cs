using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
	public interface IIletisimService
    {
        Task<List<Iletisim>> GetAllAsync();
        Task<Iletisim> GetByIdAsync(int iletisimId);
        Task<Iletisim> GetByNameAsync(string iletisimName);
        Task AddAsync(Iletisim iletisim);
        Task UpdateAsync(Iletisim iletisim);
        Task DeleteAsync(int iletisimId);
    }
}
