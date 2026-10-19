using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class FtpManager : IFtpService
    {
        private readonly IFtpDal _ftpDal;

        public FtpManager(IFtpDal ftpDal)
        {
            _ftpDal = ftpDal;
        }

        public async Task AddAsync(Ftp ftp)
        {
            await _ftpDal.AddAsync(ftp);
        }

        public async Task DeleteAsync(int ftpId)
        {
            await _ftpDal.DeleteAsync(new Ftp { Id = ftpId });
        }

        public async Task<List<Ftp>> GetAllAsync()
        {
            return await _ftpDal.GetListAsync();
        }

        public async Task<Ftp> GetByIdAsync(int ftpId)
        {
            return await _ftpDal.GetAsync(x => x.Id == ftpId);
        }

        public async Task<Ftp> GetByNameAsync(string ftpName)
        {
            return await _ftpDal.GetAsync(x => x.FtpURL == ftpName);
        }

        public async Task UpdateAsync(Ftp ftp)
        {
            await _ftpDal.UpdateAsync(ftp);
        }
    }
}
