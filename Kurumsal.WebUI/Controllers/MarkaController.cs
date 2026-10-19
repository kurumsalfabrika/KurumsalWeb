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
    public class MarkaController : Controller
    {
        IMarkaService _markaService;

        private readonly ImageController _imageController;
        public MarkaController(IMarkaService markaService, ImageController imageController)
        {
            _markaService = markaService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var markalar = await _markaService.GetAllAsync();
 
            MarkaViewModel model = new MarkaViewModel
            {
                Markalar = markalar
            };
            return View(model);
        }


        [HttpGet]
        [Route("Marka/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            MarkaViewModel model = new MarkaViewModel();
            var markaler = await _markaService.GetAllAsync();

            if (id == 0)
            {
                Marka marka = new Marka
                {
                    Id = id,

                    Durum = true,
                    MarkaSira = markaler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Marka = marka;

                return View(model);
            }
            else
            {
                model.Marka = await _markaService.GetByIdAsync(id);
                if (model.Marka == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(MarkaViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Marka.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Marka.OneCikanGorsel = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Dosya yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }

                }


                if (model.Marka.Id == 0)
                {
                    model.Marka.Ekleme = DateTime.Now;
                    await _markaService.AddAsync(model.Marka);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _markaService.GetByIdAsync(model.Marka.Id);

                    if (model.Dosya == null)
                        model.Marka.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Marka.Ekleme = oldEntity.Ekleme;
                    await _markaService.UpdateAsync(model.Marka);
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

            var itemIsValid = await _markaService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _markaService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
