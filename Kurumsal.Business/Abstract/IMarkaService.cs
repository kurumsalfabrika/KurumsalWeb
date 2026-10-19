using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IMarkaService
    {
        Task<List<Marka>> GetAllAsync(Func<IQueryable<Marka>, IIncludableQueryable<Marka, object>> include = null);
        Task<Marka> GetByIdAsync(int markaId);
        Task<Marka> GetByAsync(Func<IQueryable<Marka>, IIncludableQueryable<Marka, object>> include = null);
        Task<Marka> GetByNameAsync(string markaAdi);
        Task AddAsync(Marka marka);
        Task UpdateAsync(Marka marka);
        Task DeleteAsync(int markaId);
    }
}
