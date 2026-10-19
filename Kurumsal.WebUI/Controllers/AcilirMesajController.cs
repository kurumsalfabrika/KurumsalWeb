using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class AcilirMesajController : Controller
    {
        readonly IAcilirMesajService _acilirMesajService;
        public AcilirMesajController(IAcilirMesajService acilirMesajService)
        {
            _acilirMesajService = acilirMesajService;
        }
        public async Task<IActionResult> Index()
        {
            AcilirMesajViewModel model = new();
            try
            {
                model.AcilirMesaj = await _acilirMesajService.GetByIdAsync(1);
            }
            catch (Exception)
            {
                AcilirMesaj acilirMesaj = new()
                {
                    Id = 0

                };
                model.AcilirMesaj = acilirMesaj;
            }

            return View(model);
        }


        public async Task<ActionResult> AddOrUpdate(int Id)
        {

            var acilirMesajler = _acilirMesajService.GetAllAsync();

            AcilirMesajViewModel model = new();
            model.AcilirMesaj = await _acilirMesajService.GetByIdAsync(Id);
            model.AcilirMesajlar = await acilirMesajler;
            if (model.AcilirMesaj == null)
            {
                AcilirMesaj acilirMesaj = new AcilirMesaj
                {
                    Id = 0

                };
                model.AcilirMesaj = acilirMesaj;
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(AcilirMesajViewModel model)
        {
          
                if (model.AcilirMesaj.Id == 0)
                {
                    model.AcilirMesaj.Ekleme = DateTime.Now;
                    await _acilirMesajService.AddAsync(model.AcilirMesaj);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _acilirMesajService.GetByIdAsync(model.AcilirMesaj.Id);


                    model.AcilirMesaj.Ekleme = oldEntity.Ekleme;
                    await _acilirMesajService.UpdateAsync(model.AcilirMesaj);
                    return RedirectToAction("Index");
                }
         
        }


        public JsonResult Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }

            var itemIsValid = _acilirMesajService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                _acilirMesajService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
