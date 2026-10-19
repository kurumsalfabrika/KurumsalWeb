using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IAcilirMesajService
    {
        Task<List<AcilirMesaj>> GetAllAsync();
        Task<AcilirMesaj> GetByIdAsync(int acilirmesajId);
        Task<AcilirMesaj> GetByNameAsync(string acilirmesajName);
        Task AddAsync(AcilirMesaj acilirmesaj);
        Task UpdateAsync(AcilirMesaj acilirmesaj);
        Task DeleteAsync(int acilirmesajId);
    }
}
