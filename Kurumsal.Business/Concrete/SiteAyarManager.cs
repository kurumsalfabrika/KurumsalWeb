using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SiteAyarManager : ISiteAyarService
    {
        private readonly ISiteAyarDal _siteAyarDal;

        public SiteAyarManager(ISiteAyarDal siteAyarDal)
        {
            _siteAyarDal = siteAyarDal;
        }

        public async Task AddAsync(SiteAyar siteAyar)
        {
            await _siteAyarDal.AddAsync(siteAyar);
        }

        public async Task DeleteAsync(int siteAyarId)
        {
            await _siteAyarDal.DeleteAsync(new SiteAyar { Id = siteAyarId });
        }

        public async Task<List<SiteAyar>> GetAllAsync()
        {
            return await _siteAyarDal.GetListAsync();
        }

        public async Task<SiteAyar> GetByIdAsync(int siteAyarId)
        {
            return await _siteAyarDal.GetAsync(x => x.Id == siteAyarId);
        }

        public async Task<SiteAyar> GetByNameAsync(string siteAyarName)
        {
            return await _siteAyarDal.GetAsync(x => x.HeaderLogoAcikRenk == siteAyarName);
        }

        public async Task UpdateAsync(SiteAyar siteAyar)
        {
            await _siteAyarDal.UpdateAsync(siteAyar);
        }
    }
}
