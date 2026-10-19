using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
    public class ReferansController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IReferansService _referansService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public ReferansController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IReferansService referansService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _referansService = referansService;
        }
        public async Task<IActionResult> Index()
        {
            ReferansViewModel model = new ReferansViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var referanslar = await _referansService.GetAllAsync();
            model.Referanslar = referanslar;


            if (referanslar != null)
            {
                ViewData["Title"] = "Referanslar";
            }
            return View(model);
        }
    }
}
