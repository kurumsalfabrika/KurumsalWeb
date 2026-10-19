using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class MailAyarManager : IMailAyarService
    {
        private readonly IMailAyarDal _mailAyarDal;

        public MailAyarManager(IMailAyarDal mailAyarDal)
        {
            _mailAyarDal = mailAyarDal;
        }

        public async Task AddAsync(MailAyar mailAyar)
        {
            await _mailAyarDal.AddAsync(mailAyar);
        }

        public async Task DeleteAsync(int mailAyarId)
        {
            await _mailAyarDal.DeleteAsync(new MailAyar { Id = mailAyarId });
        }

        public async Task<List<MailAyar>> GetAllAsync()
        {
            return await _mailAyarDal.GetListAsync();
        }

        public async Task<MailAyar> GetByIdAsync(int mailAyarId)
        {
            return await _mailAyarDal.GetAsync(x => x.Id == mailAyarId);
        }

        public async Task<MailAyar> GetByNameAsync(string mailAyarName)
        {
            return await _mailAyarDal.GetAsync(x => x.MesajinGelecegiEposta == mailAyarName);
        }

        public async Task UpdateAsync(MailAyar mailAyar)
        {
            await _mailAyarDal.UpdateAsync(mailAyar);
        }
    }
}
