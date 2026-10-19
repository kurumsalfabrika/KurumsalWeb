using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class RehberManager : IRehberService
    {
        private readonly IRehberDal _rehberDal;

        public RehberManager(IRehberDal rehberDal)
        {
            _rehberDal = rehberDal;
        }

        public async Task AddAsync(Rehber rehber)
        {
            await _rehberDal.AddAsync(rehber);
        }

        public async Task DeleteAsync(int rehberId)
        {
            await _rehberDal.DeleteAsync(new Rehber { Id = rehberId });
        }

        public async Task<List<Rehber>> GetAllAsync()
        {
            return await _rehberDal.GetListAsync();
        }

        public async Task<Rehber> GetByIdAsync(int rehberId)
        {
            return await _rehberDal.GetAsync(x => x.Id == rehberId);
        }

        public async Task<Rehber> GetByNameAsync(string rehberName)
        {
            return await _rehberDal.GetAsync(x => x.PostaAdresi == rehberName);
        }

        public async Task UpdateAsync(Rehber rehber)
        {
            await _rehberDal.UpdateAsync(rehber);
        }
    }
}
