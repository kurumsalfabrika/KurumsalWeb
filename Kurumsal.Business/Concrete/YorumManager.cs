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
    public class YorumManager : IYorumService
    {
        private readonly IYorumDal _yorumDal;

        public YorumManager(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }

        public async Task AddAsync(Yorum yorum)
        {
            await _yorumDal.AddAsync(yorum);
        }

        public async Task DeleteAsync(int yorumId)
        {
            await _yorumDal.DeleteAsync(new Yorum { Id = yorumId });
        }

        public async Task<List<Yorum>> GetAllAsync(Func<IQueryable<Yorum>, IIncludableQueryable<Yorum, object>> include = null)
        {
            return await _yorumDal.GetListAsync(null, include);
        }

        public async Task<Yorum> GetByAsync(Func<IQueryable<Yorum>, IIncludableQueryable<Yorum, object>> include = null)
        {
            return await _yorumDal.GetAsync(null, include);
        }

        public async Task<Yorum> GetByIdAsync(int yorumId)
        {
            return await _yorumDal.GetAsync(x => x.Id == yorumId);
        }

        public async Task<Yorum> GetByNameAsync(string yorumName)
        {
            return await _yorumDal.GetAsync(x => x.AdSoyad == yorumName);
        }

        public async Task UpdateAsync(Yorum yorum)
        {
            await _yorumDal.UpdateAsync(yorum);
        }
    }
}
