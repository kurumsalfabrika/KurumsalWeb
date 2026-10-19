using Kurumsal.Core.Entities;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IOdaService
    {
        Task<List<Oda>> GetAllAsync(Expression<Func<Oda, bool>> filter = null,Func<IQueryable<Oda>, IIncludableQueryable<Oda, object>> include = null);
        Task<Oda> GetByIdAsync(int odaId);
        Task<Oda> GetByNameAsync(string odaName);
        Task AddAsync(Oda oda);
        Task UpdateAsync(Oda oda);
        Task DeleteAsync(int odaId);
    }
}
