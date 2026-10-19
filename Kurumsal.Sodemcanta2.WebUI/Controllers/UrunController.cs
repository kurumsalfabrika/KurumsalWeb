using Kurumsal.Business.Abstract;
using Kurumsal.Sodemcanta2.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Sodemcanta2.WebUI.Controllers
{
    public class UrunController : Controller
    {
        public readonly IUrunService _urunService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IIletisimAyarService _iletisimAyarService;

        public UrunController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IUrunKategoriService urunKategoriService, IUrunService urunService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _urunKategoriService = urunKategoriService;
            _urunService = urunService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> KategoriDetay(int id)
        {
            UrunViewModel model = new UrunViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var urunKategoriler = await _urunKategoriService.GetAllAsync();
            model.UrunKategoriler = urunKategoriler;
            var urunKategori = await _urunKategoriService.GetByIdAsync(id);
            var urunler = await _urunService.GetAllAsync(x => x.UrunKategoriId == id);
            model.Urunler = urunler;
            model.UrunKategori = urunKategori;

            if (urunKategori != null)
            {
                ViewData["Title"] = urunKategori.KategoriAdi;
                ViewData["Description"] = urunKategori.SEOAciklama;
                ViewData["Kelimeler"] = urunKategori.SEOKelimeler;
            }
            return View(model);
        }


        public async Task<IActionResult> Detay(int id)
        {
            UrunViewModel model = new UrunViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var urunKategoriler = await _urunKategoriService.GetAllAsync();
            model.UrunKategoriler = urunKategoriler;
            var urun = await _urunService.GetByIdAsync(id);
            var urunKategori = await _urunKategoriService.GetByIdAsync((int)urun.UrunKategoriId);
            model.Urun = urun;
            model.UrunKategori = urunKategori;



            if (urun != null)
            {
                ViewData["Title"] = urunKategori.KategoriAdi + " - " + urun.UrunKodu;
                ViewData["Description"] = urun.SEOAciklama;
                ViewData["Kelimeler"] = urun.SEOKelimeler;
            }
            return View(model);
        }
    }
}
