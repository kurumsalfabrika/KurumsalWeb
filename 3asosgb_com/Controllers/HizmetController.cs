using _3asosgb_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace _3asosgb_com.Controllers
{
    public class HizmetController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly IHizmetService _hizmetService;

        public HizmetController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService, IHizmetService hizmetService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _sayfaService = sayfaService;
            _hizmetService = hizmetService;
        }
        public async Task<IActionResult> Index(int id)
        {
            HizmetViewModel model = new HizmetViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var hizmetler = await _hizmetService.GetAllAsync();
            model.Hizmetler= hizmetler;
            var hizmet = await _hizmetService.GetByIdAsync(id);
            model.Hizmetler = hizmetler;
            model.Hizmet = hizmet;

            if (hizmet != null)
            {
                ViewData["Title"] = hizmet.HizmetAdi;
                ViewData["Description"] = hizmet.SEOAciklama;
                ViewData["Kelimeler"] = hizmet.SEOKelimeler;
            }
            return View(model);
        }
    }
}
