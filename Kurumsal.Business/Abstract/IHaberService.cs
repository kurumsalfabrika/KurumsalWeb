using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IHaberService
    {
        Task<List<Haber>> GetAllAsync(Func<IQueryable<Haber>, IIncludableQueryable<Haber, object>> include = null);
        Task<Haber> GetByIdAsync(int haberId);
        Task<Haber> GetByAsync(Func<IQueryable<Haber>, IIncludableQueryable<Haber, object>> include = null);
        Task<Haber> GetByNameAsync(string haberName);
        Task AddAsync(Haber haber);
        Task UpdateAsync(Haber haber);
        Task DeleteAsync(int haberId);
    }
}
