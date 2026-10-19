using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SosyalMedyaAyarManager : ISosyalMedyaAyarService
    {
        private readonly ISosyalMedyaAyarDal _sosyalMedyaAyarDal;

        public SosyalMedyaAyarManager(ISosyalMedyaAyarDal sosyalMedyaAyarDal)
        {
            _sosyalMedyaAyarDal = sosyalMedyaAyarDal;
        }

        public async Task AddAsync(SosyalMedyaAyar sosyalMedyaAyar)
        {
            await _sosyalMedyaAyarDal.AddAsync(sosyalMedyaAyar);
        }

        public async Task DeleteAsync(int sosyalMedyaAyarId)
        {
            await _sosyalMedyaAyarDal.DeleteAsync(new SosyalMedyaAyar { Id = sosyalMedyaAyarId });
        }

        public async Task<List<SosyalMedyaAyar>> GetAllAsync()
        {
            return await _sosyalMedyaAyarDal.GetListAsync();
        }

        public async Task<SosyalMedyaAyar> GetByIdAsync(int sosyalMedyaAyarId)
        {
            return await _sosyalMedyaAyarDal.GetAsync(x => x.Id == sosyalMedyaAyarId);
        }

        public async Task<SosyalMedyaAyar> GetByNameAsync(string sosyalMedyaAyarName)
        {
            return await _sosyalMedyaAyarDal.GetAsync(x => x.Instagram == sosyalMedyaAyarName);
        }

        public async Task UpdateAsync(SosyalMedyaAyar sosyalMedyaAyar)
        {
            await _sosyalMedyaAyarDal.UpdateAsync(sosyalMedyaAyar);
        }
    }
}
