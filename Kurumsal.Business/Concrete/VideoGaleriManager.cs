using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
    public class VideoGaleriManager : IVideoGaleriService
    {
        private readonly IVideoGaleriDal _videogaleriDal;

        public VideoGaleriManager(IVideoGaleriDal videogaleriDal)
        {
            _videogaleriDal = videogaleriDal;
        }

        public async Task AddAsync(VideoGaleri videogaleri)
        {
            await _videogaleriDal.AddAsync(videogaleri);
        }

        public async Task DeleteAsync(int videogaleriId)
        {
            await _videogaleriDal.DeleteAsync(new VideoGaleri { Id = videogaleriId });
        }

        public async Task<List<VideoGaleri>> GetAllAsync()
        {
            return await _videogaleriDal.GetListAsync();
        }

        public async Task<VideoGaleri> GetByIdAsync(int videogaleriId)
        {
            return await _videogaleriDal.GetAsync(x => x.Id == videogaleriId);
        }

        public async Task<VideoGaleri> GetByNameAsync(string videogaleriName)
        {
            return await _videogaleriDal.GetAsync(x => x.YoutubeId == videogaleriName);
        }

        public async Task UpdateAsync(VideoGaleri videogaleri)
        {
            await _videogaleriDal.UpdateAsync(videogaleri);
        }
    }
}
