using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.Eticaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Eticaret.Controllers
{
    public class KategoriController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IUrunService _urunService;
        public readonly IUrunKategoriService _urunKategoriService;

        public KategoriController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IUrunService urunService, IUrunKategoriService urunKategoriService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _urunService = urunService;
            _urunKategoriService = urunKategoriService;
        }
        public async Task<IActionResult> KategoriList(int id)
        {
            UrunKategoriViewModel model = new UrunKategoriViewModel();
            model.UrunKategori=await _urunKategoriService.GetByIdAsync(id);
            var altKategoriler = await _urunKategoriService.GetAllAsync(x => x.UstKategoriId == id);
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            List<Urun> newUrunler = new List<Urun>();


            if(altKategoriler.Count == 0)
            {
                model.Urunler = await _urunService.GetAllAsync(x => x.UrunKategoriId == id);
            }
            else
            {

            foreach (var item in altKategoriler) 
            {
                List<Urun> addUrunler = await _urunService.GetAllAsync(x => x.UrunKategoriId == item.Id);
                newUrunler.AddRange(addUrunler);
            }
            model.Urunler = newUrunler;
            }

            return View(model);
        }
    }
}
