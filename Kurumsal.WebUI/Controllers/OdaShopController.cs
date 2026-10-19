using Kurumsal.Business.Abstract;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class OdaShopController : Controller
    {
        private readonly IOdaKategoriService _odaKategoriService;
        private readonly IOdaService _odaService;
        readonly IFtpService _ftpService;
        private readonly ImageController _imageController;
        public OdaShopController(ImageController imageController, IOdaKategoriService odaKategoriService, IOdaService odaService, IFtpService ftpService)
        {
            _imageController = imageController;
            _odaKategoriService = odaKategoriService;
            _odaService = odaService;
            _ftpService = ftpService;
        }
        public async Task<IActionResult> Index()
        {
            var odalar = await _odaService.GetAllAsync(null, query => query.Include(h => h.OdaKategori));
            var ftp = await _ftpService.GetByIdAsync(1);
            OdaViewModel model = new OdaViewModel
            {
                Odalar = odalar,
                Ftp = ftp
            };
            return View(model);
        }
    }
}
