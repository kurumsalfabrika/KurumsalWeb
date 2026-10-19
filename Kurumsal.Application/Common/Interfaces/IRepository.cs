using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Kurumsal.Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> filter = null!,
                          Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

        Task<List<T>> GetListAsync(Expression<Func<T, bool>>? filter = null,
                                   Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

        Task<T> ReturnAddAsync(T entity);
        T ReturnAdd(T entity);
        Task AddAsync(T entity);
        void Add(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> SaveChangesAsync();
    }
}
