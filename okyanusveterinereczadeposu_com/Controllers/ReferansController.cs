using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using okyanusveterinereczadeposu_com.Models;

namespace okyanusveterinereczadeposu_com.Controllers
{
    public class ReferansController : Controller
    {
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly IFotografService _fotografService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IReferansService _referansService;

        public ReferansController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService = null, IUrunKategoriService urunKategoriService = null, IReferansService referansService = null)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _fotoGaleriService = fotoGaleriService;
            _fotografService = fotografService;
            _urunKategoriService = urunKategoriService;
            _referansService = referansService;
        }
        public async Task<IActionResult> Index()
        {
            RefaransViewModel model = new RefaransViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            var referanslar = await _referansService.GetAllAsync();
            model.Referanslar= referanslar;

            return View(model);
        }
    }
}
