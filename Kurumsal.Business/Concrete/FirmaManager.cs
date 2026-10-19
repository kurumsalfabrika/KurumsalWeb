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
    public class FirmaManager : IFirmaService
    {
        private readonly IFirmaDal _firmaDal;

        public FirmaManager(IFirmaDal firmaDal)
        {
            _firmaDal = firmaDal;
        }

        public async Task AddAsync(Firma firma)
        {
            await _firmaDal.AddAsync(firma);
        }

        public async Task DeleteAsync(int firmaId)
        {
            await _firmaDal.DeleteAsync(new Firma { Id = firmaId });
        }

        public async Task<List<Firma>> GetAllAsync(Func<IQueryable<Firma>, IIncludableQueryable<Firma, object>> include = null)
        {
            return await _firmaDal.GetListAsync(null, include);
        }

        public async Task<Firma> GetByAsync(Func<IQueryable<Firma>, IIncludableQueryable<Firma, object>> include = null)
        {
            return await _firmaDal.GetAsync(null, include);
        }

        public async Task<Firma> GetByIdAsync(int firmaId)
        {
            return await _firmaDal.GetAsync(x => x.Id == firmaId);
        }

        public async Task<Firma> GetByNameAsync(string firmaName)
        {
            return await _firmaDal.GetAsync();
        }

        public async Task UpdateAsync(Firma firma)
        {
            await _firmaDal.UpdateAsync(firma);
        }
    }
}
