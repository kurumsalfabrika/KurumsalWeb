using kirilmazlar_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace kirilmazlar_com_tr.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly IOdaService _odaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly ISliderService _sliderService;
        public readonly IHaberService _haberService;
        public readonly IMarkaService _markaService;
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly IFotografService _fotografService;

        public HomeController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService, ISliderService sliderService, IOdaService odaService, IHaberService haberService, IMarkaService markaService, IFotoGaleriService fotoGaleriService = null, IFotografService fotografService = null)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _sayfaService = sayfaService;
            _sliderService = sliderService;
            _odaService = odaService;
            _haberService = haberService;
            _markaService = markaService;
            _fotoGaleriService = fotoGaleriService;
            _fotografService = fotografService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new AnasayfaViewModel();

            var menuler = await _menuService.GetAllAsync();
            var sliderlar = await _sliderService.GetAllAsync();
        
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();
            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();
            var footerMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 3).ToList();
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            var markalar = await _markaService.GetAllAsync(null);
            var fotogaleri = await _fotoGaleriService.GetByAsync(x=>x.ListeKodu=="ANASAYFA");
            var fotograflar = await _fotografService.GetAllAsync(x=>x.FotoGaleriId==fotogaleri.Id);



            model.Menuler = menuler;
            model.AnaMenuler = anaMenuler;
            model.SosyalMedyaAdresler = sosyalMedyaAdreslerim;
            model.FooterMenuler = footerMenuler;
            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;
            model.Sliderlar = sliderlar;
            model.Markalar = markalar;
            model.Fotograflar = fotograflar;

            return View(model);
        }
    }
}
