using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IFotografService
    {
		Task<List<Fotograf>> GetAllAsync(Expression<Func<Fotograf, bool>> filter = null, Func<IQueryable<Fotograf>, IIncludableQueryable<Fotograf, object>> include = null);
		Task<Fotograf> GetByIdAsync(int fotografId);
		Task<Fotograf> GetByAsync(Expression<Func<Fotograf, bool>> filter = null, Func<IQueryable<Fotograf>, IIncludableQueryable<Fotograf, object>> include = null);
		Task<Fotograf> GetByNameAsync(string fotografName);
		Task AddAsync(Fotograf fotograf);
		Task UpdateAsync(Fotograf fotograf);
		Task DeleteAsync(int fotografId);
	}
}
