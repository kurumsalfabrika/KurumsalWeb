using evonotel_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace evonotel_com.Controllers
{
    public class OdaController : Controller
    {
        public readonly IOdaService _odaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly IFotografService _fotografService;

        public OdaController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, IOdaService odaService, IFotografService fotografService = null)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _odaService = odaService;
            _fotografService = fotografService;
        }

        public async Task<IActionResult> Index()
        {
            OdaViewModel model = new OdaViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var odalar = await _odaService.GetAllAsync();
            model.Odalar = odalar;

            return View(model);
        }

        public async Task<IActionResult> Detay(int id)
        {
            OdaViewModel model = new OdaViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var odalar = await _odaService.GetAllAsync();
            model.Odalar = odalar;
            var oda = await _odaService.GetByIdAsync(id);
            model.Oda = oda;
            model.Odalar = odalar;

            model.Fotograflar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == model.Oda.FotoGaleriId);
            if (oda != null)
            {
                ViewData["Title"] = oda.OdaAdi;
                ViewData["Description"] = oda.SEOAciklama;
                ViewData["Kelimeler"] = oda.SEOKelimeler;
            }
            return View(model);
        }
    }
}
