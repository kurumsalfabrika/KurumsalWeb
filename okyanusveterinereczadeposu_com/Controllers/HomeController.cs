using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using okyanusveterinereczadeposu_com.Models;
using System.Diagnostics;

namespace okyanusveterinereczadeposu_com.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISliderService _sliderService;
        public readonly IReferansService _referansService;
        public readonly IUrunKategoriService _urunKategoriService;

        public HomeController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISliderService sliderService, IReferansService referansService, IUrunKategoriService urunKategoriService )
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sliderService = sliderService;
            _referansService = referansService;
            _urunKategoriService = urunKategoriService;
        }

        public async Task<IActionResult> Index()
        {
            AnasayfaViewModel model = new AnasayfaViewModel();
            model.Sliderlar = await _sliderService.GetAllAsync();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);
            model.Referanslar = await _referansService.GetAllAsync();
            model.UrunKategoriler = await _urunKategoriService.GetAllAsync();
            return View(model);
        }
    }
}
