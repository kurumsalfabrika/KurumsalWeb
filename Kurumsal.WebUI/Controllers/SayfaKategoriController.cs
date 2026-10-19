using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Kurumsal.WebUI.Controllers
{

    public class SayfaKategoriController : Controller
    {
        ISayfaKategoriService _sayfaKategoriService;

        private readonly ImageController _imageController;
        public SayfaKategoriController(ISayfaKategoriService sayfaKategoriService, ImageController imageController)
        {
            _sayfaKategoriService = sayfaKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var sayfaKategoriler = await _sayfaKategoriService.GetAllAsync();
            SayfaKategoriViewModel model = new SayfaKategoriViewModel
            {
                SayfaKategoriler = sayfaKategoriler
            };
            return View(model);
        }

        [HttpGet]
        [Route("SayfaKategori/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SayfaKategoriViewModel model = new SayfaKategoriViewModel();

            var sayfaKategoriler = await _sayfaKategoriService.GetAllAsync();

            if (id == 0)
            {
                SayfaKategori sayfaKategori = new SayfaKategori
                {
                    Id = id,
                    Durum = true,
                    Sira = sayfaKategoriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.SayfaKategori = sayfaKategori;

                return View(model);
            }
            else
            {
                model.SayfaKategori = await _sayfaKategoriService.GetByIdAsync(id);
                if (model.SayfaKategori == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SayfaKategoriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.SayfaKategori.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SayfaKategori.OneCikanGorsel = imageUrl;
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


                if (model.SayfaKategori.Id == 0)
                {
                    model.SayfaKategori.Ekleme = DateTime.Now;
                    await _sayfaKategoriService.AddAsync(model.SayfaKategori);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sayfaKategoriService.GetByIdAsync(model.SayfaKategori.Id);

                    if (model.Dosya == null)
                        model.SayfaKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.SayfaKategori.Ekleme = oldEntity.Ekleme;
                    await _sayfaKategoriService.UpdateAsync(model.SayfaKategori);
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

            var itemIsValid = await _sayfaKategoriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sayfaKategoriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }
}
