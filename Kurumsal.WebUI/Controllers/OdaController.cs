using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kurumsal.WebUI.Controllers
{
    public class OdaController : Controller
    {

        private readonly IOdaKategoriService _odaKategoriService;
        private readonly IFotoGaleriService _fotoGaleriService;
        private readonly IOdaService _odaService;
        readonly IFtpService _ftpService;

        private readonly ImageController _imageController;
		public OdaController(ImageController imageController, IOdaKategoriService odaKategoriService, IOdaService odaService, IFtpService ftpService, IFotoGaleriService fotoGaleriService)
		{
			_imageController = imageController;
			_odaKategoriService = odaKategoriService;
			_odaService = odaService;
			_ftpService = ftpService;
			_fotoGaleriService = fotoGaleriService;
		}
		public async Task<IActionResult> Index()
        {
            var odalar = await _odaService.GetAllAsync(null,query => query.Include(h => h.OdaKategori));
            var ftp = await _ftpService.GetByIdAsync(1);
            OdaViewModel model = new OdaViewModel
            {
                Odalar = odalar,
                Ftp=ftp
            };
            return View(model);
        }

        [HttpGet]
        [Route("Oda/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            OdaViewModel model = new OdaViewModel();
            var kategoriler = await _odaKategoriService.GetAllAsync();  // Kategorileri async olarak çek
            var ftp = await _ftpService.GetByIdAsync(1);  // Kategorileri async olarak çek

            var odalar = await _odaService.GetAllAsync();
            var fotoGaleriler= await _fotoGaleriService.GetAllAsync();
            model.Ftp = ftp;
            model.FotoGaleriList = fotoGaleriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.GaleriAdi
            }).ToList();

            model.OdaKategoriList = kategoriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.KategoriAdi
            }).ToList();


            if (id == 0)
            {
                Oda oda = new Oda
                {
                    Id = id,
                    Sira = odalar.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Oda = oda;
               
                return View(model);
            }
            else
            {
                model.Oda = await _odaService.GetByIdAsync(id);
                if (model.Oda == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(OdaViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Oda.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Oda.OneCikanGorsel = imageUrl;
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

                if (model.Oda.Id == 0)
                {
                    model.Oda.Ekleme = DateTime.Now;
                    await _odaService.AddAsync(model.Oda);
                    return RedirectToAction("Index");
                }
                else
                {

                    //= await _odaService.GetAllAsync(null,query => query.Include(h => h.OdaKategori));
                    var oldEntity = await _odaService.GetByIdAsync(model.Oda.Id);

                    if (model.Dosya == null)
                        model.Oda.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Oda.Ekleme = oldEntity.Ekleme;
                    await _odaService.UpdateAsync(model.Oda);
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

            var itemIsValid = await _odaService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _odaService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}