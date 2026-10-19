using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
    public class FiyatAlController : Controller
    {
        private readonly ISiteAyarService _siteAyarService;
        private readonly IFtpService _ftpService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly ITeklifService _teklifService;

        public FiyatAlController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, ITeklifService teklifService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _teklifService = teklifService;
        }

        public async Task<IActionResult> Index()
        {
            FiyatAlViewModel model = new FiyatAlViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;

            FiyatAl fiyatAl = new FiyatAl();
            fiyatAl.Id = Guid.NewGuid();

            model.FiyatAl = fiyatAl;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }

        public async Task<IActionResult> Design()
        {
            FiyatAlViewModel model = new FiyatAlViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;

            FiyatAl fiyatAl = new FiyatAl();
            fiyatAl.Id = Guid.NewGuid();
          

            model.FiyatAl = fiyatAl;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        public async Task<IActionResult> BilgiGonder(string imageUrl)
        {
            FiyatAlViewModel model = new FiyatAlViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;

            Teklif teklif = new Teklif();
  
            teklif.Tasarim=imageUrl;

            if (!string.IsNullOrEmpty(imageUrl))
            {
                ViewData["imageUrl"] = imageUrl;
            }

            model.Teklif = teklif;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(FiyatAlViewModel model)
        {
      
                if (model.Teklif.Id == 0)
                {
                    model.Teklif.Ekleme = DateTime.Now;
                    await _teklifService.AddAsync(model.Teklif);
                    return RedirectToAction("Success");
                }
                else
                {
                    var oldEntity = await _teklifService.GetByIdAsync(model.Teklif.Id);

                    model.Teklif.Ekleme = oldEntity.Ekleme;
                    await _teklifService.UpdateAsync(model.Teklif);
                    return RedirectToAction("Success");
                }
        
         
        }
    }
}
