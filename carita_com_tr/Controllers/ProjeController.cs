using carita_com_tr.Models;
using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace carita_com_tr.Controllers
{
    public class ProjeController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IOdaKategoriService _odaKategoriService;
        public readonly IOdaService _odaService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly IFotografService _fotografService;
        public readonly ISayfaService _sayfaService;
        public readonly IReferansService _referansService;
        public readonly IInsaatProjeService _insaatProjeService;
        public ProjeController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaKategoriService odaKategoriService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService, ISayfaService sayfaService, IReferansService referansService, IInsaatProjeService insaatProjeService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _odaKategoriService = odaKategoriService;
            _odaService = odaService;
            _iletisimAyarService = iletisimAyarService;
            _fotoGaleriService = fotoGaleriService;
            _fotografService = fotografService;
            _sayfaService = sayfaService;
            _referansService = referansService;
            _insaatProjeService = insaatProjeService;
       }
        public async Task<IActionResult> Index()
        {
            ProjeViewModel model = new ProjeViewModel();
            var sliderlar = await _sliderService.GetAllAsync();
            model.Sliderlar = sliderlar;
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            try
            {
                var projeler = await _insaatProjeService.GetAllAsync();
                model.InsaatProjeler = projeler;
            }
            catch (Exception) { }
            ViewData["Title"] = siteAyar.SiteAdi +" Projeler";
            return View(model);
        }
        public async Task<IActionResult> ProjeList(ProjeDurumu projeDurumu)
        {
            ProjeViewModel model = new ProjeViewModel();
            var sliderlar = await _sliderService.GetAllAsync();
            model.Sliderlar = sliderlar;
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            try
            {
                var projeler = await _insaatProjeService.GetAllAsync(x=>x.ProjeDurumu== projeDurumu);
                model.InsaatProjeler = projeler;
            }
            catch (Exception) { }
            ViewData["Title"] = siteAyar.SiteAdi +" Projeler";
            return View(model);
        }
        public async Task<IActionResult> Detay(int id)
        {
            ProjeViewModel model = new ProjeViewModel();
            var fotograflar = await _fotografService.GetAllAsync(x=>x.UrunId==id);
            model.Fotograflar = fotograflar;
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
      
            try
            {
                var proje = await _insaatProjeService.GetAsync(x=>x.Id == id);
                model.Proje = proje;
            }
            catch (Exception) { }
            ViewData["Title"] = siteAyar.SiteAdi +" "+model.Proje.ProjeAdi ;
            return View(model);
        }
    }
}
