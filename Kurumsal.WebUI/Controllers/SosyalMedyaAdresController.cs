using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class SosyalMedyaAdresController : Controller
    {
        ISosyalMedyaAdresService _sosyalMedyaAdresService;
        public SosyalMedyaAdresController(ISosyalMedyaAdresService sosyalMedyaAdresService)
        {
            _sosyalMedyaAdresService = sosyalMedyaAdresService;
        }
        public async Task<IActionResult> Index()
        {
            var adresler = await _sosyalMedyaAdresService.GetAllAsync();
            SosyalMedyaAdresViewModel model = new SosyalMedyaAdresViewModel
            {
                SosyalMedyaAdresler = adresler
            };
            return View(model);
        }


        [HttpGet]
        [Route("SosyalMedyaAdres/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SosyalMedyaAdresViewModel model = new SosyalMedyaAdresViewModel();


            var sosyalMedyaAdresler = await _sosyalMedyaAdresService.GetAllAsync();

            if (id == 0)
            {
                SosyalMedyaAdres sosyalMedyaAdres = new SosyalMedyaAdres
                {
                    Id = id,
                    Durum = true,
                    Sira = sosyalMedyaAdresler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.SosyalMedyaAdres = sosyalMedyaAdres;

                return View(model);
            }
            else
            {
                model.SosyalMedyaAdres = await _sosyalMedyaAdresService.GetByIdAsync(id);
                if (model.SosyalMedyaAdres == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SosyalMedyaAdresViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.SosyalMedyaAdres.Id == 0)
                {
                    model.SosyalMedyaAdres.Ekleme = DateTime.Now;
                    await _sosyalMedyaAdresService.AddAsync(model.SosyalMedyaAdres);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sosyalMedyaAdresService.GetByIdAsync(model.SosyalMedyaAdres.Id);
                    model.SosyalMedyaAdres.Ekleme = oldEntity.Ekleme;
                    await _sosyalMedyaAdresService.UpdateAsync(model.SosyalMedyaAdres);
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

            var itemIsValid = await _sosyalMedyaAdresService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sosyalMedyaAdresService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}