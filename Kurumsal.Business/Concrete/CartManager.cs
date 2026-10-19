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
    public class CartManager : ICartService
    {
        private readonly ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public async Task AddAsync(Cart cart)
        {
            await _cartDal.AddAsync(cart);
        }

        public async Task DeleteAsync(int cartId)
        {
            await _cartDal.DeleteAsync(new Cart { Id = cartId });
        }

        public async Task<List<Cart>> GetAllAsync(Func<IQueryable<Cart>, IIncludableQueryable<Cart, object>> include = null)
        {
            return await _cartDal.GetListAsync(null, include);
        }

        public async Task<Cart> GetByAsync(Func<IQueryable<Cart>, IIncludableQueryable<Cart, object>> include = null)
        {
            return await _cartDal.GetAsync(null, include);
        }

        public async Task<Cart> GetByIdAsync(int cartId)
        {
            return await _cartDal.GetAsync(x => x.Id == cartId);
        }

        public async Task<Cart> GetByNameAsync(string cartName)
        {
            return await _cartDal.GetAsync();
        }

        public async Task UpdateAsync(Cart cart)
        {
            await _cartDal.UpdateAsync(cart);
        }
    }
}
