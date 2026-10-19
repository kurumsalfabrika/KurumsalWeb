using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IUrunService
    {
        Task<List<Urun>> GetAllAsync(Expression<Func<Urun, bool>> filter = null, Func<IQueryable<Urun>, IIncludableQueryable<Urun, object>> include = null);
        Task<Urun> GetByIdAsync(int urunId);
        Task<Urun> GetByAsync(Expression<Func<Urun, bool>> filter = null, Func<IQueryable<Urun>, IIncludableQueryable<Urun, object>> include = null);
        Task<Urun> GetByNameAsync(string urunName);
        Task AddAsync(Urun urun);
        Task UpdateAsync(Urun urun);
        Task DeleteAsync(int urunId);
    }
}
