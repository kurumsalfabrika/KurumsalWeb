using carita_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace carita_com_tr.Controllers
{
    public class HaberController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISayfaService _sayfaService;
        public readonly IHaberService _haberService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;

        public HaberController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IHaberService haberService, IMenuService menuService = null)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _sayfaService = sayfaService;
            _iletisimAyarService = iletisimAyarService;
            _haberService = haberService;
            _menuService = menuService;
        }


        public async Task<IActionResult> Index()
        {

            HaberViewModel model = new HaberViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var yorumlar = await _haberService.GetAllAsync();
            model.Haberler = yorumlar;

            ViewData["Title"] = "Haberler";
            ViewData["Description"] = "";
            ViewData["Kelimeler"] = "";
            return View(model);
        }



        public async Task<IActionResult> Detay(int id)
        {
            HaberViewModel model = new HaberViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var haber = await _haberService.GetByIdAsync(id);
            model.Haber = haber;
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();

            model.Menuler = anaMenuler;
            ViewData["Title"] = model.Haber.Baslik;
            ViewData["Description"] = model.Haber.SEOAciklama;
            ViewData["Kelimeler"] = model.Haber.SEOKelimeler;
            return View(model);
        }
    }
}
