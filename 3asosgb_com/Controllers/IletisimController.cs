using _3asosgb_com.Models;
using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace _3asosgb_com.Controllers
{
    public class IletisimController : Controller
    {
        public readonly ISayfaService _sayfaService;
        public readonly IOdaService _odaService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public readonly ISliderService _sliderService;

        public IletisimController(ISosyalMedyaAdresService sosyalMedyaAdresService, IMenuService menuService, IIletisimAyarService iletisimAyarService, IFtpService ftpService, ISiteAyarService siteAyarService, ISayfaService sayfaService, ISliderService sliderService, IOdaService odaService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
            _menuService = menuService;
            _iletisimAyarService = iletisimAyarService;
            _ftpService = ftpService;
            _siteAyarService = siteAyarService;
            _sayfaService = sayfaService;
            _sliderService = sliderService;
            _odaService = odaService;
        }

        public async Task<IActionResult> Index()
        {

            var model = new AnasayfaViewModel();

            var sosyalMedyaAdreslerim = await _sosyalMedyaAdresService.GetAllAsync();
            var ftpBilgileri = await _ftpService.GetByIdAsync(1);
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);


            model.SosyalMedyaAdresler = sosyalMedyaAdreslerim;

            model.Ftp = ftpBilgileri;
            model.SiteAyar = siteAyar;
            model.IletisimAyar = iletisim;


            ViewData["Title"] = "İletişim";
            ViewData["Description"] = "Evon Otel İletişim";
            ViewData["Kelimeler"] = "";

            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Gonder(string AdSoyad, string Email, string Telefon, string Konu, string Mesaj)
        {
            try
            {
                // Mail bilgileri
                string alici = "info@3asosgb.com"; // Form mesajlarını almak istediğin e-posta adresi
                string konu = $"İletişim Formu: {Konu ?? "Konusuz"}";
                string icerik = $@"
                    <h3>Yeni İletişim Mesajı</h3>
                    <p><strong>Ad Soyad:</strong> {AdSoyad}</p>
                    <p><strong>E-posta:</strong> {Email}</p>
                    <p><strong>Telefon:</strong> {Telefon}</p>
                    <p><strong>Konu:</strong> {Konu}</p>
                    <p><strong>Mesaj:</strong><br>{Mesaj}</p>
                ";

                // SMTP ayarları
                var smtpClient = new SmtpClient("smtp.yandex.com") // veya smtp.gmail.com
                {
                    Port = 587,
                    Credentials = new NetworkCredential("no-reply@3asosgb.com", "fc263066K!"), 
                    EnableSsl = true
                };

                var mail = new MailMessage
                {
                    From = new MailAddress("no-reply@3asosgb.com", "3 AS OSGB İletişim"),
                    Subject = konu,
                    Body = icerik,
                    IsBodyHtml = true
                };
                mail.To.Add(alici);

                if (!string.IsNullOrWhiteSpace(Email))
                    mail.ReplyToList.Add(new MailAddress(Email));

                await smtpClient.SendMailAsync(mail);

                TempData["Success"] = "Mesajınız başarıyla gönderildi. En kısa sürede size dönüş yapılacaktır.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Mesaj gönderilirken bir hata oluştu: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}
