using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class RezervasyonController : Controller
    {
        IRezervasyonService _rezervasyonService;

        private readonly ImageController _imageController;
        public RezervasyonController(IRezervasyonService rezervasyonService, ImageController imageController)
        {
            _rezervasyonService = rezervasyonService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var rezervasyonlar = await _rezervasyonService.GetAllAsync();
            RezervasyonViewModel model = new RezervasyonViewModel
            {
                Rezervasyonlar = rezervasyonlar
            };
            return View(model);
        }

        [HttpGet]
        [Route("Rezervasyon/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            RezervasyonViewModel model = new RezervasyonViewModel();


            var rezervasyonlar = await _rezervasyonService.GetAllAsync();


            if (id == 0)
            {
                Rezervasyon rezervasyon = new Rezervasyon
                {
                    Id = id

                };
                model.Rezervasyon = rezervasyon;

                return View(model);
            }
            else
            {
                model.Rezervasyon = await _rezervasyonService.GetByIdAsync(id);
                if (model.Rezervasyon == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(RezervasyonViewModel model)
        {
            if (ModelState.IsValid)
            {





                if (model.Rezervasyon.Id == 0)
                {
                    model.Rezervasyon.Ekleme = DateTime.Now;
                    await _rezervasyonService.AddAsync(model.Rezervasyon);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _rezervasyonService.GetByIdAsync(model.Rezervasyon.Id);

                   
                    model.Rezervasyon.Ekleme = oldEntity.Ekleme;
                    await _rezervasyonService.UpdateAsync(model.Rezervasyon);
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

            var itemIsValid = await _rezervasyonService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
             await _rezervasyonService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
