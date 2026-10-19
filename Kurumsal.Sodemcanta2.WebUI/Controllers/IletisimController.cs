using Kurumsal.Business.Abstract;
using Kurumsal.Sodemcanta2.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Sodemcanta2.WebUI.Controllers
{
    public class IletisimController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;


        public IletisimController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
 
        }
        public async Task<IActionResult> Index()
        {
            IletisimViewModel model = new IletisimViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;



            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }
    }
}
