using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISosyalMedyaAdresService
    {
        Task<List<SosyalMedyaAdres>> GetAllAsync();
        Task<SosyalMedyaAdres> GetByIdAsync(int sosyalMedyaAdresId);
        Task<SosyalMedyaAdres> GetByNameAsync(string sosyalMedyaAdresName);
        Task AddAsync(SosyalMedyaAdres sosyalMedyaAdres);
        Task UpdateAsync(SosyalMedyaAdres sosyalMedyaAdres);
        Task DeleteAsync(int sosyalMedyaAdresId);
    }
}
