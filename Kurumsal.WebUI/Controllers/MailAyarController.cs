using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class MailAyarController : Controller
    {
        IMailAyarService _mailAyarService;

        public MailAyarController(IMailAyarService mailAyarService)
        {
            _mailAyarService = mailAyarService;
        }
        public async Task<IActionResult> Index()
        {
            var mailAyarlar = await _mailAyarService.GetByIdAsync(1);
            MailAyar mailAyarModel = new MailAyar();

            if (mailAyarlar == null)
            {
                mailAyarModel.Id = 1;
                return View(mailAyarModel);
            }
            else
            {
                mailAyarModel = mailAyarlar;
                return View(mailAyarModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(MailAyar model)
        {
            if (ModelState.IsValid)
            {
                var mailAyar = await _mailAyarService.GetByIdAsync(1);
                bool isAdded = false;
                if (mailAyar == null)
                {
                    await _mailAyarService.AddAsync(model);
                    isAdded = true;
                }
                else
                {
                    if (model.SMTPEpostaSifre == null)
                    {
                        var oldModel = await _mailAyarService.GetByIdAsync(model.Id);
                        model.SMTPEpostaSifre = oldModel.SMTPEpostaSifre;
                    }
                    await _mailAyarService.UpdateAsync(model);
                }
                return Json(new { success = true, message = isAdded ? "Ekleme işlemi başarılı!" : "Güncelleme işlemi başarılı!" });
            }
            return Json(new { success = false, message = "Form verileri geçersiz!" });
        }
    }
}