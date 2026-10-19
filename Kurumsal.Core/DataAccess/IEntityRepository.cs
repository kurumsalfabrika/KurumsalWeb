using Kurumsal.Core.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task AddAsync(T entity);
        void Add(T entity);
        Task<T> ReturnAddAsync(T entity);
        T ReturnAdd(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
