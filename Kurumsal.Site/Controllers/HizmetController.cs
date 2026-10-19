using Kurumsal.Business.Abstract;
using Kurumsal.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.Site.Controllers
{
    public class HizmetController : Controller
    {
        private readonly IHizmetService _hizmetService;
        public HizmetController(IHizmetService hizmetService)
        {
            _hizmetService = hizmetService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detay(int id)
        {
            HomeViewModel model = new HomeViewModel();
            // Slug ve ID kullanarak veritabanından ilgili verileri çekme işlemi
            var hizmet = await _hizmetService.GetByIdAsync(id);

            model.Hizmet = hizmet;
            if (hizmet == null)
            {
                return NotFound();
            }

            return View(model);
        }

    }
}
