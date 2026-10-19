using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using SodemCantaComTr.Models;

namespace SodemCantaComTr.Controllers
{
	public class HomeController : Controller
	{
		public readonly ISliderService _sliderService;
		public readonly ISiteAyarService _siteAyarService;
		public readonly IFtpService _ftpService;
		public readonly IOdaKategoriService _odaKategoriService;
		public readonly IOdaService _odaService;
		public readonly IIletisimAyarService _iletisimAyarService;
		public readonly IFotoGaleriService _fotoGaleriService;
		public readonly IFotografService _fotografService;
		public readonly ISayfaService _sayfaService;
		public readonly IReferansService _referansService;

		public HomeController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaKategoriService odaKategoriService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IFotoGaleriService fotoGaleriService, IFotografService fotografService, ISayfaService sayfaService, IReferansService referansService)
		{
			_sliderService = sliderService;
			_siteAyarService = siteAyarService;
			_ftpService = ftpService;
			_odaKategoriService = odaKategoriService;
			_odaService = odaService;
			_iletisimAyarService = iletisimAyarService;
			_fotoGaleriService = fotoGaleriService;
			_fotografService = fotografService;
			_sayfaService = sayfaService;
			_referansService = referansService;
		}

		public async Task<IActionResult> Index()
		{
			AnasayfaViewModel model = new AnasayfaViewModel();
			var sliderlar = await _sliderService.GetAllAsync();
			model.Sliderlar = sliderlar;
			var ftp = await _ftpService.GetByIdAsync(1);
			model.Ftp = ftp;
			var siteAyar = await _siteAyarService.GetByIdAsync(1);
			model.SiteAyar = siteAyar;
			var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
			model.IletisimAyar = iletisim;

			var fotoGaleri = await _fotoGaleriService.GetByAsync(x => x.ListeKodu == "ANASAYFA");
			var fotograflar = await _fotografService.GetAllAsync(x => x.FotoGaleriId == fotoGaleri.Id);
			model.Fotograflar = fotograflar.OrderBy(x => x.Sira).Take(6).ToList(); // Sıraya göre artan sıralama ve ilk 18 öğeyi al

			var sayfalar = await _sayfaService.GetAllAsync(x => x.ListeKodu == "ANASAYFA");
			model.Sayfalar = sayfalar;

			var referanslar = await _referansService.GetAllAsync();
			model.Referanslar = referanslar;

			ViewData["Title"] = siteAyar.SiteAdi;
			return View(model);
		}
	}
}
