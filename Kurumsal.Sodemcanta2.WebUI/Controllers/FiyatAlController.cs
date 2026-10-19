
﻿using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.Sodemcanta2.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.Sodemcanta2.WebUI.Controllers
{
    public class FiyatAlController : Controller
    {
        private readonly ISiteAyarService _siteAyarService;
        private readonly IFtpService _ftpService;
        private readonly IIletisimAyarService _iletisimAyarService;

        public FiyatAlController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
        }

        public async Task<IActionResult> Index()
        {
            FiyatAlViewModel model = new FiyatAlViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;

            FiyatAl fiyatAl = new FiyatAl();
            fiyatAl.Id = Guid.NewGuid();

            model.FiyatAl = fiyatAl;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }

        public async Task<IActionResult> FiyatAl2(int id)
        {
            FiyatAlViewModel model = new FiyatAlViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;
            var iletisim = await _iletisimAyarService.GetByAsync(x => x.Varsayilan == true);
            model.IletisimAyar = iletisim;

            FiyatAl fiyatAl = new FiyatAl();
            fiyatAl.Id = Guid.NewGuid();
            fiyatAl.SecilenResim =id.ToString();

            model.FiyatAl = fiyatAl;

            ViewData["Title"] = siteAyar.SiteAdi;
            return View(model);
        }


    }
}
