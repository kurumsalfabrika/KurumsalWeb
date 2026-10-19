using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
	public interface IFotoGaleriService
	{
		Task<List<FotoGaleri>> GetAllAsync(Expression<Func<FotoGaleri, bool>> filter = null, Func<IQueryable<FotoGaleri>, IIncludableQueryable<FotoGaleri, object>> include = null);
		Task<FotoGaleri> GetByIdAsync(int fotoGaleriId);
		Task<FotoGaleri> GetByAsync(Expression<Func<FotoGaleri, bool>> filter = null, Func<IQueryable<FotoGaleri>, IIncludableQueryable<FotoGaleri, object>> include = null);
		Task<FotoGaleri> GetByNameAsync(string fotoGaleriName);
		Task AddAsync(FotoGaleri fotoGaleri);
		Task UpdateAsync(FotoGaleri fotoGaleri);
		Task DeleteAsync(int fotoGaleriId);
	}
}
