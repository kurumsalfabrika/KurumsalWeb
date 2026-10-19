using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IIletisimAyarService
    {

        Task<IletisimAyar> GetByAsync(Expression<Func<IletisimAyar, bool>> filter = null, Func<IQueryable<IletisimAyar>, IIncludableQueryable<IletisimAyar, object>> include = null);
        Task<List<IletisimAyar>> GetListAsync(Expression<Func<IletisimAyar, bool>> filter = null, Func<IQueryable<IletisimAyar>, IIncludableQueryable<IletisimAyar, object>> include = null);
        Task<IletisimAyar> GetByIdAsync(int iletisimayarId);
        Task<IletisimAyar> GetByNameAsync(string iletisimayarName);
        Task AddAsync(IletisimAyar iletisimayar);
        Task UpdateAsync(IletisimAyar iletisimayar);
        Task DeleteAsync(int iletisimayarId);
    }
}
