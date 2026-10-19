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
	public class FotoGaleriManager : IFotoGaleriService
	{
		private readonly IFotoGaleriDal _fotoGaleriDal;

		public FotoGaleriManager(IFotoGaleriDal fotoGaleriDal)
		{
			_fotoGaleriDal = fotoGaleriDal;
		}

		public async Task AddAsync(FotoGaleri fotoGaleri)
		{
			await _fotoGaleriDal.AddAsync(fotoGaleri);
		}

		public async Task DeleteAsync(int fotoGaleriId)
		{
			await _fotoGaleriDal.DeleteAsync(new FotoGaleri { Id = fotoGaleriId });
		}

		public async Task<List<FotoGaleri>> GetAllAsync(Expression<Func<FotoGaleri, bool>> filter = null, Func<IQueryable<FotoGaleri>, IIncludableQueryable<FotoGaleri, object>> include = null)
		{
			return await _fotoGaleriDal.GetListAsync(filter, include);
		}

		public async Task<FotoGaleri> GetByAsync(Expression<Func<FotoGaleri, bool>> filter = null, Func<IQueryable<FotoGaleri>, IIncludableQueryable<FotoGaleri, object>> include = null)
		{
			return await _fotoGaleriDal.GetAsync(filter, include);
		}

		public async Task<FotoGaleri> GetByIdAsync(int fotoGaleriId)
		{
			return await _fotoGaleriDal.GetAsync(x => x.Id == fotoGaleriId);
		}

		public async Task<FotoGaleri> GetByNameAsync(string fotoGaleriName)
		{
			return await _fotoGaleriDal.GetAsync(x => x.SEOUrl == fotoGaleriName);
		}

		public async Task UpdateAsync(FotoGaleri fotoGaleri)
		{
			await _fotoGaleriDal.UpdateAsync(fotoGaleri);
		}
	}
}
