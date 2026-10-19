using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAllAsync();
        Task<Slider> GetByIdAsync(int sliderId);
        Task<Slider> GetByNameAsync(string sliderName);
        Task AddAsync(Slider slider);
        Task UpdateAsync(Slider slider);
        Task DeleteAsync(int sliderId);
    }
}
