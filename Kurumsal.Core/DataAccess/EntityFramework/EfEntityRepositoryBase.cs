using Kurumsal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Added;
                        await context.SaveChangesAsync();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Entry(entity).State = EntityState.Added;
                         context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        public async Task<TEntity> ReturnAddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                await context.SaveChangesAsync();
                return entry.Entity;
            }
        }

        public TEntity ReturnAdd(TEntity entity)
        {
            using (var context = new TContext())
            {
                var entry = context.Entry(entity);
                entry.State = EntityState.Added;
                context.SaveChanges();
                return entry.Entity;
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }




        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            using (var context = new TContext())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();
                if (include != null)
                {
                    query = include(query);
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                return await query.SingleOrDefaultAsync();
            }
        }


        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            using (var context = new TContext())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();

                if (include != null)
                {
                    query = include(query);
                }
                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return await query.ToListAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
