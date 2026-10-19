using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Kurumsal.WebUI.TagHelpers;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class ReferansController : Controller
    {
        IReferansService _referansService;

        private readonly ImageController _imageController;
        public ReferansController(IReferansService referansService, ImageController imageController)
        {
            _referansService = referansService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var referanslar = await _referansService.GetAllAsync();
            ReferansViewModel model = new ReferansViewModel
            {
                Referanslar = referanslar
            };
            return View(model);
        }



        [HttpGet]
        [Route("Referans/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            ReferansViewModel model = new ReferansViewModel();


            var referanslar = await _referansService.GetAllAsync();


            if (id == 0)
            {
                Referans referans = new Referans
                {
                    Id = id,
                    Sira = referanslar.Count + 1,

                };
                model.Referans = referans;

                return View(model);
            }
            else
            {
                model.Referans = await _referansService.GetByIdAsync(id);
                if (model.Referans == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(ReferansViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Referans.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Referans.OneCikanGorsel = imageUrl;
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


                if (model.Referans.Id == 0)
                {
                    model.Referans.Ekleme = DateTime.Now;
                    await _referansService.AddAsync(model.Referans);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _referansService.GetByIdAsync(model.Referans.Id);

                    if (model.Dosya == null)
                        model.Referans.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Referans.Ekleme = oldEntity.Ekleme;
                    await _referansService.UpdateAsync(model.Referans);
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

            var itemIsValid = await _referansService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _referansService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
