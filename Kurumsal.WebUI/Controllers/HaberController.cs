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
    public class HaberController : Controller
    {
        IHaberService _haberService;
        private readonly IHaberKategoriService _haberKategoriService;
        private readonly IOdaService _odaService;

        private readonly ImageController _imageController;
        public HaberController(IHaberService haberService, ImageController imageController, IHaberKategoriService haberKategoriService, IOdaService odaService)
        {
            _haberService = haberService;
            _imageController = imageController;
            _haberKategoriService = haberKategoriService;
            _odaService = odaService;
        }
        public async Task<IActionResult> Index()
        {
            var haberler = await _haberService.GetAllAsync(query => query.Include(h => h.HaberKategori));
 
            HaberViewModel model = new HaberViewModel
            {
                Haberler = haberler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Haber/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            HaberViewModel model = new HaberViewModel();
            var kategoriler = await _haberKategoriService.GetAllAsync();  // Kategorileri async olarak çek

            var haberler = await _haberService.GetAllAsync();

            model.HaberKategoriList = kategoriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.KategoriAdi
            }).ToList();


            if (id == 0)
            {
                Haber haber = new Haber
                {
                    Id = id,
                    YayinTarihi = DateTime.Now,
                    AnaSayfadaGoster = true,
                    Durum = true,
                    Sira = haberler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Haber = haber;

                return View(model);
            }
            else
            {
                model.Haber = await _haberService.GetByIdAsync(id);
                if (model.Haber == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(HaberViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Haber.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Haber.OneCikanGorsel = imageUrl;
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


                if (model.Haber.Id == 0)
                {
                    model.Haber.Ekleme = DateTime.Now;
                    await _haberService.AddAsync(model.Haber);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _haberService.GetByIdAsync(model.Haber.Id);

                    if (model.Dosya == null)
                        model.Haber.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Haber.Ekleme = oldEntity.Ekleme;
                    await _haberService.UpdateAsync(model.Haber);
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

            var itemIsValid = await _haberService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _haberService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
