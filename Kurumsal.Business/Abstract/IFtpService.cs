using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IFtpService
    {
        Task<List<Ftp>> GetAllAsync();
        Task<Ftp> GetByIdAsync(int ftpId);
        Task<Ftp> GetByNameAsync(string ftpName);
        Task AddAsync(Ftp ftp);
        Task UpdateAsync(Ftp ftp);
        Task DeleteAsync(int ftpId);
    }
}
