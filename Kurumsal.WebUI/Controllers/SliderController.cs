using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class SliderController : Controller
    {
        ISliderService _sliderService;
        private readonly ImageController _imageController;
        public SliderController(ISliderService sliderService, ImageController imageController)
        {
            _sliderService = sliderService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var sliderler = await _sliderService.GetAllAsync();
            SliderViewModel model = new SliderViewModel
            {
                Sliderlar = sliderler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Slider/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SliderViewModel model = new SliderViewModel();


            var sliderler = await _sliderService.GetAllAsync();


            if (id == 0)
            {
                Slider slider = new Slider
                {
                    Id = id,

                    Durum = true,
                    Sira = sliderler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Slider = slider;

                return View(model);
            }
            else
            {
                model.Slider = await _sliderService.GetByIdAsync(id);
                if (model.Slider == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SliderViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Slider.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Slider.OneCikanGorsel = imageUrl;
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


                if (model.Dosya1 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya1, model.Slider.OneCikanGorsel1);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Slider.OneCikanGorsel1 = imageUrl;
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

                if (model.Dosya2 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya2, model.Slider.OneCikanGorsel2);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Slider.OneCikanGorsel2 = imageUrl;
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


                if (model.Slider.Id == 0)
                {
                    model.Slider.Ekleme = DateTime.Now;
                    await _sliderService.AddAsync(model.Slider);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _sliderService.GetByIdAsync(model.Slider.Id);

                    if (model.Dosya == null)
                        model.Slider.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    if (model.Dosya1 == null)
                        model.Slider.OneCikanGorsel1 = oldEntity.OneCikanGorsel1;

                    if (model.Dosya2 == null)
                        model.Slider.OneCikanGorsel2 = oldEntity.OneCikanGorsel2;

                    model.Slider.Ekleme = oldEntity.Ekleme;
                    await _sliderService.UpdateAsync(model.Slider);
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

            var itemIsValid = await _sliderService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _sliderService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
