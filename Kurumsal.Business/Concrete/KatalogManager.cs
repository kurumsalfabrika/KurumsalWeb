using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class KatalogManager : IKatalogService
    {
        private readonly IKatalogDal _katalogDal;

        public KatalogManager(IKatalogDal katalogDal)
        {
            _katalogDal = katalogDal;
        }

        public async Task AddAsync(Katalog katalog)
        {
            await _katalogDal.AddAsync(katalog);
        }

        public async Task DeleteAsync(int katalogId)
        {
            await _katalogDal.DeleteAsync(new Katalog { Id = katalogId });
        }

        public async Task<List<Katalog>> GetAllAsync()
        {
            return await _katalogDal.GetListAsync();
        }

        public async Task<Katalog> GetByIdAsync(int katalogId)
        {
            return await _katalogDal.GetAsync(x => x.Id == katalogId);
        }

        public async Task<Katalog> GetByNameAsync(string katalogName)
        {
            return await _katalogDal.GetAsync(x => x.Baslik == katalogName);
        }

        public async Task UpdateAsync(Katalog katalog)
        {
            await _katalogDal.UpdateAsync(katalog);
        }
    }
}
