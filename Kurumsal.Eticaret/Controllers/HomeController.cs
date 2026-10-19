using Kurumsal.Business.Abstract;
using Kurumsal.Eticaret.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kurumsal.Eticaret.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IUrunService _urunService;

        public HomeController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IUrunService urunService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _urunService = urunService;
        }
        public async Task<IActionResult> Index()
        {

            AnasayfaViewModel model = new AnasayfaViewModel();
            var sliderlar = await _sliderService.GetAllAsync();
            model.Sliderlar = sliderlar;
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            
            var vitrinUrunleri = await _urunService.GetAllAsync(x => x.VitrindeGoster == true);
            model.VitrinUrunleri = vitrinUrunleri;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }


    }
}
