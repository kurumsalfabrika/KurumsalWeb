using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
	public interface ITeklifService
    {
        Task<List<Teklif>> GetAllAsync(Func<IQueryable<Teklif>, IIncludableQueryable<Teklif, object>> include = null);
        Task<Teklif> GetByIdAsync(int teklifId);
        Task<Teklif> GetByAsync(Func<IQueryable<Teklif>, IIncludableQueryable<Teklif, object>> include = null);
        Task<Teklif> GetByNameAsync(string teklifName);
        Task AddAsync(Teklif teklif);
        Task UpdateAsync(Teklif teklif);
        Task DeleteAsync(int teklifId);
    }
}
