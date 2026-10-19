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
    public class OdaKategoriManager : IOdaKategoriService
    {
        private readonly IOdaKategoriDal _odaKategoriDal;

        public OdaKategoriManager(IOdaKategoriDal odaKategoriDal)
        {
            _odaKategoriDal = odaKategoriDal;
        }

        public async Task AddAsync(OdaKategori odaKategori)
        {
            await _odaKategoriDal.AddAsync(odaKategori);
        }

        public async Task DeleteAsync(int odaKategoriId)
        {
            await _odaKategoriDal.DeleteAsync(new OdaKategori { Id = odaKategoriId });
        }

        public async Task<List<OdaKategori>> GetAllAsync(Expression<Func<OdaKategori, bool>> filter = null, Func<IQueryable<OdaKategori>, IIncludableQueryable<OdaKategori, object>> include = null)
        {
            return await _odaKategoriDal.GetListAsync(filter, include);
        }

        public async Task<OdaKategori> GetByIdAsync(int odaKategoriId)
        {
            return await _odaKategoriDal.GetAsync(x => x.Id == odaKategoriId);
        }

        public async Task<OdaKategori> GetByNameAsync(string odaKategoriName)
        {
            return await _odaKategoriDal.GetAsync(x => x.KategoriAdi == odaKategoriName);
        }

        public async Task UpdateAsync(OdaKategori odaKategori)
        {
            await _odaKategoriDal.UpdateAsync(odaKategori);
        }
    }
}
