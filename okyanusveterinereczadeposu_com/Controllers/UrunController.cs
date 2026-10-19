using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using okyanusveterinereczadeposu_com.Models;

namespace okyanusveterinereczadeposu_com.Controllers
{
    public class UrunController : Controller
    {
        public readonly IFotoGaleriService _fotoGaleriService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly IFotografService _fotografService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IUrunService _urunService;

        public UrunController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService = null, IUrunKategoriService urunKategoriService = null, IUrunService urunService = null)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _fotoGaleriService = fotoGaleriService;
            _fotografService = fotografService;
            _urunKategoriService = urunKategoriService;
            _urunService = urunService;
        }

        public async Task<IActionResult> Index(int id)
        {
            UrunViewModel model = new UrunViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            var urun = await _urunService.GetByIdAsync(id);
            model.Urun = urun;

            var urunKategori = await _urunKategoriService.GetByAsync(x => x.Id == model.Urun.UrunKategoriId);
            model.UrunKategori = urunKategori;

            var urunKategoriler = await _urunKategoriService.GetAllAsync();
            model.UrunKategoriler = urunKategoriler;

            var urunler = await _urunService.GetAllAsync(x => x.UrunKategoriId == model.Urun.UrunKategoriId);
            model.Urunler = urunler;

            return View(model);
        }
    }
}
