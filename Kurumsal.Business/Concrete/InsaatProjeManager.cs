using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class InsaatProjeManager : IInsaatProjeService
    {
        private readonly IInsaatProjeDal _insaatProjeDal;

        public InsaatProjeManager(IInsaatProjeDal insaatProjeDal)
        {
            _insaatProjeDal = insaatProjeDal;
        }

        public async Task AddAsync(InsaatProje insaatProje)
        {
            await _insaatProjeDal.AddAsync(insaatProje);
        }

        public void Add(InsaatProje insaatProje)
        {
            _insaatProjeDal.Add(insaatProje);
        }

        public async Task DeleteAsync(int insaatProjeId)
        {
            await _insaatProjeDal.DeleteAsync(new InsaatProje { Id = insaatProjeId });
        }

        public async Task<List<InsaatProje>> GetAllAsync(Expression<Func<InsaatProje, bool>> filter = null, Func<IQueryable<InsaatProje>, IIncludableQueryable<InsaatProje, object>> include = null)
        {
            return await _insaatProjeDal.GetListAsync(filter, include);
        }
        
        public async Task<InsaatProje> GetAsync(Expression<Func<InsaatProje, bool>> filter = null, Func<IQueryable<InsaatProje>, IIncludableQueryable<InsaatProje, object>> include = null)
        {
            return await _insaatProjeDal.GetAsync(filter, include);
        }

        public async Task<InsaatProje> GetByIdAsync(int insaatProjeId)
        {
            return await _insaatProjeDal.GetAsync(x => x.Id == insaatProjeId);
        }

        public async Task<InsaatProje> GetByNameAsync(string insaatProjeName)
        {
            return await _insaatProjeDal.GetAsync(x => x.ProjeAdi == insaatProjeName);
        }

        public Task<InsaatProje> ReturnAddAsync(InsaatProje insaatProje)
        {
            return  _insaatProjeDal.ReturnAddAsync(insaatProje);
        }

        public InsaatProje ReturnAdd(InsaatProje insaatProje)
        {
            return  _insaatProjeDal.ReturnAdd(insaatProje);
        }

        public async Task UpdateAsync(InsaatProje insaatProje)
        {
            await _insaatProjeDal.UpdateAsync(insaatProje);
        }
    }
}
