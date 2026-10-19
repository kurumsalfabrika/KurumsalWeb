using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class SayfaController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISayfaService _sayfaService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public SayfaController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _sayfaService = sayfaService;
            _iletisimAyarService = iletisimAyarService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Detay(int id)
        {
            SayfaViewModel model = new SayfaViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var sayfa = await _sayfaService.GetByIdAsync(id);
            model.Sayfa = sayfa;    

            ViewData["Title"] = model.Sayfa.Baslik;
            ViewData["Description"] = model.Sayfa.SEOAciklama;
            ViewData["Kelimeler"] = model.Sayfa.SEOKelimeler;
            return View(model);
        }
    }
}
