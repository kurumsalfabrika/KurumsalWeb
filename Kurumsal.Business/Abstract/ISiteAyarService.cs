using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISiteAyarService
    {
        Task<List<SiteAyar>> GetAllAsync();
        Task<SiteAyar> GetByIdAsync(int siteAyarId);
        Task<SiteAyar> GetByNameAsync(string siteAyarName);
        Task AddAsync(SiteAyar siteAyar);
        Task UpdateAsync(SiteAyar siteAyar);
        Task DeleteAsync(int siteAyarId);
    }
}
