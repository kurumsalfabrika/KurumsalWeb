using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class SMSAyarController : Controller
    {
        ISMSAyarService _smsAyarService;

        public SMSAyarController(ISMSAyarService smsAyarService)
        {
            _smsAyarService = smsAyarService;
        }
        public async Task<IActionResult> Index()
        {

            SMSAyarViewModel model = new SMSAyarViewModel();

            try
            {
                model.SMSAyar =await _smsAyarService.GetByIdAsync(1);
            }
            catch (Exception)
            {
                SMSAyar smsAyar = new SMSAyar
                {
                    Id = 0

                };
                model.SMSAyar = smsAyar;
            }

            return View(model);
        }


        public async Task<ActionResult> AddOrUpdate(int Id)
        {

            var smsAyarler =await _smsAyarService.GetAllAsync();

            SMSAyarViewModel model = new SMSAyarViewModel();
            model.SMSAyar =await _smsAyarService.GetByIdAsync(Id);
            model.SMSAyarlar = smsAyarler;
            if (model.SMSAyar == null)
            {
                SMSAyar smsAyar = new SMSAyar
                {
                    Id = 0

                };
                model.SMSAyar = smsAyar;
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SMSAyarViewModel model)
        {
          
                if (model.SMSAyar.Id == 0)
                {
                    model.SMSAyar.Ekleme = DateTime.Now;
                   await _smsAyarService.AddAsync(model.SMSAyar);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity =await _smsAyarService.GetByIdAsync(model.SMSAyar.Id);


                    model.SMSAyar.Ekleme = oldEntity.Ekleme;
                   await _smsAyarService.UpdateAsync(model.SMSAyar);
                    return RedirectToAction("Index");
                }
         
        }


        public JsonResult Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }

            var itemIsValid = _smsAyarService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                _smsAyarService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
