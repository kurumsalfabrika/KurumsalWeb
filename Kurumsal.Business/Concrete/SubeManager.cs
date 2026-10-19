using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SubeManager : ISubeService
    {
        private readonly ISubeDal _subeDal;

        public SubeManager(ISubeDal subeDal)
        {
            _subeDal = subeDal;
        }

        public async Task AddAsync(Sube sube)
        {
            await _subeDal.AddAsync(sube);
        }

        public async Task DeleteAsync(int subeId)
        {
            await _subeDal.DeleteAsync(new Sube { Id = subeId });
        }

        public async Task<List<Sube>> GetAllAsync()
        {
            return await _subeDal.GetListAsync();
        }

        public async Task<Sube> GetByIdAsync(int subeId)
        {
            return await _subeDal.GetAsync(x => x.Id == subeId);
        }

        public async Task<Sube> GetByNameAsync(string subeName)
        {
            return await _subeDal.GetAsync(x => x.SubeAdi == subeName);
        }

        public async Task UpdateAsync(Sube sube)
        {
            await _subeDal.UpdateAsync(sube);
        }
    }
}
