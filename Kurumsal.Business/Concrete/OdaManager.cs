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
    public class OdaManager : IOdaService
    {
        private readonly IOdaDal _odaDal;

        public OdaManager(IOdaDal odaDal)
        {
            _odaDal = odaDal;
        }

        public async Task AddAsync(Oda oda)
        {
            await _odaDal.AddAsync(oda);
        }

        public async Task DeleteAsync(int odaId)
        {
            await _odaDal.DeleteAsync(new Oda { Id = odaId });
        }

        public async Task<List<Oda>> GetAllAsync(Expression<Func<Oda, bool>> filter = null,Func<IQueryable<Oda>, IIncludableQueryable<Oda, object>> include = null)
        {
            return await _odaDal.GetListAsync(filter, include);
        }

        public async Task<Oda> GetByIdAsync(int odaId)
        {
            return await _odaDal.GetAsync(x => x.Id == odaId);
        }

        public async Task<Oda> GetByNameAsync(string odaName)
        {
            return await _odaDal.GetAsync(x => x.OdaAdi == odaName);
        }

        public async Task UpdateAsync(Oda oda)
        {
            await _odaDal.UpdateAsync(oda);
        }
    }
}
