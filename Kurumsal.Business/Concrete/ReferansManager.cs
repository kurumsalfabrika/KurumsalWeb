using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class ReferansManager : IReferansService
    {
        private IReferansDal _referansDal;

        public ReferansManager(IReferansDal referansDal)
        {
            _referansDal = referansDal;
        }

        public async Task AddAsync(Referans referans)
        {
            await _referansDal.AddAsync(referans);
        }

        public async Task DeleteAsync(int referansId)
        {
            await _referansDal.DeleteAsync(new Referans { Id = referansId });
        }

        public async Task<List<Referans>> GetAllAsync()
        {
            return await _referansDal.GetListAsync();
        }

        public async Task<Referans> GetByIdAsync(int referansId)
        {
            return await _referansDal.GetAsync(x => x.Id == referansId);
        }

        public async Task<Referans> GetByNameAsync(string referansName)
        {
            return await _referansDal.GetAsync(x => x.SEOAciklama == referansName);
        }

        public async Task UpdateAsync(Referans referans)
        {
            await _referansDal.UpdateAsync(referans);
        }
    }
}
