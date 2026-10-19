using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class SayfaController : Controller
    {
        private readonly ISayfaService _sayfaService;
        private readonly ISayfaKategoriService _sayfaKategoriService;
        private readonly ImageController _imageController;
        public SayfaController(ISayfaService sayfaService, ImageController imageController, ISayfaKategoriService sayfaKategoriService)
        {
            _sayfaService = sayfaService;
            _imageController = imageController;
            _sayfaKategoriService = sayfaKategoriService;
        }
        public async Task<IActionResult> Index()
        {
            var sayfaler = await _sayfaService.GetAllAsync(null, query => query.Include(h => h.SayfaKategori));
            SayfaViewModel model = new SayfaViewModel
            {
                Sayfalar = sayfaler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Sayfa/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SayfaViewModel model = new SayfaViewModel();
            var kategoriler = await _sayfaKategoriService.GetAllAsync();  // Kategorileri async olarak çek

            var sayfaler = await _sayfaService.GetAllAsync();

            model.SayfaKategoriList = kategoriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.KategoriAdi
            }).ToList();


            if (id == 0)
            {
                Sayfa sayfa = new Sayfa
                {
                    Id = id,
                    Durum = true,
                    Ekleme = DateTime.Now

                };
                model.Sayfa = sayfa;

                return View(model);
            }
            else
            {
                model.Sayfa = await _sayfaService.GetByIdAsync(id);
                if (model.Sayfa == null)
                {
                    return NotFound();
                }
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SayfaViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Sayfa.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Sayfa.OneCikanGorsel = imageUrl;
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

                if (model.Sayfa.Id == 0)
                {
                    model.Sayfa.Ekleme = DateTime.Now;
                    await _sayfaService.AddAsync(model.Sayfa);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sayfaService.GetByIdAsync(model.Sayfa.Id);

                    if (model.Dosya == null)
                        model.Sayfa.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Sayfa.Ekleme = oldEntity.Ekleme;
                    await _sayfaService.UpdateAsync(model.Sayfa);
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

            var itemIsValid = await _sayfaService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sayfaService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
