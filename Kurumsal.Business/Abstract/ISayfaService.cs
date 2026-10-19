using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISayfaService
    {
        Task<List<Sayfa>> GetAllAsync(Expression<Func<Sayfa, bool>> filter = null, Func<IQueryable<Sayfa>, IIncludableQueryable<Sayfa, object>> include = null);
        Task<Sayfa> GetByIdAsync(int sayfaId);
        Task<Sayfa> GetByNameAsync(string sayfaName);
        Task<Sayfa> GetByAsync(Expression<Func<Sayfa, bool>> filter = null, Func<IQueryable<Sayfa>, IIncludableQueryable<Sayfa, object>> include = null);
        Task AddAsync(Sayfa sayfa);
        Task UpdateAsync(Sayfa sayfa);
        Task DeleteAsync(int sayfaId);
    }
}
