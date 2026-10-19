using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IMenuService
    {
        Task<List<Menu>> GetAllAsync();
        Task<Menu> GetByIdAsync(int menuId);
        Task<Menu> GetByNameAsync(string menuName);
        Task AddAsync(Menu menu);
        Task UpdateAsync(Menu menu);
        Task DeleteAsync(int menuId);
    }
}
