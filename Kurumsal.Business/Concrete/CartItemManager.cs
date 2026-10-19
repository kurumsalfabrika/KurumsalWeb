using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class CartItemManager : ICartItemService
    {
        private readonly ICartItemDal _cartItemDal;

        public CartItemManager(ICartItemDal cartItemDal)
        {
            _cartItemDal = cartItemDal;
        }

        public async Task AddAsync(CartItem cartItem)
        {
            await _cartItemDal.AddAsync(cartItem);
        }

        public async Task DeleteAsync(int cartItemId)
        {
            await _cartItemDal.DeleteAsync(new CartItem { Id = cartItemId });
        }

        public async Task<List<CartItem>> GetAllAsync(Func<IQueryable<CartItem>, IIncludableQueryable<CartItem, object>> include = null)
        {
            return await _cartItemDal.GetListAsync(null, include);
        }

        public async Task<CartItem> GetByAsync(Func<IQueryable<CartItem>, IIncludableQueryable<CartItem, object>> include = null)
        {
            return await _cartItemDal.GetAsync(null, include);
        }

        public async Task<CartItem> GetByIdAsync(int cartItemId)
        {
            return await _cartItemDal.GetAsync(x => x.Id == cartItemId);
        }

        public async Task<CartItem> GetByNameAsync(string cartItemName)
        {
            return await _cartItemDal.GetAsync();
        }

        public async Task UpdateAsync(CartItem cartItem)
        {
            await _cartItemDal.UpdateAsync(cartItem);
        }
    }
}
