using Kurumsal.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Kurumsal.Infrastructure.Repositories.Base
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public EfRepositoryBase(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter = null!,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
                query = include(query);
            if (filter != null)
                query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
                query = include(query);
            if (filter != null)
                query = query.Where(filter);
            return await query.ToListAsync();
        }

        public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);
        public void Add(TEntity entity) => _dbSet.Add(entity);
        public async Task<TEntity> ReturnAddAsync(TEntity entity)
        {
            var entry = await _dbSet.AddAsync(entity);
            return entry.Entity;
        }

        public TEntity ReturnAdd(TEntity entity) => _dbSet.Add(entity).Entity;
        public Task UpdateAsync(TEntity entity) { _dbSet.Update(entity); return Task.CompletedTask; }
        public Task DeleteAsync(TEntity entity) { _dbSet.Remove(entity); return Task.CompletedTask; }
        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();
    }
}
