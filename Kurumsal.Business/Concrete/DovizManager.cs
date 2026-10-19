using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class DovizManager : IDovizService
    {
        private readonly IDovizDal _dovizDal;

        public DovizManager(IDovizDal dovizDal)
        {
            _dovizDal = dovizDal;
        }

        public async Task AddAsync(Doviz doviz)
        {
            await _dovizDal.AddAsync(doviz);
        }

        public async Task DeleteAsync(int dovizId)
        {
            await _dovizDal.DeleteAsync(new Doviz { Id = dovizId });
        }

        public async Task<List<Doviz>> GetAllAsync()
        {
            return await _dovizDal.GetListAsync();
        }

        public async Task<Doviz> GetByIdAsync(int dovizId)
        {
            return await _dovizDal.GetAsync(x => x.Id == dovizId);
        }

        public async Task<Doviz> GetByIdAsync(long entityId)
        {
            return await _dovizDal.GetAsync(x => x.Id == entityId);
        }

        public async Task<Doviz> GetByNameAsync(string dovizName)
        {
            return await _dovizDal.GetAsync(x => x.Kod == dovizName);
        }

        public async Task UpdateAsync(Doviz doviz)
        {
            await _dovizDal.UpdateAsync(doviz);
        }
    }
}
