using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class GenelAyarManager : IGenelAyarService
    {
        private readonly IGenelAyarDal _genelayarDal;

        public GenelAyarManager(IGenelAyarDal genelayarDal)
        {
            _genelayarDal = genelayarDal;
        }

        public async Task AddAsync(GenelAyar genelayar)
        {
            await _genelayarDal.AddAsync(genelayar);
        }

        public async Task DeleteAsync(int genelayarId)
        {
            await _genelayarDal.DeleteAsync(new GenelAyar { Id = genelayarId });
        }

        public async Task<List<GenelAyar>> GetAllAsync()
        {
            return await _genelayarDal.GetListAsync();
        }

        public async Task<GenelAyar> GetByIdAsync(int genelayarId)
        {
            return await _genelayarDal.GetAsync(x => x.Id == genelayarId);
        }

        public async Task<GenelAyar> GetByNameAsync(string genelayarName)
        {
            return await _genelayarDal.GetAsync(x => x.GenelRenk1 == genelayarName);
        }

        public async Task UpdateAsync(GenelAyar genelayar)
        {
            await _genelayarDal.UpdateAsync(genelayar);
        }
    }
}
