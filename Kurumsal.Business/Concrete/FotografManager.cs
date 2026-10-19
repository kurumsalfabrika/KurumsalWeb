using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
	public class FotografManager : IFotografService
	{
		private readonly IFotografDal _fotografDal;

		public FotografManager(IFotografDal fotografDal)
		{
			_fotografDal = fotografDal;
		}

		public async Task AddAsync(Fotograf fotograf)
		{
			await _fotografDal.AddAsync(fotograf);
		}

		public async Task DeleteAsync(int fotografId)
		{
			await _fotografDal.DeleteAsync(new Fotograf { Id = fotografId });
		}

		public async Task<List<Fotograf>> GetAllAsync(Expression<Func<Fotograf, bool>> filter = null, Func<IQueryable<Fotograf>, IIncludableQueryable<Fotograf, object>> include = null)
		{
			return await _fotografDal.GetListAsync(filter, include);
		}

		public async Task<Fotograf> GetByAsync(Expression<Func<Fotograf, bool>> filter = null, Func<IQueryable<Fotograf>, IIncludableQueryable<Fotograf, object>> include = null)
		{
			return await _fotografDal.GetAsync(filter, include);
		}

		public async Task<Fotograf> GetByIdAsync(int fotografId)
		{
			return await _fotografDal.GetAsync(x => x.Id == fotografId);
		}

		public async Task<Fotograf> GetByNameAsync(string fotografName)
		{
			return await _fotografDal.GetAsync(x => x.SEOUrl == fotografName);
		}

		public async Task UpdateAsync(Fotograf fotograf)
		{
			await _fotografDal.UpdateAsync(fotograf);
		}
	}
}
