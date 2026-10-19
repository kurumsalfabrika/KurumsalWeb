using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SosyalMedyaAdresManager : ISosyalMedyaAdresService
    {
        private readonly ISosyalMedyaAdresDal _sosyalMedyaAdresDal;

        public SosyalMedyaAdresManager(ISosyalMedyaAdresDal sosyalMedyaAdresDal)
        {
            _sosyalMedyaAdresDal = sosyalMedyaAdresDal;
        }

        public async Task AddAsync(SosyalMedyaAdres sosyalMedyaAdres)
        {
            await _sosyalMedyaAdresDal.AddAsync(sosyalMedyaAdres);
        }

        public async Task DeleteAsync(int sosyalMedyaAdresId)
        {
            await _sosyalMedyaAdresDal.DeleteAsync(new SosyalMedyaAdres { Id = sosyalMedyaAdresId });
        }

        public async Task<List<SosyalMedyaAdres>> GetAllAsync()
        {
            return await _sosyalMedyaAdresDal.GetListAsync();
        }

        public async Task<SosyalMedyaAdres> GetByIdAsync(int sosyalMedyaAdresId)
        {
            return await _sosyalMedyaAdresDal.GetAsync(x => x.Id == sosyalMedyaAdresId);
        }

        public async Task<SosyalMedyaAdres> GetByNameAsync(string sosyalMedyaAdresName)
        {
            return await _sosyalMedyaAdresDal.GetAsync(x => x.Ad == sosyalMedyaAdresName);
        }

        public async Task UpdateAsync(SosyalMedyaAdres sosyalMedyaAdres)
        {
            await _sosyalMedyaAdresDal.UpdateAsync(sosyalMedyaAdres);
        }
    }
}
