using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class BildirimSablonManager : IBildirimSablonService
    {
        private readonly IBildirimSablonDal _bildirimSablonDal;

        public BildirimSablonManager(IBildirimSablonDal bildirimSablonDal)
        {
            _bildirimSablonDal = bildirimSablonDal;
        }

        public async Task AddAsync(BildirimSablon bildirimSablon)
        {
            await _bildirimSablonDal.AddAsync(bildirimSablon);
        }

        public async Task DeleteAsync(int bildirimSablonId)
        {
            await _bildirimSablonDal.DeleteAsync(new BildirimSablon { Id = bildirimSablonId });
        }

        public async Task<List<BildirimSablon>> GetAllAsync()
        {
            return await _bildirimSablonDal.GetListAsync();
        }

        public async Task<BildirimSablon> GetByIdAsync(int bildirimSablonId)
        {
            return await _bildirimSablonDal.GetAsync(x => x.Id == bildirimSablonId);
        }

        public async Task<BildirimSablon> GetByNameAsync(string bildirimSablonName)
        {
            return await _bildirimSablonDal.GetAsync(x => x.EpostaKonuBasligiUye == bildirimSablonName);
        }

        public async Task UpdateAsync(BildirimSablon bildirimSablon)
        {
            await _bildirimSablonDal.UpdateAsync(bildirimSablon);
        }
    }
}
