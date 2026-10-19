using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
	public class TeklifManager : ITeklifService
	{
        private readonly ITeklifDal _teklifDal;

        public TeklifManager(ITeklifDal teklifDal)
        {
            _teklifDal = teklifDal;
        }

        public async Task AddAsync(Teklif teklif)
        {
            await _teklifDal.AddAsync(teklif);
        }

        public async Task DeleteAsync(int teklifId)
        {
            await _teklifDal.DeleteAsync(new Teklif { Id = teklifId });
        }

        public async Task<List<Teklif>> GetAllAsync(Func<IQueryable<Teklif>, IIncludableQueryable<Teklif, object>> include = null)
        {
            return await _teklifDal.GetListAsync(null, include);
        }

        public async Task<Teklif> GetByAsync(Func<IQueryable<Teklif>, IIncludableQueryable<Teklif, object>> include = null)
        {
            return await _teklifDal.GetAsync(null, include);
        }

        public async Task<Teklif> GetByIdAsync(int teklifId)
        {
            return await _teklifDal.GetAsync(x => x.Id == teklifId);
        }

        public async Task<Teklif> GetByNameAsync(string teklifName)
        {
            return await _teklifDal.GetAsync(x => x.AdSoyad == teklifName);
        }

        public async Task UpdateAsync(Teklif teklif)
        {
            await _teklifDal.UpdateAsync(teklif);
        }
    }
}
