using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class ApiAyarManager : IApiAyarService
    {
        private readonly IApiAyarDal _apiAyarDal;

        public ApiAyarManager(IApiAyarDal apiAyarDal)
        {
            _apiAyarDal = apiAyarDal;
        }

        public async Task AddAsync(ApiAyar apiAyar)
        {
            await _apiAyarDal.AddAsync(apiAyar);
        }

        public async Task DeleteAsync(int apiAyarId)
        {
            await _apiAyarDal.DeleteAsync(new ApiAyar { Id = apiAyarId });
        }

        public async Task<List<ApiAyar>> GetAllAsync()
        {
            return await _apiAyarDal.GetListAsync();
        }

        public async Task<ApiAyar> GetByIdAsync(int apiAyarId)
        {
            return await _apiAyarDal.GetAsync(x => x.Id == apiAyarId);
        }

        public async Task<ApiAyar> GetByNameAsync(string apiAyarName)
        {
            return await _apiAyarDal.GetAsync(x => x.CanliDestekKodu == apiAyarName);
        }

        public async Task UpdateAsync(ApiAyar apiAyar)
        {
            await _apiAyarDal.UpdateAsync(apiAyar);
        }
    }
}
