using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Kurumsal.WebUI.Controllers
{
    public class OdaKategoriController : Controller
    {
        IOdaKategoriService _haberKategoriService;

        private readonly ImageController _imageController;
        public OdaKategoriController(IOdaKategoriService haberKategoriService, ImageController imageController)
        {
            _haberKategoriService = haberKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var haberKategoriler = await _haberKategoriService.GetAllAsync();
            OdaKategoriViewModel model = new OdaKategoriViewModel
            {
                OdaKategoriler = haberKategoriler
            };
            return View(model);
        }

        [HttpGet]
        [Route("OdaKategori/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            OdaKategoriViewModel model = new OdaKategoriViewModel();

            var haberKategoriler = await _haberKategoriService.GetAllAsync();

            if (id == 0)
            {
                OdaKategori haberKategori = new OdaKategori
                {
                    Id = id,
                    Durum = true,
                    Sira = haberKategoriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.OdaKategori = haberKategori;

                return View(model);
            }
            else
            {
                model.OdaKategori = await _haberKategoriService.GetByIdAsync(id);
                if (model.OdaKategori == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(OdaKategoriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.OdaKategori.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.OdaKategori.OneCikanGorsel = imageUrl;
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


                if (model.OdaKategori.Id == 0)
                {
                    model.OdaKategori.Ekleme = DateTime.Now;
                    await _haberKategoriService.AddAsync(model.OdaKategori);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _haberKategoriService.GetByIdAsync(model.OdaKategori.Id);

                    if (model.Dosya == null)
                        model.OdaKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.OdaKategori.Ekleme = oldEntity.Ekleme;
                    await _haberKategoriService.UpdateAsync(model.OdaKategori);
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

            var itemIsValid = await _haberKategoriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _haberKategoriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }
}
