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

    public class RezervasyonManager : IRezervasyonService
    {
        private readonly IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public async Task AddAsync(Rezervasyon rezervasyon)
        {
            await _rezervasyonDal.AddAsync(rezervasyon);
        }

        public void Add(Rezervasyon rezervasyon)
        {
            _rezervasyonDal.Add(rezervasyon);
        }

        public async Task DeleteAsync(int rezervasyonId)
        {
            await _rezervasyonDal.DeleteAsync(new Rezervasyon { Id = rezervasyonId });
        }

        public async Task<List<Rezervasyon>> GetAllAsync(Expression<Func<Rezervasyon, bool>> filter = null, Func<IQueryable<Rezervasyon>, IIncludableQueryable<Rezervasyon, object>> include = null)
        {
            return await _rezervasyonDal.GetListAsync(filter, include);
        }
        
        public async Task<Rezervasyon> GetAsync(Expression<Func<Rezervasyon, bool>> filter = null, Func<IQueryable<Rezervasyon>, IIncludableQueryable<Rezervasyon, object>> include = null)
        {
            return await _rezervasyonDal.GetAsync(filter, include);
        }

        public async Task<Rezervasyon> GetByIdAsync(int rezervasyonId)
        {
            return await _rezervasyonDal.GetAsync(x => x.Id == rezervasyonId);
        }

        public async Task<Rezervasyon> GetByNameAsync(string rezervasyonName)
        {
            return await _rezervasyonDal.GetAsync(x => x.AdSoyad == rezervasyonName);
        }

        public Task<Rezervasyon> ReturnAddAsync(Rezervasyon rezervasyon)
        {
            return  _rezervasyonDal.ReturnAddAsync(rezervasyon);
        }

        public Rezervasyon ReturnAdd(Rezervasyon rezervasyon)
        {
            return  _rezervasyonDal.ReturnAdd(rezervasyon);
        }

        public async Task UpdateAsync(Rezervasyon rezervasyon)
        {
            await _rezervasyonDal.UpdateAsync(rezervasyon);
        }
    }
}
