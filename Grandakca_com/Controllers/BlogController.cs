using Grandakca_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Grandakca_com.Controllers
{
    public class BlogController : Controller
    {
        public readonly IBlogService _blogService;
        public readonly IFotografService _fotografService;
        public readonly IOdaService _odaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly ISliderService _sliderService;

        public BlogController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, IBlogService blogService, ISliderService sliderService, IOdaService odaService, IFotografService fotografService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _blogService = blogService;
            _sliderService = sliderService;
            _odaService = odaService;
            _fotografService = fotografService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new SayfaViewModel();

            var bloglar = await _blogService.GetAllAsync();
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            model.Bloglar = bloglar;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }
        public async Task<IActionResult> BlogDetay(int id)
        {
            var model = new SayfaViewModel();

            var bloglar = await _blogService.GetAllAsync();
            var blog = await _blogService.GetByIdAsync(id);
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            model.Bloglar = bloglar;
            model.Blog = blog;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }
    }
}
