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
    public class SayfaManager : ISayfaService
    {
        private readonly ISayfaDal _sayfaDal;

        public SayfaManager(ISayfaDal sayfaDal)
        {
            _sayfaDal = sayfaDal;
        }

        public async Task AddAsync(Sayfa sayfa)
        {
            await _sayfaDal.AddAsync(sayfa);
        }

        public async Task DeleteAsync(int sayfaId)
        {
            await _sayfaDal.DeleteAsync(new Sayfa { Id = sayfaId });
        }

        public async Task<List<Sayfa>> GetAllAsync(Expression<Func<Sayfa, bool>> filter = null, Func<IQueryable<Sayfa>, IIncludableQueryable<Sayfa, object>> include = null)
        {
            return await _sayfaDal.GetListAsync(filter, include);
        }

        public async Task<Sayfa> GetByAsync(Expression<Func<Sayfa, bool>> filter = null, Func<IQueryable<Sayfa>, IIncludableQueryable<Sayfa, object>> include = null)
        {
            return await _sayfaDal.GetAsync(filter, include);
        }

        public async Task<Sayfa> GetByIdAsync(int sayfaId)
        {
            return await _sayfaDal.GetAsync(x => x.Id == sayfaId);
        }

        public async Task<Sayfa> GetByNameAsync(string sayfaName)
        {
            return await _sayfaDal.GetAsync(x => x.Baslik == sayfaName);
        }

        public async Task UpdateAsync(Sayfa sayfa)
        {
            await _sayfaDal.UpdateAsync(sayfa);
        }
    }
}
