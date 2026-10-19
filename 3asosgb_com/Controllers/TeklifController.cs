using _3asosgb_com.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace _3asosgb_com.Controllers
{
    public class TeklifController : Controller
    {
        private readonly ISosyalMedyaAdresService _sosyalMedyaAdresService;
        private readonly IMenuService _menuService;
        private readonly IIletisimAyarService _iletisimAyarService;
        private readonly IFtpService _ftpService;
        private readonly ISiteAyarService _siteAyarService;
        private readonly ISayfaService _sayfaService;
        private readonly ISliderService _sliderService;
        private readonly IOdaService _odaService;

        public TeklifController(
            ISosyalMedyaAdresService sosyalMedyaAdresService,
            IMenuService menuService,
            IIletisimAyarService iletisimAyarService,
            IFtpService ftpService,
            ISiteAyarService siteAyarService,
            ISayfaService sayfaService,
            ISliderService sliderService,
            IOdaService odaService)
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

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TeklifGonder(string AdSoyad, string Email, string Telefon, string Hizmet, int? CalisanSayisi, string Mesaj)
        {
            try
            {
                string alici = "info@3asosgb.com";
                string konu = $"Teklif Formu: {Hizmet ?? "Genel Talep"}";

                string icerik = $@"
                    <h3>Yeni Teklif Talebi</h3>
                    <p><strong>Ad Soyad:</strong> {AdSoyad}</p>
                    <p><strong>E-posta:</strong> {Email}</p>
                    <p><strong>Telefon:</strong> {Telefon}</p>
                    <p><strong>Hizmet:</strong> {Hizmet}</p>
                    <p><strong>Çalışan Sayısı:</strong> {CalisanSayisi}</p>
                    <p><strong>Mesaj:</strong><br>{Mesaj}</p>
                ";

                var smtpClient = new SmtpClient("smtp.yandex.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("no-reply@3asosgb.com", "fc263066K!"),
                    EnableSsl = true
                };

                var mail = new MailMessage
                {
                    From = new MailAddress("no-reply@3asosgb.com", "3 AS OSGB Teklif"),
                    Subject = konu,
                    Body = icerik,
                    IsBodyHtml = true
                };
                mail.To.Add(alici);

                if (!string.IsNullOrWhiteSpace(Email))
                    mail.ReplyToList.Add(new MailAddress(Email));

                await smtpClient.SendMailAsync(mail);

                TempData["Success"] = "Teklif talebiniz başarıyla gönderildi. En kısa sürede sizinle iletişime geçilecektir.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Teklif gönderilirken bir hata oluştu: " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
