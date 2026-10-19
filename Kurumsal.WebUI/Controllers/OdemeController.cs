using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Kurumsal.WebUI.Controllers
{
    public class OdemeController : Controller
    {
        public IActionResult Index()
        {

            OdemeViewModel model = new OdemeViewModel();
            model.Clientid = "500300000";
            model.amount = 9.95m;
            model.Oid = "SPRS0001";
            model.OkUrl = "https://www.kurumsalfabrika.com.tr/Success";
            model.FailUrl = "https://www.kurumsalfabrika.com.tr/Fail";
            model.Rnd = DateTime.Now.ToString();
            model.Taksit = "1";
            model.Islemtipi = "Auth";
            model.Storekey = "123456";
            model.Hashstr = model.Clientid.ToString() + model.Oid.ToString() + model.amount.ToString() + model.OkUrl.ToString() + model.FailUrl.ToString() + model.Islemtipi.ToString() + model.Taksit.ToString() + model.Rnd.ToString() + model.Storekey.ToString();


            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] hashbytes = System.Text.Encoding.GetEncoding("ISO-8859-9").GetBytes(model.Hashstr);
            byte[] inputbytes = sha.ComputeHash(hashbytes);
            String hash = Convert.ToBase64String(inputbytes);

            return View(model);
        }
    }
}
