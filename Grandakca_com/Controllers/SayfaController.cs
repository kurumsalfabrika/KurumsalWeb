using Grandakca_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Grandakca_com.Controllers
{
    public class SayfaController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly IFotografService _fotografService;
        public readonly IOdaService _odaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly ISliderService _sliderService;

        public SayfaController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService, ISliderService sliderService, IOdaService odaService, IFotografService fotografService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _sayfaService = sayfaService;
            _sliderService = sliderService;
            _odaService = odaService;
            _fotografService = fotografService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = new SayfaViewModel();

            var sayfa = await _sayfaService.GetByIdAsync(id);
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            var sayfalar = await _sayfaService.GetAllAsync();
            model.Sayfalar = sayfalar;

            model.Sayfa = sayfa;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }
    }
}
