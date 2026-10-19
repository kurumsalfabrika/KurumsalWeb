using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
    public class FotoGaleriController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly IFotografService _fotografService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public FotoGaleriController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IFotoGaleriService fotoGaleriService, IIletisimAyarService iletisimAyarService, IFotografService fotografService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _fotoGaleriService = fotoGaleriService;
            _iletisimAyarService = iletisimAyarService;
            _fotografService = fotografService;
        }



        public async Task<IActionResult> Index()
        {
            FotoGaleriViewModel model = new FotoGaleriViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var fotoGaleri = await _fotoGaleriService.GetByAsync(x => x.ListeKodu == "FOTOGALERI");
            model.FotoGaleri = fotoGaleri;
            var fotograflar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == model.FotoGaleri.Id);
            model.Fotograflar = fotograflar;

            ViewData["Title"] = model.FotoGaleri.GaleriAdi;
            ViewData["Description"] = model.FotoGaleri.SEOAciklama;
            ViewData["Kelimeler"] = model.FotoGaleri.SEOKelimeler;
            return View(model);
        }
    }
}
