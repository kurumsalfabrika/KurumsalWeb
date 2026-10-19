using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
    public class UrunController : Controller
    {
        public readonly IUrunService _urunService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IUrunKategoriService _urunKategoriService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IFotografService _fotografService;

        public UrunController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService, IUrunKategoriService urunKategoriService, IUrunService urunService, IFotografService fotografService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _urunKategoriService = urunKategoriService;
            _urunService = urunService;
            _fotografService = fotografService;
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

            if(urunKategori.UstKategoriId!=null)
            {
                var ustKategori = await _urunKategoriService.GetByIdAsync((int)urunKategori.UstKategoriId);
                var kendisiUstKategorimi = await _urunKategoriService.GetAllAsync(x => x.UstKategoriId == urunKategori.Id);

                if (kendisiUstKategorimi.Count > 0)
                    model.ListelenecekKategoriler = kendisiUstKategorimi;
                else
                    model.ListelenecekKategoriler = await _urunKategoriService.GetAllAsync(x=>x.Id==urunKategori.Id);
            }


            List<Urun> urunler = new List<Urun>();
            List<Fotograf> fotograflar = new List<Fotograf>();
            if (model.ListelenecekKategoriler == null) 
            {
                model.ListelenecekKategoriler = await _urunKategoriService.GetAllAsync(x=>x.Id== id);
            }




            foreach (var item in model.ListelenecekKategoriler)
            {
               urunler.AddRange(await _urunService.GetAllAsync(x => x.UrunKategoriId == item.Id));
                
            }    

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


            model.Fotograflar = await _fotografService.GetAllAsync(x=>x.UrunId==id);


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
