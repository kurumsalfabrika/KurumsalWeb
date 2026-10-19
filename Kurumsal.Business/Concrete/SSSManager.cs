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
    public class SSSManager : ISSSService
    {
        private readonly ISSSDal _sSSDal;

        public SSSManager(ISSSDal sSSDal)
        {
            _sSSDal = sSSDal;
        }

        public async Task AddAsync(SSS sSS)
        {
            await _sSSDal.AddAsync(sSS);
        }

        public async Task DeleteAsync(int sSSId)
        {
            await _sSSDal.DeleteAsync(new SSS { Id = sSSId });
        }

        public async Task<List<SSS>> GetAllAsync(Func<IQueryable<SSS>, IIncludableQueryable<SSS, object>> include = null)
        {
            return await _sSSDal.GetListAsync(null, include);
        }

        public async Task<SSS> GetByIdAsync(int sSSId)
        {
            return await _sSSDal.GetAsync(x => x.Id == sSSId);
        }

        public async Task<SSS> GetByNameAsync(string sSSName)
        {
            return await _sSSDal.GetAsync(x => x.SoruAdi == sSSName);
        }

        public async Task UpdateAsync(SSS sSS)
        {
            await _sSSDal.UpdateAsync(sSS);
        }
    }
}
