using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISSSService
    {
        Task<List<SSS>> GetAllAsync(Func<IQueryable<SSS>, IIncludableQueryable<SSS, object>> include = null);
        Task<SSS> GetByIdAsync(int sssId);
        Task<SSS> GetByNameAsync(string sssName);
        Task AddAsync(SSS sss);
        Task UpdateAsync(SSS sss);
        Task DeleteAsync(int sssId);
    }
}
