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
    public class UrunManager : IUrunService
    {
        private readonly IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public async Task AddAsync(Urun urun)
        {
            await _urunDal.AddAsync(urun);
        }

        public async Task DeleteAsync(int urunId)
        {
            await _urunDal.DeleteAsync(new Urun { Id = urunId });
        }

        public async Task<List<Urun>> GetAllAsync(Expression<Func<Urun, bool>> filter = null, Func<IQueryable<Urun>, IIncludableQueryable<Urun, object>> include = null)
        {
            return await _urunDal.GetListAsync(filter, include);
        }

        public async Task<Urun> GetByAsync(Expression<Func<Urun, bool>> filter = null, Func<IQueryable<Urun>, IIncludableQueryable<Urun, object>> include = null)
        {
            return await _urunDal.GetAsync(filter, include);
        }

        public async Task<Urun> GetByIdAsync(int urunId)
        {
            return await _urunDal.GetAsync(x => x.Id == urunId);
        }

        public async Task<Urun> GetByNameAsync(string urunName)
        {
            return await _urunDal.GetAsync(x => x.UrunKodu == urunName);
        }

        public async Task UpdateAsync(Urun urun)
        {
            await _urunDal.UpdateAsync(urun);
        }
    }
}
