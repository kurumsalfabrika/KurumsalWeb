using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class SubeController : Controller
    {
      
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISubeService _subeService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IFotografService _fotografService;
        public SubeController(ISiteAyarService siteAyarService, IFtpService ftpService, ISubeService subeService, IIletisimAyarService iletisimAyarService, IFotografService fotografService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _subeService = subeService;
            _iletisimAyarService = iletisimAyarService;
            _fotografService = fotografService;
        }


        public async Task<IActionResult> Index(int id)
        {
            SubeViewModel model = new SubeViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var sube = await _subeService.GetByIdAsync(id);
            model.Sube = sube;
            var fotolar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == model.Sube.FotoGaleriId);
            model.Fotograflar = fotolar;

            ViewData["Title"] = model.Sube.SubeAdi;
            ViewData["Description"] = model.Sube.SEOAciklama;
            ViewData["Kelimeler"] = model.Sube.SEOKelimeler;
            return View(model);
        }
    }
}
