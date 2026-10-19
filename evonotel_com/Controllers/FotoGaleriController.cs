using evonotel_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace evonotel_com.Controllers
{
    public class FotoGaleriController : Controller
    {
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly IFotografService _fotografService;

        public FotoGaleriController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService = null)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _fotoGaleriService = fotoGaleriService;
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
            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();
            model.FotoGaleriler = fotoGaleriler;
            var fotograflar = await _fotografService.GetAllAsync();
            model.Fotograflar = fotograflar;

            return View(model);
        }

        

        public async Task<IActionResult> Detay(int id)
        {
            FotoGaleriViewModel model = new FotoGaleriViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();
            model.FotoGaleriler = fotoGaleriler;
            var fotograflar = await _fotografService.GetAllAsync(x=>x.FotoGaleriId==id);
            model.Fotograflar = fotograflar;
            var fotoGaleri = await _fotoGaleriService.GetByIdAsync(id);
            model.FotoGaleri = fotoGaleri;


            if (fotoGaleri != null)
            {
                ViewData["Title"] = fotoGaleri.GaleriAdi;
                ViewData["Description"] = fotoGaleri.SEOAciklama;
                ViewData["Kelimeler"] = fotoGaleri.SEOKelimeler;
            }

            return View(model);
        }

        
    }
}
