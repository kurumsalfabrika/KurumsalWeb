using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class EkipManager : IEkipService
    {
        private IEkipDal _ekipDal;

        public EkipManager(IEkipDal ekipDal)
        {
            _ekipDal = ekipDal;
        }

        public async Task AddAsync(Ekip ekip)
        {
            await _ekipDal.AddAsync(ekip);
        }

        public async Task DeleteAsync(int ekipId)
        {
            await _ekipDal.DeleteAsync(new Ekip { Id = ekipId });
        }

        public async Task<List<Ekip>> GetAllAsync()
        {
            return await _ekipDal.GetListAsync();
        }

        public async Task<Ekip> GetByIdAsync(int ekipId)
        {
            return await _ekipDal.GetAsync(x => x.Id == ekipId);
        }

        public async Task<Ekip> GetByNameAsync(string ekipName)
        {
            return await _ekipDal.GetAsync(x => x.Baslik == ekipName);
        }

        public async Task UpdateAsync(Ekip ekip)
        {
            await _ekipDal.UpdateAsync(ekip);
        }
    }
}
