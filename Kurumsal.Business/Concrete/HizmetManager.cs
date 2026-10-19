using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class HizmetManager : IHizmetService
    {
        private readonly IHizmetDal _hizmetDal;

        public HizmetManager(IHizmetDal hizmetDal)
        {
            _hizmetDal = hizmetDal;
        }

        public async Task AddAsync(Hizmet hizmet)
        {
            await _hizmetDal.AddAsync(hizmet);
        }

        public async Task DeleteAsync(int hizmetId)
        {
            await _hizmetDal.DeleteAsync(new Hizmet { Id = hizmetId });
        }

        public async Task<List<Hizmet>> GetAllAsync()
        {
            return await _hizmetDal.GetListAsync();
        }

        public async Task<Hizmet> GetByIdAsync(int hizmetId)
        {
            return await _hizmetDal.GetAsync(x => x.Id == hizmetId);
        }

        public async Task<Hizmet> GetByNameAsync(string hizmetName)
        {
            return await _hizmetDal.GetAsync(x => x.OneCikanGorsel == hizmetName);
        }

        public async Task UpdateAsync(Hizmet hizmet)
        {
            await _hizmetDal.UpdateAsync(hizmet);
        }
    }
}
