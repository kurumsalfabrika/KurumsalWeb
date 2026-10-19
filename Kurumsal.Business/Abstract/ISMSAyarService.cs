using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISMSAyarService
    {
        Task<List<SMSAyar>> GetAllAsync();
        Task<SMSAyar> GetByIdAsync(int smsayarId);
        Task<SMSAyar> GetByNameAsync(string smsayarName);
        Task AddAsync(SMSAyar smsayar);
        Task UpdateAsync(SMSAyar smsayar);
        Task DeleteAsync(int smsayarId);
    }
}
