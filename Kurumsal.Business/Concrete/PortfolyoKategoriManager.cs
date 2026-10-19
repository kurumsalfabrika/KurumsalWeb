using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class PortfolyoKategoriManager : IPortfolyoKategoriService
    {
        private readonly IPortfolyoKategoriDal _portfolyoKategoriDal;

        public PortfolyoKategoriManager(IPortfolyoKategoriDal portfolyoKategoriDal)
        {
            _portfolyoKategoriDal = portfolyoKategoriDal;
        }

        public async Task AddAsync(PortfolyoKategori portfolyoKategori)
        {
            await _portfolyoKategoriDal.AddAsync(portfolyoKategori);
        }

        public async Task DeleteAsync(int portfolyoKategoriId)
        {
            await _portfolyoKategoriDal.DeleteAsync(new PortfolyoKategori { Id = portfolyoKategoriId });
        }

        public async Task<List<PortfolyoKategori>> GetAllAsync()
        {
            return await _portfolyoKategoriDal.GetListAsync();
        }

        public async Task<PortfolyoKategori> GetByIdAsync(int portfolyoKategoriId)
        {
            return await _portfolyoKategoriDal.GetAsync(x => x.Id == portfolyoKategoriId);
        }

        public async Task<PortfolyoKategori> GetByNameAsync(string portfolyoKategoriName)
        {
            return await _portfolyoKategoriDal.GetAsync(x => x.KategoriAdi == portfolyoKategoriName);
        }

        public async Task UpdateAsync(PortfolyoKategori portfolyoKategori)
        {
            await _portfolyoKategoriDal.UpdateAsync(portfolyoKategori);
        }
    }
}
