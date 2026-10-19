using Grandakca_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Grandakca_com.Controllers
{
    public class OdaController : Controller
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

        public OdaController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService, ISliderService sliderService, IOdaService odaService, IFotografService fotografService)
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
        public async Task<IActionResult> Index()
        {
            var model = new OdaViewModel();
            var odalar = await _odaService.GetAllAsync();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            model.Odalar = odalar;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }

        public async Task<IActionResult> OdaDetay(int id)
        {
            var model = new OdaViewModel();
            var odalar = await _odaService.GetAllAsync();
            var oda = await _odaService.GetByIdAsync(id);
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);

            if(oda.FotoGaleriId != null)
            {
                var fotograflar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == oda.FotoGaleriId);
                model.Fotograflar = fotograflar;
            }

            model.Odalar = odalar;
            model.Oda = oda;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;

            return View(model);
        }
    }
}
