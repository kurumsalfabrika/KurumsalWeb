using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IYorumService
    {
        Task<List<Yorum>> GetAllAsync(Func<IQueryable<Yorum>, IIncludableQueryable<Yorum, object>> include = null);
        Task<Yorum> GetByIdAsync(int yorumId);
        Task<Yorum> GetByAsync(Func<IQueryable<Yorum>, IIncludableQueryable<Yorum, object>> include = null);
        Task<Yorum> GetByNameAsync(string yorumName);
        Task AddAsync(Yorum yorum);
        Task UpdateAsync(Yorum yorum);
        Task DeleteAsync(int yorumId);
    }
}
