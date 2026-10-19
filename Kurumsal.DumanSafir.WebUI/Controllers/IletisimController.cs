using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
	public class IletisimController : Controller
	{

		public readonly ISiteAyarService _siteAyarService;
		public readonly IFtpService _ftpService;
		public readonly IIletisimAyarService _iletisimAyarService;
		public readonly IIletisimService _iletisimService;

		public IletisimController(ISliderService sliderService, ISiteAyarService siteAyarService,IIletisimService iletisimService, IFtpService ftpService, ISayfaService sayfaService, IIletisimAyarService iletisimAyarService)
		{
			_siteAyarService = siteAyarService;
			_ftpService = ftpService;
			_iletisimAyarService = iletisimAyarService;
			_iletisimService = iletisimService;
		}
        public async Task<IActionResult> Index()
        {

            IletisimViewModel model = new IletisimViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = new Iletisim();
            model.SiteAyar = siteAyar;

            var iletisimAyar = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisimAyar;



            ViewData["Title"] = siteAyar.SiteAdi + " İletişim Bilgileri";

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(IletisimViewModel model)
        {
   

                if (model.Iletisim.Id == 0)
                {
                    model.Iletisim.Ekleme = DateTime.Now;
                    await _iletisimService.AddAsync(model.Iletisim);
                    return RedirectToAction("Success");
                }
                else
                {
                    var oldEntity = await _iletisimService.GetByIdAsync(model.Iletisim.Id);


                    model.Iletisim.Ekleme = oldEntity.Ekleme;
                    await _iletisimService.UpdateAsync(model.Iletisim);
                    return RedirectToAction("Success");
                }
        }


        public async Task<IActionResult> Success()
        {

            IletisimViewModel model = new IletisimViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = new Iletisim();
            model.SiteAyar = siteAyar;

            var iletisimAyar = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisimAyar;



            ViewData["Title"] = siteAyar.SiteAdi + " İletişim Bilgileri";

            return View(model);
        }

    }
}
