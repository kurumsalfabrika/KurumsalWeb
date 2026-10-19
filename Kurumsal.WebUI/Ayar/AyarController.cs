using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Ayar
{
    public class AyarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   


        public IActionResult Genel()
        {
            return View();
        }
    }

}
