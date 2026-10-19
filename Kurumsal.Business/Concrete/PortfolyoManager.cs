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
    public class PortfolyoManager : IPortfolyoService
    {
        private readonly IPortfolyoDal _portfolyoDal;

        public PortfolyoManager(IPortfolyoDal portfolyoDal)
        {
            _portfolyoDal = portfolyoDal;
        }

        public async Task AddAsync(Portfolyo portfolyo)
        {
            await _portfolyoDal.AddAsync(portfolyo);
        }

        public async Task DeleteAsync(int portfolyoId)
        {
            await _portfolyoDal.DeleteAsync(new Portfolyo { Id = portfolyoId });
        }

        public async Task<List<Portfolyo>> GetAllAsync(Func<IQueryable<Portfolyo>, IIncludableQueryable<Portfolyo, object>> include = null)
        {
            return await _portfolyoDal.GetListAsync(null, include);
        }

        public async Task<Portfolyo> GetByIdAsync(int portfolyoId)
        {
            return await _portfolyoDal.GetAsync(x => x.Id == portfolyoId);
        }

        public async Task<Portfolyo> GetByNameAsync(string portfolyoName)
        {
            return await _portfolyoDal.GetAsync(x => x.Baslik == portfolyoName);
        }

        public async Task UpdateAsync(Portfolyo portfolyo)
        {
            await _portfolyoDal.UpdateAsync(portfolyo);
        }
    }
}
