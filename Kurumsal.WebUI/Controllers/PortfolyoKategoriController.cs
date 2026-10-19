using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Kurumsal.WebUI.Controllers
{
    public class PortfolyoKategoriController : Controller
    {
        IPortfolyoKategoriService _portfolyoKategoriService;

        private readonly ImageController _imageController;
        public PortfolyoKategoriController(IPortfolyoKategoriService portfolyoKategoriService, ImageController imageController)
        {
            _portfolyoKategoriService = portfolyoKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var portfolyoKategoriler = await _portfolyoKategoriService.GetAllAsync();
            PortfolyoKategoriViewModel model = new PortfolyoKategoriViewModel
            {
                PortfolyoKategoriler = portfolyoKategoriler
            };
            return View(model);
        }

        [HttpGet]
        [Route("PortfolyoKategori/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            PortfolyoKategoriViewModel model = new PortfolyoKategoriViewModel();

            var portfolyoKategoriler = await _portfolyoKategoriService.GetAllAsync();

            if (id == 0)
            {
                PortfolyoKategori portfolyoKategori = new PortfolyoKategori
                {
                    Id = id,
                    Durum = true,
                    Sira = portfolyoKategoriler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.PortfolyoKategori = portfolyoKategori;

                return View(model);
            }
            else
            {
                model.PortfolyoKategori = await _portfolyoKategoriService.GetByIdAsync(id);
                if (model.PortfolyoKategori == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(PortfolyoKategoriViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.PortfolyoKategori.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.PortfolyoKategori.OneCikanGorsel = imageUrl;
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


                if (model.PortfolyoKategori.Id == 0)
                {
                    model.PortfolyoKategori.Ekleme = DateTime.Now;
                    await _portfolyoKategoriService.AddAsync(model.PortfolyoKategori);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _portfolyoKategoriService.GetByIdAsync(model.PortfolyoKategori.Id);

                    if (model.Dosya == null)
                        model.PortfolyoKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.PortfolyoKategori.Ekleme = oldEntity.Ekleme;
                    await _portfolyoKategoriService.UpdateAsync(model.PortfolyoKategori);
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

            var itemIsValid = await _portfolyoKategoriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _portfolyoKategoriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }
}