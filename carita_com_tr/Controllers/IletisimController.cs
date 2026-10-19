using carita_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace carita_com_tr.Controllers
{
    public class IletisimController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;


        public IletisimController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;

        }
        public async Task<IActionResult> Index()
        {
            IletisimViewModel model = new IletisimViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;



            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Gonder(string ad, string email, string telefon, string konu, string mesaj)
        {
            var recaptchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = "6LcYFvMrAAAAABSXOMh8m1C0PADYWQ2tz5pFxcyv"; // Google'dan aldığın secret key
            var httpClient = new HttpClient();

            var postData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("secret", secretKey),
        new KeyValuePair<string, string>("response", recaptchaResponse)
    });

            var response = await httpClient.PostAsync("https://www.google.com/recaptcha/api/siteverify", postData);
            var json = await response.Content.ReadAsStringAsync();

            if (!json.Contains("\"success\": true"))
            {
                TempData["Error"] = "reCAPTCHA doğrulaması başarısız oldu.";
                return RedirectToAction("Index");
            }

            try
            {
                string alici = "mustafa@karabenli.net, info@gokhaneraslan.com.tr";
                string subject = $"İletişim Formu: {konu ?? "Konusuz"}";

                string body = $@"
        <h3>Yeni İletişim Mesajı</h3>
        <p><strong>Ad Soyad:</strong> {ad}</p>
        <p><strong>E-posta:</strong> {email}</p>
        <p><strong>Telefon:</strong> {telefon}</p>
        <p><strong>Konu:</strong> {konu}</p>
        <p><strong>Mesaj:</strong><br>{mesaj}</p>
        ";

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("kayserilim@gmail.com", "mjldpinblbiixgez"),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("kayserilim@gmail.com", "Gökhan Eraslan İletişim"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(alici);

                if (!string.IsNullOrWhiteSpace(email))
                    mailMessage.ReplyToList.Add(new MailAddress(email));

                await smtpClient.SendMailAsync(mailMessage);

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
