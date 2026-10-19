using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class ProjeKategoriManager : IProjeKategoriService
    {
        private readonly IProjeKategoriDal _projeKategoriDal;

        public ProjeKategoriManager(IProjeKategoriDal projeKategoriDal)
        {
            _projeKategoriDal = projeKategoriDal;
        }

        public async Task AddAsync(ProjeKategori projeKategori)
        {
            await _projeKategoriDal.AddAsync(projeKategori);
        }

        public async Task DeleteAsync(int projeKategoriId)
        {
            await _projeKategoriDal.DeleteAsync(new ProjeKategori { Id = projeKategoriId });
        }

        public async Task<List<ProjeKategori>> GetAllAsync()
        {
            return await _projeKategoriDal.GetListAsync();
        }

        public async Task<ProjeKategori> GetByIdAsync(int projeKategoriId)
        {
            return await _projeKategoriDal.GetAsync(x => x.Id == projeKategoriId);
        }

        public async Task<ProjeKategori> GetByNameAsync(string projeKategoriName)
        {
            return await _projeKategoriDal.GetAsync(x => x.KategoriAdi == projeKategoriName);
        }

        public async Task UpdateAsync(ProjeKategori projeKategori)
        {
            await _projeKategoriDal.UpdateAsync(projeKategori);
        }
    }
}
