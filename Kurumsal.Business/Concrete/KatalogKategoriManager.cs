using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class KatalogKategoriManager : IKatalogKategoriService
    {
        private readonly IKatalogKategoriDal _katalogKategoriDal;

        public KatalogKategoriManager(IKatalogKategoriDal katalogKategoriDal)
        {
            _katalogKategoriDal = katalogKategoriDal;
        }

        public async Task AddAsync(KatalogKategori katalogKategori)
        {
            await _katalogKategoriDal.AddAsync(katalogKategori);
        }

        public async Task DeleteAsync(int katalogKategoriId)
        {
            await _katalogKategoriDal.DeleteAsync(new KatalogKategori { Id = katalogKategoriId });
        }

        public async Task<List<KatalogKategori>> GetAllAsync()
        {
            return await _katalogKategoriDal.GetListAsync();
        }

        public async Task<KatalogKategori> GetByIdAsync(int katalogKategoriId)
        {
            return await _katalogKategoriDal.GetAsync(x => x.Id == katalogKategoriId);
        }

        public async Task<KatalogKategori> GetByNameAsync(string katalogKategoriName)
        {
            return await _katalogKategoriDal.GetAsync(x => x.KategoriAdi == katalogKategoriName);
        }

        public async Task UpdateAsync(KatalogKategori katalogKategori)
        {
            await _katalogKategoriDal.UpdateAsync(katalogKategori);
        }
    }
}
