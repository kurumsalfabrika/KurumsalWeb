using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IOdaKategoriService _odaKategoriService;
        public readonly IOdaService _odaService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IHaberService _haberService;
        public readonly IYorumService _yorumService;

        public HomeController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaKategoriService odaKategoriService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IHaberService haberService, IYorumService yorumService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _odaKategoriService = odaKategoriService;
            _odaService = odaService;
            _iletisimAyarService = iletisimAyarService;
            _haberService = haberService;
            _yorumService = yorumService;
        }

        public async Task<IActionResult> Index()
        {

            AnasayfaViewModel model = new AnasayfaViewModel();
            var haberler = await _haberService.GetAllAsync();
            model.Haberler = haberler.OrderByDescending(h => h.Ekleme).Take(2).ToList();
            var yorumlar = await _yorumService.GetAllAsync();
            model.Yorumlar = yorumlar.OrderByDescending(h => h.Ekleme).Take(3).ToList();

            var sliderlar = await _sliderService.GetAllAsync();
            model.Sliderlar = sliderlar;
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var odaKategoriler = await _odaKategoriService.GetAllAsync();
            model.OdaKategoriler = odaKategoriler;
            var odalar = await _odaService.GetAllAsync();
            model.Odalar = odalar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;



            ViewData["Title"] = siteAyar.SiteAdi;

			return View(model);
        }

    }
}
