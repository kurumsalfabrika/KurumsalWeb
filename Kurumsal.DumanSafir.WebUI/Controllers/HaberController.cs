using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class HaberController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISayfaService _sayfaService;
        public readonly IHaberService _haberService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public HaberController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IHaberService haberService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _sayfaService = sayfaService;
            _iletisimAyarService = iletisimAyarService;
            _haberService = haberService;
        }
        public async  Task<IActionResult> Index(int id)
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

            ViewData["Title"] = model.Haber.Baslik;
            ViewData["Description"] = model.Haber.SEOAciklama;
            ViewData["Kelimeler"] = model.Haber.SEOKelimeler;
            return View(model);
        }



        public async Task<IActionResult> List()
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
    }
}
