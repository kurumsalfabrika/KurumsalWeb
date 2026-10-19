using Kurumsal.Business.Abstract;
using Kurumsal.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Site.Controllers
{
    public class HomeController : Controller
    {
        readonly ISliderService _sliderService;
        readonly IHizmetService _hizmetService;
        readonly IReferansService _referansService;
        readonly IPortfolyoService _portfolyoService;
        readonly IFtpService _ftpService;

        public HomeController(ISliderService sliderService, IFtpService ftpService, IHizmetService hizmetService, IReferansService referansService, IPortfolyoService portfolyoService)
        {
            _sliderService = sliderService;
            _ftpService = ftpService;
            _hizmetService = hizmetService;
            _referansService = referansService;
            _portfolyoService = portfolyoService;
        }

        public async Task<IActionResult> Index()
        {

            var sliderlar = await _sliderService.GetAllAsync();
            var hizmetler = await _hizmetService.GetAllAsync();
            var referanslar = await _referansService.GetAllAsync();
            var portfolyolar = await _portfolyoService.GetAllAsync();
            var ftp = await _ftpService.GetByIdAsync(1);
       
            HomeViewModel viewModel = new HomeViewModel();

            viewModel.Sliderler = sliderlar;
            viewModel.Hizmetler = hizmetler;
            viewModel.Referanslar = referanslar;
            viewModel.Portfolyolar = portfolyolar;
            viewModel.Ftp = ftp;

            return View(viewModel);
        }



    }
}
