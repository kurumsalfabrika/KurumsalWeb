using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class YorumController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly ISayfaService _sayfaService;
        public readonly IYorumService _yorumService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public YorumController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IYorumService yorumService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _sayfaService = sayfaService;
            _iletisimAyarService = iletisimAyarService;
            _yorumService = yorumService;
        }
        public async  Task<IActionResult> Index(int id)
        {
            YorumViewModel model = new YorumViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var yorum = await _yorumService.GetByIdAsync(id);
            model.Yorum = yorum;

            ViewData["Title"] = "Yorumlar";
            ViewData["Description"] = model.Yorum.SEOAciklama;
            ViewData["Kelimeler"] = model.Yorum.SEOKelimeler;
            return View(model);
        }
        public async  Task<IActionResult> List()
        {
            YorumViewModel model = new YorumViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var yorumlar = await _yorumService.GetAllAsync();
            model.Yorumlar = yorumlar;

            ViewData["Title"] = "Yorumlar";
            ViewData["Description"] = "";
            ViewData["Kelimeler"] = "";
            return View(model);
        }
    }
}
