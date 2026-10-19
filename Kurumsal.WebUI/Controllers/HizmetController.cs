using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class HizmetController : Controller
    {
        IHizmetService _hizmetService;
        private readonly ImageController _imageController;
        public HizmetController(IHizmetService hizmetService, ImageController imageController)
        {
            _hizmetService = hizmetService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var hizmetler = await _hizmetService.GetAllAsync();
            HizmetViewModel model = new HizmetViewModel
            {
                Hizmetler = hizmetler
            };
            return View(model);
        }



        [HttpGet]
        [Route("Hizmet/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {


            HizmetViewModel model = new HizmetViewModel();

            var hizmetler = await _hizmetService.GetAllAsync();

            if (id == 0)
            {
                Hizmet hizmet = new Hizmet
                {
                    Id = id,
                    Durum = true,
                    Sira = hizmetler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Hizmet = hizmet;

                return View(model);
            }
            else
            {
                model.Hizmet = await _hizmetService.GetByIdAsync(id);
                if (model.Hizmet == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(HizmetViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Hizmet.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Hizmet.OneCikanGorsel = imageUrl;
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


                if (model.Hizmet.Id == 0)
                {
                    model.Hizmet.Ekleme = DateTime.Now;
                    await _hizmetService.AddAsync(model.Hizmet);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _hizmetService.GetByIdAsync(model.Hizmet.Id);

                    if (model.Dosya == null)
                        model.Hizmet.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Hizmet.Ekleme = oldEntity.Ekleme;
                    await _hizmetService.UpdateAsync(model.Hizmet);
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

            var itemIsValid = await _hizmetService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _hizmetService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }



    }
}
