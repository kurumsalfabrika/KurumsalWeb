using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class BelgeManager : IBelgeService
    {
        private readonly IBelgeDal _belgeDal;

        public BelgeManager(IBelgeDal belgeDal)
        {
            _belgeDal = belgeDal;
        }

        public async Task AddAsync(Belge belge)
        {
            await _belgeDal.AddAsync(belge);
        }

        public async Task DeleteAsync(int belgeId)
        {
            await _belgeDal.DeleteAsync(new Belge { Id = belgeId });
        }

        public async Task<List<Belge>> GetAllAsync()
        {
            return await _belgeDal.GetListAsync();
        }

        public async Task<Belge> GetByIdAsync(int belgeId)
        {
            return await _belgeDal.GetAsync(x => x.Id == belgeId);
        }

        public async Task<Belge> GetByNameAsync(string belgeName)
        {
            return await _belgeDal.GetAsync(x => x.Baslik == belgeName);
        }

        public async Task UpdateAsync(Belge belge)
        {
            await _belgeDal.UpdateAsync(belge);
        }
    }
}
