using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ufukbacatemizleme_com_tr.Models;

namespace ufukbacatemizleme_com_tr.Controllers
{
    public class HomeController : Controller
    {
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        public readonly IIletisimAyarService _iletisimAyarService;
        public readonly IMenuService _menuService;
        public readonly ISliderService _sliderService;
        public readonly IReferansService _referansService;

        public HomeController(ISiteAyarService siteAyarService, IFtpService ftpService, IIletisimAyarService iletisimAyarService, IMenuService menuService, ISliderService sliderService, IReferansService referansService)
        {
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
            _iletisimAyarService = iletisimAyarService;
            _menuService = menuService;
            _sliderService = sliderService;
            _referansService = referansService;
        }

        public async  Task<IActionResult> Index()
        {
            GenelViewModel model = new GenelViewModel();

            model.Sliderlar=await _sliderService.GetAllAsync();
            model.SiteAyar = await _siteAyarService.GetByIdAsync(1);
            model.Ftp = await _ftpService.GetByIdAsync(1);
            model.Referanslar = await _referansService.GetAllAsync();

            return View(model);
        }



    }
}
