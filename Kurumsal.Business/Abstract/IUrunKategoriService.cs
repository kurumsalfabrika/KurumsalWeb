using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{

    public interface IUrunKategoriService
    {
        Task<List<UrunKategori>> GetAllAsync(Expression<Func<UrunKategori, bool>> filter = null, Func<IQueryable<UrunKategori>, IIncludableQueryable<UrunKategori, object>> include = null);
        Task<UrunKategori> GetByIdAsync(int urunKategoriId);
        Task<UrunKategori> GetByAsync(Expression<Func<UrunKategori, bool>> filter = null, Func<IQueryable<UrunKategori>, IIncludableQueryable<UrunKategori, object>> include = null);
        Task<UrunKategori> GetByNameAsync(string urunKategoriName);
        Task AddAsync(UrunKategori urunKategori);
        Task UpdateAsync(UrunKategori urunKategori);
        Task DeleteAsync(int urunKategoriId);
    }
}
