using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IFirmaService
    {
        Task<List<Firma>> GetAllAsync(Func<IQueryable<Firma>, IIncludableQueryable<Firma, object>> include = null);
        Task<Firma> GetByIdAsync(int haberId);
        Task<Firma> GetByAsync(Func<IQueryable<Firma>, IIncludableQueryable<Firma, object>> include = null);
        Task<Firma> GetByNameAsync(string haberName);
        Task AddAsync(Firma haber);
        Task UpdateAsync(Firma haber);
        Task DeleteAsync(int haberId);
    }
}
