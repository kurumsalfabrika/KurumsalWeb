using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IOdaKategoriService
    {
        Task<List<OdaKategori>> GetAllAsync(Expression<Func<OdaKategori, bool>> filter = null, Func<IQueryable<OdaKategori>, IIncludableQueryable<OdaKategori, object>> include = null);
        Task<OdaKategori> GetByIdAsync(int odaKategoriId);
        Task<OdaKategori> GetByNameAsync(string odaKategoriName);
        Task AddAsync(OdaKategori odaKategori);
        Task UpdateAsync(OdaKategori odaKategori);
        Task DeleteAsync(int odaKategoriId);
    }
}
