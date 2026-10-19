using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.WebUI.Controllers
{
    public class SSSController : Controller
    {
        ISSSService _sSSService;
        private readonly ISSSKategoriService _sSSKategoriService;

        private readonly ImageController _imageController;
        public SSSController(ISSSService sSSService, ImageController imageController, ISSSKategoriService sSSKategoriService)
        {
            _sSSService = sSSService;
            _imageController = imageController;
            _sSSKategoriService = sSSKategoriService;
        }
        public async Task<IActionResult> Index()
        {
            var sSSler = await _sSSService.GetAllAsync(query => query.Include(h => h.SSSKategori));
            SSSViewModel model = new SSSViewModel
            {
                SSSler = sSSler
            };
            return View(model);
        }


        [HttpGet]
        [Route("SSS/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SSSViewModel model = new SSSViewModel();
            var kategoriler = await _sSSKategoriService.GetAllAsync();  // Kategorileri async olarak çek

            var sSSler = await _sSSService.GetAllAsync();

            model.SSSKategoriList = kategoriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.KategoriAdi
            }).ToList();


            if (id == 0)
            {
                SSS sSS = new SSS
                {
                    Id = id,
                    Durum = true,
                    Sira = sSSler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.SSS = sSS;

                return View(model);
            }
            else
            {
                model.SSS = await _sSSService.GetByIdAsync(id);
                if (model.SSS == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SSSViewModel model)
        {
            if (ModelState.IsValid)
            {



                if (model.SSS.Id == 0)
                {
                    model.SSS.Ekleme = DateTime.Now;
                    await _sSSService.AddAsync(model.SSS);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sSSService.GetByIdAsync(model.SSS.Id);


                    model.SSS.Ekleme = oldEntity.Ekleme;
                    await _sSSService.UpdateAsync(model.SSS);
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

            var itemIsValid = await _sSSService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sSSService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}