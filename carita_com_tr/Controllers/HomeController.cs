using carita_com_tr.Models;
using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace carita_com_tr.Controllers
{
    public class HomeController : Controller
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
        public readonly IMenuService _menuService;
        public HomeController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaKategoriService odaKategoriService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService, ISayfaService sayfaService, IReferansService referansService, IInsaatProjeService insaatProjeService, IMenuService menuService)
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
            _menuService=menuService;
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
            
            var menuler = await _menuService.GetAllAsync();
            var anaMenuler = menuler.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == 1).ToList();

            model.Menuler = anaMenuler;

            try
            {
                var tamamlananProjeler = await _insaatProjeService.GetAllAsync(x => x.ProjeDurumu == ProjeDurumu.Tamamlanmis);
                model.InsaatProjeler = tamamlananProjeler;
            }
            catch (Exception) { }

            try
            {
                var fotoGaleri = await _fotoGaleriService.GetByAsync(x => x.ListeKodu == "ANASAYFA");
                if (fotoGaleri != null)
                {
                    var fotograflar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == fotoGaleri.Id);
                    model.Fotograflar = fotograflar.OrderByDescending(x => x.Sira).Take(6).ToList();
                }
                else
                {
                    model.Fotograflar = new List<Fotograf>();
                }
            }
            catch (Exception) { }
            try
            {
                var sayfalar = await _sayfaService.GetAllAsync(x => x.ListeKodu == "ANASAYFA");
                model.Sayfalar = sayfalar;
            }
            catch (Exception) { }
            try
            {
                var referanslar = await _referansService.GetAllAsync();
                model.Referanslar = referanslar;
            }
            catch (Exception) { }



            return View(model);
        }

    }
}
