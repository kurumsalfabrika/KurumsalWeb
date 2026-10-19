using GOSAS.VirtualPos.Core;
using GOSAS.VirtualPos.Core.Enums;
using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Migrations;
using Kurumsal.DumanSafir.WebUI.Models;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Xml.Linq;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class RezervasyonController : Controller
    {
        public readonly ISliderService _sliderService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IOdaKategoriService _odaKategoriService;
        public readonly IOdaService _odaService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IRezervasyonService _rezervasyonService;
        private readonly ICurrencyService _currencyService;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;

        public RezervasyonController(ISliderService sliderService, ISiteAyarService siteAyarService, IFtpService ftpService, IOdaKategoriService odaKategoriService, IOdaService odaService, IIletisimAyarService iletisimAyarService, IRezervasyonService rezervasyonService, HttpClient httpClient, IMemoryCache memoryCache, ICurrencyService currencyService)
        {
            _sliderService = sliderService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _odaKategoriService = odaKategoriService;
            _odaService = odaService;
            _iletisimAyarService = iletisimAyarService;
            _rezervasyonService = rezervasyonService;
            _httpClient = httpClient;
            _memoryCache = memoryCache;
            _currencyService = currencyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetExchangeRates()
        {
            var rates = await _currencyService.GetExchangeRatesAsync();
            return Ok(rates);
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var oda = await _odaService.GetByIdAsync(id);
            RezervasyonViewModel model = new RezervasyonViewModel();

            Ftp ftp = await _ftpService.GetByIdAsync(1);
            model.Oda = oda;
            model.Ftp = ftp;

            Rezervasyon rezervasyon = new Rezervasyon();

            rezervasyon.GirisTarihi = DateTime.Now;
            rezervasyon.CikisTarihi = DateTime.Now.AddMonths(1);
            decimal convertedGunlukUcret = _currencyService.ConvertToCurrency(oda.GunlukUcret);
            rezervasyon.GunlukUcret = convertedGunlukUcret;
            model.GunlukUcret = convertedGunlukUcret;
            rezervasyon.GunlukUcretDovizAdi = _currencyService.GetCurrencySymbol();

            if (rezervasyon.GunlukUcretDovizAdi == "TL")
                rezervasyon.GunlukUcretDovizKodu = "949";

            if (rezervasyon.GunlukUcretDovizAdi == "USD")
                rezervasyon.GunlukUcretDovizKodu = "840";

            if (rezervasyon.GunlukUcretDovizAdi == "EUR")
                rezervasyon.GunlukUcretDovizKodu = "978";

            rezervasyon.Currency = rezervasyon.GunlukUcretDovizKodu;

            rezervasyon.OdaId = oda.Id;

            TimeSpan difference = rezervasyon.CikisTarihi - rezervasyon.GirisTarihi;
            rezervasyon.ToplamGun = difference.Days;
            rezervasyon.ToplamTutar = rezervasyon.ToplamGun * rezervasyon.GunlukUcret;

            model.Rezervasyon = rezervasyon;

            ViewData["Title"] = "Safir Rezidans Online Rezervasyon Sistemi";


            return View(model);
        }


  

        [HttpPost]
        public async Task<IActionResult> Odeme(RezervasyonViewModel model)
        {
            ViewData["Title"] = "Safir Rezidans Online Ödeme";


            if (model.Rezervasyon != null)
            {
                await LoadCommonData(model);

                model.Rezervasyon.Amount = model.Rezervasyon.ToplamTutar.ToString();

                var oda = await _odaService.GetByIdAsync(model.Rezervasyon.OdaId);
                model.Oda = oda;

                var sonuc1 = await _rezervasyonService.GetByIdAsync(model.Rezervasyon.Id);

                    model.Rezervasyon.Amount = model.Amount;
                var result = _rezervasyonService.ReturnAdd(model.Rezervasyon);

                model.Rezervasyon.Id = result.Id;

                decimal tutar = model.Rezervasyon.ToplamTutar;
                double tutar1 = (double)tutar;

                PaymentGaranti paymentGaranti = new PaymentGaranti();

                

                paymentGaranti.TotalAmount = 0;
                paymentGaranti.TotalAmount = tutar1;
                paymentGaranti.Currency = _currencyService.GetCurrencySymbol();


                model.PaymentViewModel = paymentGaranti;
                return View(model);
              
            }
            else
            {
                await LoadCommonData(model);
            }

            // Kredi kartı ile ödeme sayfasına modeli gönder
            return View(model);
        }

        private async Task LoadCommonData(RezervasyonViewModel model)
        {
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;

            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            var odaKategoriler = await _odaKategoriService.GetAllAsync();
            model.OdaKategoriler = odaKategoriler;

            var odalar = await _odaService.GetAllAsync();
            model.Odalar = odalar;

            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;
        }

        [HttpPost]
        public async Task<IActionResult> Payment([FromForm] PaymentViewModel model)
        {
            var currency = GVPOSCurrencyCodes.USD;
            
            if (_currencyService.GetCurrencySymbol()=="TL")
                currency= GVPOSCurrencyCodes.TRY;

            if (_currencyService.GetCurrencySymbol()=="EUR")
                currency= GVPOSCurrencyCodes.EURO;

            
            

       

            var response = new GVPosManager()
                .Test(false)
                .Company(GVPOSConfigurations.TerminalID_For_XML, GVPOSConfigurations.MerchandID, GVPOSConfigurations.ProvUserID_AUT, GVPOSConfigurations.ProvUserPassword, GVPOSConfigurations.SubMerchandID)
                .Customer(GVPOSConfigurations.Customer_Email, GVPOSConfigurations.Customer_IPAddress)
                .CreditCard(model.CardNumber, model.CvvCode, model.ExpireMonth, model.ExpireYear)
                .Order(Guid.NewGuid().ToString("N"))
                .Amount(((double)model.TotalAmount), currency)
                .Sales();

            XDocument doc = XDocument.Parse(response.RawResponse);

            var errorMsg = doc.Descendants("ErrorMsg").FirstOrDefault()?.Value;
            var sysErrMsg = doc.Descendants("SysErrMsg").FirstOrDefault()?.Value;



            var viewModel = new PaymentViewModel
            {
                FormData = response.RawResponse,
                ErrorMessage = errorMsg,
                SystemErrorMessage = sysErrMsg
            };

            return View(viewModel);
        }

        //paymentRequest.Rezervasyon.ToplamTutar = Convert.ToDecimal(paymentRequest.Amount);
        //var paymentRequestId = Guid.NewGuid();
        //_memoryCache.Set(paymentRequestId, paymentRequest, TimeSpan.FromMinutes(30));
        //Response.Cookies.Append("PaymentRequestId", paymentRequestId.ToString(), new CookieOptions { HttpOnly = true, Secure = true });

        //var formFields = Request.Form.ToDictionary(k => k.Key, v => v.Value.ToString())
        //                             .Where(kv => kv.Key != "__RequestVerificationToken" && kv.Key != "hash")
        //                             .OrderBy(kv => kv.Key)
        //                             .ToDictionary(k => k.Key, v => v.Value);

        //string hashVal = string.Join("|", formFields.Select(kv => kv.Value.Replace("\\", "\\\\").Replace("|", "\\|")));
        //hashVal += "|" + StoreKey;

        //using (SHA512 sha = new SHA512CryptoServiceProvider())
        //{
        //    byte[] hashbytes = Encoding.UTF8.GetBytes(hashVal);
        //    byte[] inputbytes = sha.ComputeHash(hashbytes);
        //    string hash = Convert.ToBase64String(inputbytes);
        //    formFields.Add("hash", hash);
        //}

        //return View(formFields);
        //}


    }
}
