using Kurumsal.Business.Abstract;
using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class OdaController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IOdaService _odaService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IFotografService _fotografService;


		public OdaController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IFotografService fotografService)
		{
			_sliderService = sliderService;
			_siteAyarService = siteAyarService;
			_ftpService = ftpService;
			_odaService = odaService;
			_iletisimAyarService = iletisimAyarService;
			_fotografService = fotografService;
		}
		public async Task<IActionResult> Index(int id)
        {
            OdaViewModel model = new OdaViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
            var oda = await _odaService.GetByIdAsync(id);
            model.Oda = oda;
            var fotolar = await _fotografService.GetAllAsync(x=>x.FotoGaleriId==model.Oda.FotoGaleriId);
            model.Fotograflar = fotolar;

            ViewData["Title"] = model.Oda.OdaAdi;
            ViewData["Description"] = model.Oda.SEOAciklama;
            ViewData["Kelimeler"] = model.Oda.SEOKelimeler;
            return View(model);
        }
    }
}
