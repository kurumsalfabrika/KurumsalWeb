using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ICartService
    {
        Task<List<Cart>> GetAllAsync(Func<IQueryable<Cart>, IIncludableQueryable<Cart, object>> include = null);
        Task<Cart> GetByIdAsync(int cartId);
        Task<Cart> GetByAsync(Func<IQueryable<Cart>, IIncludableQueryable<Cart, object>> include = null);
        Task<Cart> GetByNameAsync(string cartName);
        Task AddAsync(Cart cart);
        Task UpdateAsync(Cart cart);
        Task DeleteAsync(int cartId);
    }
}
