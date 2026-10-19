using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public async Task AddAsync(Slider slider)
        {
            await _sliderDal.AddAsync(slider);
        }

        public async Task DeleteAsync(int sliderId)
        {
            await _sliderDal.DeleteAsync(new Slider { Id = sliderId });
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            return await _sliderDal.GetListAsync();
        }

        public async Task<Slider> GetByIdAsync(int sliderId)
        {
            return await _sliderDal.GetAsync(x => x.Id == sliderId);
        }

        public async Task<Slider> GetByNameAsync(string sliderName)
        {
            return await _sliderDal.GetAsync(x => x.SEOKelimeler == sliderName);
        }

        public async Task UpdateAsync(Slider slider)
        {
            await _sliderDal.UpdateAsync(slider);
        }
    }
}
