using Kurumsal.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace kirilmazlar_com_tr.Controllers
{
    public class PazarAgiController : Controller
    {

        public readonly IFtpService _ftpService;

        public PazarAgiController(IFtpService ftpService)
        {
            _ftpService = ftpService;

        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
