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
    public class YorumController : Controller
    {
        IYorumService _yorumService;

        private readonly IOdaService _odaService;

        private readonly ImageController _imageController;
        public YorumController(IYorumService yorumService, ImageController imageController, IOdaService odaService)
        {
            _yorumService = yorumService;
            _imageController = imageController;
   
            _odaService = odaService;
        }
        public async Task<IActionResult> Index()
        {
            var yorumler = await _yorumService.GetAllAsync();
 
            YorumViewModel model = new YorumViewModel
            {
                Yorumlar = yorumler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Yorum/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            YorumViewModel model = new YorumViewModel();

            var yorumler = await _yorumService.GetAllAsync();

 

            if (id == 0)
            {
                Yorum yorum = new Yorum
                {
                    Id = id,
                    YayinTarihi = DateTime.Now,
          
                    Durum = true,
                    Sira = yorumler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Yorum = yorum;

                return View(model);
            }
            else
            {
                model.Yorum = await _yorumService.GetByIdAsync(id);
                if (model.Yorum == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(YorumViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Yorum.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Yorum.OneCikanGorsel = imageUrl;
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


                if (model.Yorum.Id == 0)
                {
                    model.Yorum.Ekleme = DateTime.Now;
                    await _yorumService.AddAsync(model.Yorum);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _yorumService.GetByIdAsync(model.Yorum.Id);

                    if (model.Dosya == null)
                        model.Yorum.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Yorum.Ekleme = oldEntity.Ekleme;
                    await _yorumService.UpdateAsync(model.Yorum);
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

            var itemIsValid = await _yorumService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _yorumService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
