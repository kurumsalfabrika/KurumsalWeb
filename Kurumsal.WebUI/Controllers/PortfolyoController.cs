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
    public class PortfolyoController : Controller
    {
        IPortfolyoService _portfolyoService;
        private readonly IPortfolyoKategoriService _portfolyoKategoriService;

        private readonly ImageController _imageController;
        public PortfolyoController(IPortfolyoService portfolyoService, ImageController imageController, IPortfolyoKategoriService portfolyoKategoriService)
        {
            _portfolyoService = portfolyoService;
            _imageController = imageController;
            _portfolyoKategoriService = portfolyoKategoriService;
        }
        public async Task<IActionResult> Index()
        {
            var portfolyoler = await _portfolyoService.GetAllAsync(query => query.Include(h => h.PortfolyoKategori));
            PortfolyoViewModel model = new PortfolyoViewModel
            {
                Portfolyolar = portfolyoler
            };
            return View(model);
        }


        [HttpGet]
        [Route("Portfolyo/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            PortfolyoViewModel model = new PortfolyoViewModel();
            var kategoriler = await _portfolyoKategoriService.GetAllAsync();  // Kategorileri async olarak çek

            var portfolyoler = await _portfolyoService.GetAllAsync();

            model.PortfolyoKategoriList = kategoriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.KategoriAdi
            }).ToList();


            if (id == 0)
            {
                Portfolyo portfolyo = new Portfolyo
                {
                    Id = id,

                    Durum = true,
                    Sira = portfolyoler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Portfolyo = portfolyo;

                return View(model);
            }
            else
            {
                model.Portfolyo = await _portfolyoService.GetByIdAsync(id);
                if (model.Portfolyo == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(PortfolyoViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Portfolyo.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Portfolyo.OneCikanGorsel = imageUrl;
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


                if (model.Portfolyo.Id == 0)
                {
                    model.Portfolyo.Ekleme = DateTime.Now;
                    await _portfolyoService.AddAsync(model.Portfolyo);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _portfolyoService.GetByIdAsync(model.Portfolyo.Id);

                    if (model.Dosya == null)
                        model.Portfolyo.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Portfolyo.Ekleme = oldEntity.Ekleme;
                    await _portfolyoService.UpdateAsync(model.Portfolyo);
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

            var itemIsValid = await _portfolyoService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _portfolyoService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
