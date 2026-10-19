using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class HaberKategoriManager : IHaberKategoriService
    {
        private readonly IHaberKategoriDal _haberKategoriDal;

        public HaberKategoriManager(IHaberKategoriDal haberKategoriDal)
        {
            _haberKategoriDal = haberKategoriDal;
        }

        public async Task AddAsync(HaberKategori haberKategori)
        {
            await _haberKategoriDal.AddAsync(haberKategori);
        }

        public async Task DeleteAsync(int haberKategoriId)
        {
            await _haberKategoriDal.DeleteAsync(new HaberKategori { Id = haberKategoriId });
        }

        public async Task<List<HaberKategori>> GetAllAsync()
        {
            return await _haberKategoriDal.GetListAsync();
        }

        public async Task<HaberKategori> GetByIdAsync(int haberKategoriId)
        {
            return await _haberKategoriDal.GetAsync(x => x.Id == haberKategoriId);
        }

        public async Task<HaberKategori> GetByNameAsync(string haberKategoriName)
        {
            return await _haberKategoriDal.GetAsync(x => x.KategoriAdi == haberKategoriName);
        }

        public async Task UpdateAsync(HaberKategori haberKategori)
        {
            await _haberKategoriDal.UpdateAsync(haberKategori);
        }
    }
}
