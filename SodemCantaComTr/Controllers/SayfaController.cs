using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
    public class SayfaController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public SayfaController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, ISayfaService sayfaService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
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
