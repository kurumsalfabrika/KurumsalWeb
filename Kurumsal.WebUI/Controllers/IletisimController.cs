using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
	public class IletisimController : Controller
    {
		IIletisimService _iletisimService;

        private readonly ImageController _imageController;
        public IletisimController(IIletisimService iletisimService, ImageController imageController)
        {
            _iletisimService = iletisimService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var iletisimler = await _iletisimService.GetAllAsync();
            IletisimViewModel model = new IletisimViewModel
            {
                Iletisimler = iletisimler
			};
            return View(model);
        }




        [HttpGet]
        [Route("Iletisim/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {


            IletisimViewModel model = new IletisimViewModel();

            var iletisimlar = await _iletisimService.GetAllAsync();

            if (id == 0)
            {
                Iletisim iletisim = new Iletisim
                {
                    Id = id,
                    Ekleme = DateTime.Now

                };
                model.Iletisim = iletisim;

                return View(model);
            }
            else
            {
                model.Iletisim = await _iletisimService.GetByIdAsync(id);
                if (model.Iletisim == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(IletisimViewModel model)
        {
            if (ModelState.IsValid)
            {



                if (model.Iletisim.Id == 0)
                {
                    model.Iletisim.Ekleme = DateTime.Now;
                    await _iletisimService.AddAsync(model.Iletisim);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _iletisimService.GetByIdAsync(model.Iletisim.Id);


                    model.Iletisim.Ekleme = oldEntity.Ekleme;
                    await _iletisimService.UpdateAsync(model.Iletisim);
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

            var itemIsValid = await _iletisimService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _iletisimService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
