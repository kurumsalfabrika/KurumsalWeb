using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class PaketManager : IPaketService
    {
        private readonly IPaketDal _paketDal;

        public PaketManager(IPaketDal paketDal)
        {
            _paketDal = paketDal;
        }

        public async Task AddAsync(Paket paket)
        {
            await _paketDal.AddAsync(paket);
        }

        public async Task DeleteAsync(int paketId)
        {
            await _paketDal.DeleteAsync(new Paket { Id = paketId });
        }

        public async Task<List<Paket>> GetAllAsync()
        {
            return await _paketDal.GetListAsync();
        }

        public async Task<Paket> GetByIdAsync(int paketId)
        {
            return await _paketDal.GetAsync(x => x.Id == paketId);
        }

        public async Task<Paket> GetByNameAsync(string paketName)
        {
            return await _paketDal.GetAsync(x => x.Baslik == paketName);
        }

        public async Task UpdateAsync(Paket paket)
        {
            await _paketDal.UpdateAsync(paket);
        }
    }
}
