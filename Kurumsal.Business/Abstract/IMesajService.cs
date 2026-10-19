using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IMesajService
    {
        Task<List<Mesaj>> GetAllAsync();
        Task<Mesaj> GetByIdAsync(int mesajId);
        Task<Mesaj> GetByNameAsync(string mesajName);
        Task AddAsync(Mesaj mesaj);
        Task UpdateAsync(Mesaj mesaj);
        Task DeleteAsync(int mesajId);
    }
}
