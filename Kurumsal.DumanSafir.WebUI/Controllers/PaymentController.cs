using Kurumsal.DumanSafir.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace Kurumsal.DumanSafir.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult PaymentFail()
        {
     

            return View();
        }
        public IActionResult PaymentSuccess()
        {
     

            return View();
        }
        
        public IActionResult Index()
        {
            var model = new PaymentModel
            {
                ClientId = "133333333",
                Amount = "9.95",
                Oid = "siparisno",
                OkUrl = "http://www.example.com/3d/odemesayfasi3dhosting.aspx",
                FailUrl = "http://www.example.com/3d/odemesayfasi3dhosting.aspx",
                Rnd = DateTime.Now.ToString(),
                StoreKey = "123456",
                FirmaAdi = "Benim Firmam",
                Fismi = "is",
                FaturaFirma = "faturaFirma",
                Fadres = "XXX",
                Fadres2 = "XXX",
                Fil = "XXX",
                Filce = "XXX",
                Fpostakodu = "postakod93013",
                Tel = "XXX",
                Fulkekod = "tr",
                NakliyeFirma = "na fi",
                Tismi = "XXX",
                Tadres = "XXX",
                Tadres2 = "XXX",
                Til = "XXX",
                Tilce = "XXX",
                Tpostakodu = "ttt postakod93013",
                Tulkekod = "usa",
                ItemNumber1 = "a1",
                ProductCode1 = "a2",
                Qty1 = "3",
                Desc1 = "a4 desc",
                Id1 = "a5",
                Price1 = "6.25",
                Total1 = "7.50"
            };

            model.Hash = CreateHash(model);
            return View(model);
        }

        private string CreateHash(PaymentModel model)
        {
            var hashStr = $"{model.ClientId}{model.Oid}{model.Amount}{model.OkUrl}{model.FailUrl}{model.IslemTipi}{model.Taksit}{model.Rnd}{model.StoreKey}";
            using (var sha = SHA1.Create())
            {
                var hashBytes = Encoding.UTF8.GetBytes(hashStr);
                var inputBytes = sha.ComputeHash(hashBytes);
                return Convert.ToBase64String(inputBytes);
            }
        }
    }
}