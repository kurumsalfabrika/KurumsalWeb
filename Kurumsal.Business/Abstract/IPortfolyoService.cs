using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IPortfolyoService
    {
        Task<List<Portfolyo>> GetAllAsync(Func<IQueryable<Portfolyo>, IIncludableQueryable<Portfolyo, object>> include = null);
        Task<Portfolyo> GetByIdAsync(int portfolyoId);
        Task<Portfolyo> GetByNameAsync(string portfolyoName);
        Task AddAsync(Portfolyo portfolyo);
        Task UpdateAsync(Portfolyo portfolyo);
        Task DeleteAsync(int portfolyoId);
    }
}
