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
    public class HaberManager : IHaberService
    {
        private readonly IHaberDal _haberDal;

        public HaberManager(IHaberDal haberDal)
        {
            _haberDal = haberDal;
        }

        public async Task AddAsync(Haber haber)
        {
            await _haberDal.AddAsync(haber);
        }

        public async Task DeleteAsync(int haberId)
        {
            await _haberDal.DeleteAsync(new Haber { Id = haberId });
        }

        public async Task<List<Haber>> GetAllAsync(Func<IQueryable<Haber>, IIncludableQueryable<Haber, object>> include = null)
        {
            return await _haberDal.GetListAsync(null, include);
        }

        public async Task<Haber> GetByAsync(Func<IQueryable<Haber>, IIncludableQueryable<Haber, object>> include = null)
        {
            return await _haberDal.GetAsync(null, include);
        }

        public async Task<Haber> GetByIdAsync(int haberId)
        {
            return await _haberDal.GetAsync(x => x.Id == haberId);
        }

        public async Task<Haber> GetByNameAsync(string haberName)
        {
            return await _haberDal.GetAsync(x => x.Baslik == haberName);
        }

        public async Task UpdateAsync(Haber haber)
        {
            await _haberDal.UpdateAsync(haber);
        }
    }
}
