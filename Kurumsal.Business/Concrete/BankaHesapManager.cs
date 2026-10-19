using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class BankaHesapManager : IBankaHesapService
    {
        private readonly IBankaHesapDal _bankaHesapDal;

        public BankaHesapManager(IBankaHesapDal bankaHesapDal)
        {
            _bankaHesapDal = bankaHesapDal;
        }

        public async Task AddAsync(BankaHesap bankaHesap)
        {
            await _bankaHesapDal.AddAsync(bankaHesap);
        }

        public async Task DeleteAsync(int bankaHesapId)
        {
            await _bankaHesapDal.DeleteAsync(new BankaHesap { Id = bankaHesapId });
        }

        public async Task<List<BankaHesap>> GetAllAsync()
        {
            return await _bankaHesapDal.GetListAsync();
        }

        public async Task<BankaHesap> GetByIdAsync(int bankaHesapId)
        {
            return await _bankaHesapDal.GetAsync(x => x.Id == bankaHesapId);
        }

        public async Task<BankaHesap> GetByNameAsync(string bankaHesapName)
        {
            return await _bankaHesapDal.GetAsync(x => x.HesapAdi == bankaHesapName);
        }

        public async Task UpdateAsync(BankaHesap bankaHesap)
        {
            await _bankaHesapDal.UpdateAsync(bankaHesap);
        }
    }
}
