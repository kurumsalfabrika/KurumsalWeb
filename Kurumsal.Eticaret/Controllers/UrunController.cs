using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.Eticaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Eticaret.Controllers
{
    public class UrunController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IUrunService _urunService;
        public readonly IUrunKategoriService _urunKategoriService;

        public UrunController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IUrunService urunService, IUrunKategoriService urunKategoriService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _urunService = urunService;
            _urunKategoriService = urunKategoriService;
        }
        public async Task<IActionResult> UrunDetay(int id)
        {
            UrunViewModel model = new UrunViewModel();

            var urun = await _urunService.GetByAsync(x => x.Id== id);
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            model.Urun = urun;
            model.UrunKategori=await _urunKategoriService.GetByIdAsync((int)model.Urun.UrunKategoriId);
            return View(model);
        }
    }
}
