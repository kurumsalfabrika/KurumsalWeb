using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISosyalMedyaAyarService
    {
        Task<List<SosyalMedyaAyar>> GetAllAsync();
        Task<SosyalMedyaAyar> GetByIdAsync(int sosyalmedyaayarId);
        Task<SosyalMedyaAyar> GetByNameAsync(string sosyalmedyaayarName);
        Task AddAsync(SosyalMedyaAyar sosyalmedyaayar);
        Task UpdateAsync(SosyalMedyaAyar sosyalmedyaayar);
        Task DeleteAsync(int sosyalmedyaayarId);
    }
}
