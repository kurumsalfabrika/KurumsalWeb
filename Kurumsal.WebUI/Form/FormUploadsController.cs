using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Form
{
    public class FormUploadsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
