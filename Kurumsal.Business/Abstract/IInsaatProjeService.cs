using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IInsaatProjeService
    {
        Task<List<InsaatProje>> GetAllAsync(Expression<Func<InsaatProje, bool>> filter = null, Func<IQueryable<InsaatProje>, IIncludableQueryable<InsaatProje, object>> include = null);
        Task<InsaatProje> GetAsync(Expression<Func<InsaatProje, bool>> filter = null, Func<IQueryable<InsaatProje>, IIncludableQueryable<InsaatProje, object>> include = null);
        Task<InsaatProje> GetByIdAsync(int insaatProjeId);
        Task<InsaatProje> GetByNameAsync(string insaatProjeName);
        Task AddAsync(InsaatProje insaatProje);
        void Add(InsaatProje insaatProje);
        Task<InsaatProje> ReturnAddAsync(InsaatProje insaatProje);
        InsaatProje ReturnAdd(InsaatProje insaatProje);
        Task UpdateAsync(InsaatProje insaatProje);
        Task DeleteAsync(int insaatProjeId);
    }
}
