using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class ProjeManager : IProjeService
    {
        private readonly IProjeDal _projeDal;

        public ProjeManager(IProjeDal projeDal)
        {
            _projeDal = projeDal;
        }

        public async Task AddAsync(Proje proje)
        {
            await _projeDal.AddAsync(proje);
        }

        public async Task DeleteAsync(int projeId)
        {
            await _projeDal.DeleteAsync(new Proje { Id = projeId });
        }

        public async Task<List<Proje>> GetAllAsync()
        {
            return await _projeDal.GetListAsync();
        }

        public async Task<Proje> GetByIdAsync(int projeId)
        {
            return await _projeDal.GetAsync(x => x.Id == projeId);
        }

        public async Task<Proje> GetByNameAsync(string projeName)
        {
            return await _projeDal.GetAsync(x => x.Baslik == projeName);
        }

        public async Task UpdateAsync(Proje proje)
        {
            await _projeDal.UpdateAsync(proje);
        }
    }
}
