using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SMSAyarManager : ISMSAyarService
    {
        private readonly ISMSAyarDal _smsAyarDal;

        public SMSAyarManager(ISMSAyarDal smsAyarDal)
        {
            _smsAyarDal = smsAyarDal;
        }

        public async Task AddAsync(SMSAyar smsAyar)
        {
            await _smsAyarDal.AddAsync(smsAyar);
        }

        public async Task DeleteAsync(int smsAyarId)
        {
            await _smsAyarDal.DeleteAsync(new SMSAyar { Id = smsAyarId });
        }

        public async Task<List<SMSAyar>> GetAllAsync()
        {
            return await _smsAyarDal.GetListAsync();
        }

        public async Task<SMSAyar> GetByIdAsync(int smsAyarId)
        {
            return await _smsAyarDal.GetAsync(x => x.Id == smsAyarId);
        }

        public async Task<SMSAyar> GetByNameAsync(string smsAyarName)
        {
            return await _smsAyarDal.GetAsync(x => x.KullaniciAdi == smsAyarName);
        }

        public async Task UpdateAsync(SMSAyar smsAyar)
        {
            await _smsAyarDal.UpdateAsync(smsAyar);
        }
    }
}
