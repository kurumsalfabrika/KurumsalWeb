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
    public class MarkaManager : IMarkaService
    {
        private readonly IMarkaDal _markaDal;

        public MarkaManager(IMarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        public async Task AddAsync(Marka marka)
        {
            await _markaDal.AddAsync(marka);
        }

        public async Task DeleteAsync(int markaId)
        {
            await _markaDal.DeleteAsync(new Marka { Id = markaId });
        }

        public async Task<List<Marka>> GetAllAsync(Func<IQueryable<Marka>, IIncludableQueryable<Marka, object>> include = null)
        {
            return await _markaDal.GetListAsync(null, include);
        }

        public async Task<Marka> GetByAsync(Func<IQueryable<Marka>, IIncludableQueryable<Marka, object>> include = null)
        {
            return await _markaDal.GetAsync(null, include);
        }

        public async Task<Marka> GetByIdAsync(int markaId)
        {
            return await _markaDal.GetAsync(x => x.Id == markaId);
        }

        public async Task<Marka> GetByNameAsync(string markaName)
        {
            return await _markaDal.GetAsync(x => x.MarkaAdi == markaName);
        }

        public async Task UpdateAsync(Marka marka)
        {
            await _markaDal.UpdateAsync(marka);
        }
    }
}
