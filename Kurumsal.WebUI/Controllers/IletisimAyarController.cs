using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class IletisimAyarController : Controller
    {
        IIletisimAyarService _iletisimAyarService;


        private readonly ImageController _imageController;
        public IletisimAyarController(IIletisimAyarService iletisimAyarService, ImageController imageController)
        {
            _iletisimAyarService = iletisimAyarService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var iletisimAyarler = await _iletisimAyarService.GetListAsync();
            IletisimAyarViewModel model = new IletisimAyarViewModel
            {
                IletisimAyarlar = iletisimAyarler
            };
            return View(model);
        }


        [HttpGet]
        [Route("IletisimAyar/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            IletisimAyarViewModel model = new IletisimAyarViewModel();


            var iletisimAyarler = await _iletisimAyarService.GetListAsync();

  
            if (id == 0)
            {
                IletisimAyar iletisimAyar = new IletisimAyar
                {
                    Id = id,
                    Varsayilan = false,
                    Sira = iletisimAyarler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.IletisimAyar = iletisimAyar;

                return View(model);
            }
            else
            {
                model.IletisimAyar = await _iletisimAyarService.GetByIdAsync(id);
                if (model.IletisimAyar == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(IletisimAyarViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.IletisimAyar.Id == 0)
                {
                    model.IletisimAyar.Ekleme = DateTime.Now;
                    await _iletisimAyarService.AddAsync(model.IletisimAyar);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _iletisimAyarService.GetByIdAsync(model.IletisimAyar.Id);
                    model.IletisimAyar.Ekleme = oldEntity.Ekleme;
                    await _iletisimAyarService.UpdateAsync(model.IletisimAyar);
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

            var itemIsValid = await _iletisimAyarService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _iletisimAyarService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
