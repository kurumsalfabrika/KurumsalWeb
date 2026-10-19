using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class HaberKategoriController : Controller
    {
        IHaberKategoriService _haberKategoriService;

        private readonly ImageController _imageController;
        public HaberKategoriController(IHaberKategoriService haberKategoriService, ImageController imageController)
        {
            _haberKategoriService = haberKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var haberKategoriler = await _haberKategoriService.GetAllAsync();
            HaberKategoriViewModel model = new HaberKategoriViewModel
            {
                HaberKategoriler = haberKategoriler
            };
            return View(model);
        }

        [HttpGet]
        [Route("HaberKategori/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            HaberKategoriViewModel model = new HaberKategoriViewModel();

            var haberKategoriler = await _haberKategoriService.GetAllAsync();

            if (id == 0)
            {
                HaberKategori haberKategori = new HaberKategori
                {
                    Id = id,
                    Durum = true,
                    Sira = haberKategoriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.HaberKategori = haberKategori;

                return View(model);
            }
            else
            {
                model.HaberKategori = await _haberKategoriService.GetByIdAsync(id);
                if (model.HaberKategori == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(HaberKategoriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.HaberKategori.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.HaberKategori.OneCikanGorsel = imageUrl;
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


                if (model.HaberKategori.Id == 0)
                {
                    model.HaberKategori.Ekleme = DateTime.Now;
                    await _haberKategoriService.AddAsync(model.HaberKategori);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _haberKategoriService.GetByIdAsync(model.HaberKategori.Id);

                    if (model.Dosya == null)
                        model.HaberKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.HaberKategori.Ekleme = oldEntity.Ekleme;
                    await _haberKategoriService.UpdateAsync(model.HaberKategori);
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
