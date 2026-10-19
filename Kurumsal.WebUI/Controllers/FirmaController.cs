using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class FirmaController : Controller
    {
        IFirmaService _firmaService;

        private readonly ImageController _imageController;
        public FirmaController(IFirmaService firmaService, ImageController imageController)
        {
            _firmaService = firmaService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var firmalar = await _firmaService.GetAllAsync();
            FirmaViewModel model = new FirmaViewModel
            {
                Firmalar = firmalar
            };
            return View(model);
        }


        [HttpGet]
        [Route("Firma/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {


            FirmaViewModel model = new FirmaViewModel();

            var firmalar = await _firmaService.GetAllAsync();

            if (id == 0)
            {
                Firma firma = new Firma
                {
                    Id = id,
                   BaslamaTarihi =DateTime.Now,
                   BitisTarihi = DateTime.Now.AddYears(1),
                    AnaSayfadaGoster = true,
                    Durum = true,
                    Ekleme = DateTime.Now

                };
                model.Firma = firma;

                return View(model);
            }
            else
            {
                model.Firma = await _firmaService.GetByIdAsync(id);
                if (model.Firma == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(FirmaViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Firma.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Firma.OneCikanGorsel = imageUrl;
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

                if (model.Firma.Id == 0)
                {
                    model.Firma.Ekleme = DateTime.Now;
                    await _firmaService.AddAsync(model.Firma);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _firmaService.GetByIdAsync(model.Firma.Id);

                    if (model.Dosya == null)
                        model.Firma.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Firma.Ekleme = oldEntity.Ekleme;
                    await _firmaService.UpdateAsync(model.Firma);
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

            var itemIsValid = await _firmaService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _firmaService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }
}
