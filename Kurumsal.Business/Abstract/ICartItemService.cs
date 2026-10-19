using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ICartItemService
    {
        Task<List<CartItem>> GetAllAsync(Func<IQueryable<CartItem>, IIncludableQueryable<CartItem, object>> include = null);
        Task<CartItem> GetByIdAsync(int cartItemId);
        Task<CartItem> GetByAsync(Func<IQueryable<CartItem>, IIncludableQueryable<CartItem, object>> include = null);
        Task<CartItem> GetByNameAsync(string cartItemName);
        Task AddAsync(CartItem cartItem);
        Task UpdateAsync(CartItem cartItem);
        Task DeleteAsync(int cartItemId);
    }
}
