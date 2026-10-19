using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class MesajManager : IMesajService
    {
        private readonly IMesajDal _mesajDal;

        public MesajManager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public async Task AddAsync(Mesaj mesaj)
        {
            await _mesajDal.AddAsync(mesaj);
        }

        public async Task DeleteAsync(int mesajId)
        {
            await _mesajDal.DeleteAsync(new Mesaj { Id = mesajId });
        }

        public async Task<List<Mesaj>> GetAllAsync()
        {
            return await _mesajDal.GetListAsync();
        }

        public async Task<Mesaj> GetByIdAsync(int mesajId)
        {
            return await _mesajDal.GetAsync(x => x.Id == mesajId);
        }

        public async Task<Mesaj> GetByNameAsync(string mesajName)
        {
            return await _mesajDal.GetAsync(x => x.AdSoyad == mesajName);
        }

        public async Task UpdateAsync(Mesaj mesaj)
        {
            await _mesajDal.UpdateAsync(mesaj);
        }
    }
}
