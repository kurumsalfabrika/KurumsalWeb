using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
	public class IletisimManager : IIletisimService
	{
        private readonly IIletisimDal _iletisimDal;

        public IletisimManager(IIletisimDal iletisimDal)
        {
            _iletisimDal = iletisimDal;
        }

        public async Task AddAsync(Iletisim iletisim)
        {
            await _iletisimDal.AddAsync(iletisim);
        }

        public async Task DeleteAsync(int iletisimId)
        {
            await _iletisimDal.DeleteAsync(new Iletisim { Id = iletisimId });
        }

        public async Task<List<Iletisim>> GetAllAsync()
        {
            return await _iletisimDal.GetListAsync();
        }

        public async Task<Iletisim> GetByIdAsync(int iletisimId)
        {
            return await _iletisimDal.GetAsync(x => x.Id == iletisimId);
        }

        public async Task<Iletisim> GetByNameAsync(string iletisimName)
        {
            return await _iletisimDal.GetAsync(x => x.Ad == iletisimName);
        }

        public async Task UpdateAsync(Iletisim iletisim)
        {
            await _iletisimDal.UpdateAsync(iletisim);
        }
    }
}
