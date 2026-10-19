using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IBelgeService
    {
        Task<List<Belge>> GetAllAsync();
        Task<Belge> GetByIdAsync(int belgeId);
        Task<Belge> GetByNameAsync(string belgeName);
        Task AddAsync(Belge belge);
        Task UpdateAsync(Belge belge);
        Task DeleteAsync(int belgeId);
    }
}
