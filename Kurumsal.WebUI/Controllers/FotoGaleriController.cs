using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class FotoGaleriController : Controller
    {

        private readonly IFotoGaleriService _fotoGaleriService;

        private readonly ImageController _imageController;
        public FotoGaleriController(IFotoGaleriService fotoGaleriService, ImageController imageController)
        {
            _fotoGaleriService = fotoGaleriService;
            _imageController = imageController;

        }
        public async Task<IActionResult> Index()
        {
            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();

            FotoGaleriViewModel model = new FotoGaleriViewModel
            {
                FotoGaleriler = fotoGaleriler
            };
            return View(model);
        }


        [HttpGet]
        [Route("FotoGaleri/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            FotoGaleriViewModel model = new FotoGaleriViewModel();


            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();


            if (id == 0)
            {
                FotoGaleri fotoGaleri = new FotoGaleri
                {
                    Id = id,
                    Durum = true,
                    Sira = fotoGaleriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.FotoGaleri = fotoGaleri;

                return View(model);
            }
            else
            {
                model.FotoGaleri = await _fotoGaleriService.GetByIdAsync(id);
                if (model.FotoGaleri == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(FotoGaleriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.FotoGaleri.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.FotoGaleri.OneCikanGorsel = imageUrl;
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


                if (model.FotoGaleri.Id == 0)
                {
                    model.FotoGaleri.Ekleme = DateTime.Now;
                    await _fotoGaleriService.AddAsync(model.FotoGaleri);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _fotoGaleriService.GetByIdAsync(model.FotoGaleri.Id);

                    if (model.Dosya == null)
                        model.FotoGaleri.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.FotoGaleri.Ekleme = oldEntity.Ekleme;
                    await _fotoGaleriService.UpdateAsync(model.FotoGaleri);
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

            var itemIsValid = await _fotoGaleriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _fotoGaleriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
