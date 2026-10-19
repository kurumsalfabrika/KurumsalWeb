using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SSSKategoriManager : ISSSKategoriService
    {
        private readonly ISSSKategoriDal _sSSKategoriDal;

        public SSSKategoriManager(ISSSKategoriDal sSSKategoriDal)
        {
            _sSSKategoriDal = sSSKategoriDal;
        }

        public async Task AddAsync(SSSKategori sSSKategori)
        {
            await _sSSKategoriDal.AddAsync(sSSKategori);
        }

        public async Task DeleteAsync(int sSSKategoriId)
        {
            await _sSSKategoriDal.DeleteAsync(new SSSKategori { Id = sSSKategoriId });
        }

        public async Task<List<SSSKategori>> GetAllAsync()
        {
            return await _sSSKategoriDal.GetListAsync();
        }

        public async Task<SSSKategori> GetByIdAsync(int sSSKategoriId)
        {
            return await _sSSKategoriDal.GetAsync(x => x.Id == sSSKategoriId);
        }

        public async Task<SSSKategori> GetByNameAsync(string sSSKategoriName)
        {
            return await _sSSKategoriDal.GetAsync(x => x.KategoriAdi == sSSKategoriName);
        }

        public async Task UpdateAsync(SSSKategori sSSKategori)
        {
            await _sSSKategoriDal.UpdateAsync(sSSKategori);
        }
    }
}
