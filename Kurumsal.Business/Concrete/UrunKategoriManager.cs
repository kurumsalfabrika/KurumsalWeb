using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.DataAccess.Concrete.EntityFramework;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class UrunKategoriManager : IUrunKategoriService
    {
        private readonly IUrunKategoriDal _urunKategoriDal;

        public UrunKategoriManager(IUrunKategoriDal urunkategoriDal)
        {
            _urunKategoriDal = urunkategoriDal;
        }

        public async Task AddAsync(UrunKategori urunKategori)
        {
            await _urunKategoriDal.AddAsync(urunKategori);
        }

        public async Task DeleteAsync(int urunKategoriId)
        {
            await _urunKategoriDal.DeleteAsync(new UrunKategori { Id = urunKategoriId });
        }

        public async Task<List<UrunKategori>> GetAllAsync(Expression<Func<UrunKategori, bool>> filter = null, Func<IQueryable<UrunKategori>, IIncludableQueryable<UrunKategori, object>> include = null)
        {
            return await _urunKategoriDal.GetListAsync(filter, include);
        }

        public async Task<UrunKategori> GetByAsync(Expression<Func<UrunKategori, bool>> filter = null, Func<IQueryable<UrunKategori>, IIncludableQueryable<UrunKategori, object>> include = null)
        {
            return await _urunKategoriDal.GetAsync(filter, include);
        }

        public async Task<UrunKategori> GetByIdAsync(int urunKategoriId)
        {
            return await _urunKategoriDal.GetAsync(x => x.Id == urunKategoriId);
        }

        public async Task<UrunKategori> GetByNameAsync(string urunKategoriName)
        {
            return await _urunKategoriDal.GetAsync(x => x.KategoriAdi == urunKategoriName);
        }

        public async Task UpdateAsync(UrunKategori urunKategori)
        {
            await _urunKategoriDal.UpdateAsync(urunKategori);
        }
    }
}
