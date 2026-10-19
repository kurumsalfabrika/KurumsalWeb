using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using yazicioglualuminyum_com_2.Models;

namespace yazicioglualuminyum_com_2.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISliderService _sliderService;
        public readonly IReferansService _referansService;
        public readonly IOdaService _odaService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IInsaatProjeService _insaatProjeService;


        public HomeController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISliderService sliderService, IReferansService referansService, IOdaService odaService = null, IUrunKategoriService urunKategoriService = null, IInsaatProjeService insaatProjeService = null)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sliderService = sliderService;
            _referansService = referansService;
            _odaService = odaService;
            _urunKategoriService = urunKategoriService;
            _insaatProjeService = insaatProjeService;
        }

        public async Task<IActionResult> Index()
        {
            GenelViewModel model = new GenelViewModel();

            model.Sliderlar = await _sliderService.GetAllAsync();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);
            model.Referanslar = await _referansService.GetAllAsync();
            model.Odalar = await _odaService.GetAllAsync();
            model.UrunKategoriler = await _urunKategoriService.GetAllAsync();

            model.InsaatProjeler = (await _insaatProjeService.GetAllAsync())
                                     .OrderByDescending(x => x.Ekleme)
                                     .Take(5)
                                     .ToList();

            return View(model);
        }
    }
}
