using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class AcilirMesajManager : IAcilirMesajService
    {
        private readonly IAcilirMesajDal _acilirMesajDal;

        public AcilirMesajManager(IAcilirMesajDal acilirMesajDal)
        {
            _acilirMesajDal = acilirMesajDal;
        }

        public async Task AddAsync(AcilirMesaj acilirMesaj)
        {
            await _acilirMesajDal.AddAsync(acilirMesaj);
        }

        public async Task DeleteAsync(int acilirMesajId)
        {
            await _acilirMesajDal.DeleteAsync(new AcilirMesaj { Id = acilirMesajId });
        }

        public async Task<List<AcilirMesaj>> GetAllAsync()
        {
            return await _acilirMesajDal.GetListAsync();
        }

        public async Task<AcilirMesaj> GetByIdAsync(int acilirMesajId)
        {
            return await _acilirMesajDal.GetAsync(x => x.Id == acilirMesajId);
        }

        public async Task<AcilirMesaj> GetByNameAsync(string acilirMesajName)
        {
            return await _acilirMesajDal.GetAsync(x => x.MesajAdi == acilirMesajName);
        }

        public async Task UpdateAsync(AcilirMesaj acilirMesaj)
        {
            await _acilirMesajDal.UpdateAsync(acilirMesaj);
        }
    }
}
