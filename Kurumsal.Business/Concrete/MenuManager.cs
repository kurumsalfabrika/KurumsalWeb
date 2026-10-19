using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class MenuManager : IMenuService
    {
        private readonly IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public async Task AddAsync(Menu menu)
        {
            await _menuDal.AddAsync(menu);
        }

        public async Task DeleteAsync(int menuId)
        {
            await _menuDal.DeleteAsync(new Menu { Id = menuId });
        }

        public async Task<List<Menu>> GetAllAsync()
        {
            return await _menuDal.GetListAsync();
        }

        public async Task<Menu> GetByIdAsync(int menuId)
        {
            return await _menuDal.GetAsync(x => x.Id == menuId);
        }

        public async Task<Menu> GetByNameAsync(string menuName)
        {
            return await _menuDal.GetAsync(x => x.MenuAdi == menuName);
        }

        public async Task UpdateAsync(Menu menu)
        {
            await _menuDal.UpdateAsync(menu);
        }
    }
}
