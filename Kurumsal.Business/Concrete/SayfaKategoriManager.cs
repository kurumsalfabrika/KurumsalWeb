using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SayfaKategoriManager : ISayfaKategoriService
    {
        private readonly ISayfaKategoriDal _sayfakategoriDal;

        public SayfaKategoriManager(ISayfaKategoriDal sayfakategoriDal)
        {
            _sayfakategoriDal = sayfakategoriDal;
        }

        public async Task AddAsync(SayfaKategori sayfakategori)
        {
            await _sayfakategoriDal.AddAsync(sayfakategori);
        }

        public async Task DeleteAsync(int sayfakategoriId)
        {
            await _sayfakategoriDal.DeleteAsync(new SayfaKategori { Id = sayfakategoriId });
        }

        public async Task<List<SayfaKategori>> GetAllAsync()
        {
            return await _sayfakategoriDal.GetListAsync();
        }

        public async Task<SayfaKategori> GetByIdAsync(int sayfakategoriId)
        {
            return await _sayfakategoriDal.GetAsync(x => x.Id == sayfakategoriId);
        }

        public async Task<SayfaKategori> GetByNameAsync(string sayfakategoriName)
        {
            return await _sayfakategoriDal.GetAsync(x => x.SEOKelimeler == sayfakategoriName);
        }

        public async Task UpdateAsync(SayfaKategori sayfakategori)
        {
            await _sayfakategoriDal.UpdateAsync(sayfakategori);
        }
    }
}
