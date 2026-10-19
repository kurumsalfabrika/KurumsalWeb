using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class FtpController : Controller
    {
        IFtpService _ftpService;

        public FtpController(IFtpService ftpService)
        {
            _ftpService = ftpService;
        }
        public async Task<IActionResult> Index()
        {
            var ftp = await _ftpService.GetByIdAsync(1);
            Ftp ftpModel = new Ftp();

            if (ftp == null)
            {
                ftpModel.Id = 1;
                return View(ftpModel);
            }
            else
            {
                ftpModel = ftp;
                return View(ftpModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(Ftp model)
        {
            if (ModelState.IsValid)
            {
                var ftp = await _ftpService.GetByIdAsync(1);

                if(ftp == null)
                {
                    await _ftpService.AddAsync(model);
                }
                else
                {
                    if (model.Password == null)
                    {
                        var oldModel = await _ftpService.GetByIdAsync(model.Id);
                        model.Password = oldModel.Password;
                    }
                    await _ftpService.UpdateAsync(model);
                }
                return Json(new { success = true, message = "İşlem başarılı!" });
            }
            return Json(new { success = false, message = "Form verileri geçersiz!" });
        }
    }
}
