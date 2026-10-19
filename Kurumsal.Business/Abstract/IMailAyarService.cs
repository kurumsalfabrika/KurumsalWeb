using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IMailAyarService
    {
        Task<List<MailAyar>> GetAllAsync();
        Task<MailAyar> GetByIdAsync(int mailayarId);
        Task<MailAyar> GetByNameAsync(string mailayarName);
        Task AddAsync(MailAyar mailayar);
        Task UpdateAsync(MailAyar mailayar);
        Task DeleteAsync(int mailayarId);
    }
}
