using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IRezervasyonService
    {
        Task<List<Rezervasyon>> GetAllAsync(Expression<Func<Rezervasyon, bool>> filter = null, Func<IQueryable<Rezervasyon>, IIncludableQueryable<Rezervasyon, object>> include = null);
        Task<Rezervasyon> GetAsync(Expression<Func<Rezervasyon, bool>> filter = null, Func<IQueryable<Rezervasyon>, IIncludableQueryable<Rezervasyon, object>> include = null);
        Task<Rezervasyon> GetByIdAsync(int rezervasyonId);
        Task<Rezervasyon> GetByNameAsync(string rezervasyonName);
        Task AddAsync(Rezervasyon rezervasyon);
        void Add(Rezervasyon rezervasyon);
        Task<Rezervasyon> ReturnAddAsync(Rezervasyon rezervasyon);
        Rezervasyon ReturnAdd(Rezervasyon rezervasyon);
        Task UpdateAsync(Rezervasyon rezervasyon);
        Task DeleteAsync(int rezervasyonId);
    }
}
