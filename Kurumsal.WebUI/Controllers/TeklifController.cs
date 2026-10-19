using Kurumsal.Business.Abstract;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Kurumsal.Entities.Concrete;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.WebUI.Controllers
{
	public class TeklifController : Controller
    {
        ITeklifService _teklifService;
        private readonly ImageController _imageController;
        public TeklifController(ITeklifService teklifService, ImageController imageController)
        {
            _teklifService = teklifService;
            _imageController = imageController;
          
        }
        public async Task<IActionResult> Index()
        {
            var teklifler = await _teklifService.GetAllAsync();
 
            TeklifViewModel model = new TeklifViewModel
            {
                Teklifler = teklifler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Teklif/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            TeklifViewModel model = new TeklifViewModel();


            var teklifler = await _teklifService.GetAllAsync();

 

            if (id == 0)
            {
                Teklif teklif = new Teklif
                {
                    Id = id,
                    Durum = true,
                    Ekleme = DateTime.Now

                };
                model.Teklif = teklif;

                return View(model);
            }
            else
            {
                model.Teklif = await _teklifService.GetByIdAsync(id);
                if (model.Teklif == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(TeklifViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Teklif.Id == 0)
                {
                    model.Teklif.Ekleme = DateTime.Now;
                    await _teklifService.AddAsync(model.Teklif);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _teklifService.GetByIdAsync(model.Teklif.Id);
                    model.Teklif.Ekleme = oldEntity.Ekleme;
                    await _teklifService.UpdateAsync(model.Teklif);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public async Task<JsonResult> Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }

            var itemIsValid = await _teklifService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _teklifService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
