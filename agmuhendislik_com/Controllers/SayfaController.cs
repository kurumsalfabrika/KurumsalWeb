using agmuhendislik_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace agmuhendislik_com.Controllers
{
    public class SayfaController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;

        public SayfaController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _sayfaService = sayfaService;
        }

        public async Task<IActionResult> Index(int id)
        {
            SayfaViewModel model = new SayfaViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var sayfalar = await _sayfaService.GetAllAsync();
            model.Sayfalar = sayfalar;
            var sayfa = await _sayfaService.GetByIdAsync(id);
            model.Sayfa = sayfa;
            model.Sayfalar = sayfalar;

            if (sayfa != null)
            {
                ViewData["Title"] = sayfa.Baslik;
                ViewData["Description"] = sayfa.SEOAciklama;
                ViewData["Kelimeler"] = sayfa.SEOKelimeler;
            }
            return View(model);
        }
    }
}
