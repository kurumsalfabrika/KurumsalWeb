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
    public class IletisimAyarManager : IIletisimAyarService
    {
        private readonly IIletisimAyarDal _iletisimAyarDal;

        public IletisimAyarManager(IIletisimAyarDal iletisimAyarDal)
        {
            _iletisimAyarDal = iletisimAyarDal;
        }

        public async Task AddAsync(IletisimAyar iletisimAyar)
        {
            await _iletisimAyarDal.AddAsync(iletisimAyar);
        }

        public async Task DeleteAsync(int iletisimAyarId)
        {
            await _iletisimAyarDal.DeleteAsync(new IletisimAyar { Id = iletisimAyarId });
        }

        public async Task<List<IletisimAyar>> GetAllAsync()
        {
            return await _iletisimAyarDal.GetListAsync();
        }


        public async Task<IletisimAyar> GetByAsync(Expression<Func<IletisimAyar, bool>> filter = null, Func<IQueryable<IletisimAyar>, IIncludableQueryable<IletisimAyar, object>> include = null)
        {
            return await _iletisimAyarDal.GetAsync(filter, include);
        }

        public async Task<IletisimAyar> GetByIdAsync(int iletisimAyarId)
        {
            return await _iletisimAyarDal.GetAsync(x => x.Id == iletisimAyarId);
        }

        public async Task<IletisimAyar> GetByNameAsync(string iletisimAyarName)
        {
            return await _iletisimAyarDal.GetAsync(x => x.IletisimEposta == iletisimAyarName);
        }

        public async Task<List<IletisimAyar>> GetListAsync(Expression<Func<IletisimAyar, bool>> filter = null, Func<IQueryable<IletisimAyar>, IIncludableQueryable<IletisimAyar, object>> include = null)
        {
            return await _iletisimAyarDal.GetListAsync(filter, include);
        }

        public async Task UpdateAsync(IletisimAyar iletisimAyar)
        {
            await _iletisimAyarDal.UpdateAsync(iletisimAyar);
        }
    }
}
