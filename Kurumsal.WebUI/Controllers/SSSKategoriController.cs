using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Kurumsal.WebUI.Controllers
{
    public class SSSKategoriController : Controller
    {
        ISSSKategoriService _sSSKategoriService;

        private readonly ImageController _imageController;
        public SSSKategoriController(ISSSKategoriService sSSKategoriService, ImageController imageController)
        {
            _sSSKategoriService = sSSKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var sSSKategoriler = await _sSSKategoriService.GetAllAsync();
            SSSKategoriViewModel model = new SSSKategoriViewModel
            {
                SSSKategoriler = sSSKategoriler
            };
            return View(model);
        }

        [HttpGet]
        [Route("SSSKategori/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SSSKategoriViewModel model = new SSSKategoriViewModel();

            var sSSKategoriler = await _sSSKategoriService.GetAllAsync();

            if (id == 0)
            {
                SSSKategori sSSKategori = new SSSKategori
                {
                    Id = id,
                    Durum = true,
                    Sira = sSSKategoriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.SSSKategori = sSSKategori;

                return View(model);
            }
            else
            {
                model.SSSKategori = await _sSSKategoriService.GetByIdAsync(id);
                if (model.SSSKategori == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SSSKategoriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.SSSKategori.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SSSKategori.OneCikanGorsel = imageUrl;
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


                if (model.SSSKategori.Id == 0)
                {
                    model.SSSKategori.Ekleme = DateTime.Now;
                    await _sSSKategoriService.AddAsync(model.SSSKategori);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sSSKategoriService.GetByIdAsync(model.SSSKategori.Id);

                    if (model.Dosya == null)
                        model.SSSKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.SSSKategori.Ekleme = oldEntity.Ekleme;
                    await _sSSKategoriService.UpdateAsync(model.SSSKategori);
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

            var itemIsValid = await _sSSKategoriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sSSKategoriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }
}
