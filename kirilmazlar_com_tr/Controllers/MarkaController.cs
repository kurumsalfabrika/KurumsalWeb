using kirilmazlar_com_tr.Models;
using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace kirilmazlar_com_tr.Controllers
{
    public class MarkaController : Controller
    {


        public readonly IMarkaService _markaService;
        public readonly IFtpService _ftpService;

        public MarkaController(IFtpService ftpService, IMarkaService markaService)
        {
            _ftpService = ftpService;

            _markaService = markaService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new MarkaViewModel();

            var ftpBilgileri = await _ftpService.GetByIdAsync(1);

            model.Ftp = ftpBilgileri;

            var markalar = await _markaService.GetAllAsync();
 
            model.Markalar = markalar;
            return View(model);
        }
    }
}
