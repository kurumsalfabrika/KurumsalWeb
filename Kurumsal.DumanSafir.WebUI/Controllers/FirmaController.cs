using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class FirmaController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISayfaService _sayfaService;
        public readonly IFirmaService _firmaService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public FirmaController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IFirmaService firmaService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _sayfaService = sayfaService;
            _iletisimAyarService = iletisimAyarService;
            _firmaService = firmaService;
        }

        public async Task<IActionResult> Index()
        {
            var firmalar = await _firmaService.GetAllAsync();
            var ftp = await _ftpService.GetByIdAsync(1);
            FirmaViewModel model = new FirmaViewModel
            {
                Firmalar = firmalar,
                Ftp = ftp
            };
            return View(model);
        }


    }
}
