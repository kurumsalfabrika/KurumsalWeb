using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Abstract
{
    public interface IVideoGaleriService
    {
        Task<List<VideoGaleri>> GetAllAsync();
        Task<VideoGaleri> GetByIdAsync(int videogaleriId);
        Task<VideoGaleri> GetByNameAsync(string videogaleriName);
        Task AddAsync(VideoGaleri videogaleri);
        Task UpdateAsync(VideoGaleri videogaleri);
        Task DeleteAsync(int videogaleriId);
    }
}
