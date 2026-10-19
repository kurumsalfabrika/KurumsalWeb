using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class FotografController : Controller
    {

        private readonly IFotografService _fotografService;
        private readonly IFotoGaleriService _fotoGaleriService;
        private readonly IFtpService _ftpService;

        private readonly ImageController _imageController;
        public FotografController(IFotografService fotografService, ImageController imageController, IFotoGaleriService fotoGaleriService, IFtpService ftpService)
        {
            _fotografService = fotografService;
            _imageController = imageController;
            _fotoGaleriService = fotoGaleriService;
            _ftpService = ftpService;   
        }
        [HttpGet]
        [Route("Fotograf/Index/{id?}")]
        public async Task<IActionResult> Index(int id = 0)
        {

            var fotograflar = await _fotografService.GetAllAsync();
            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();
            var fotoGaleri = await _fotoGaleriService.GetByAsync(x=>x.Id==id);
            var ftp = await _ftpService.GetByIdAsync(1);
            if(id!=0)
            {
                fotograflar = await _fotografService.GetAllAsync(x=>x.FotoGaleriId==id);

            }

            FotografViewModel model = new FotografViewModel
            {
                Fotograflar = fotograflar,
                FotoGaleri=fotoGaleri,
                Ftp=ftp
            };
            return View(model);
        }


        [HttpGet]
        [Route("Fotograf/AddOrUpdate/{id?}/{galeriId?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0, int galeriId = 0)
        {
            FotografViewModel model = new FotografViewModel();


            var fotografler = await _fotografService.GetAllAsync();
            var fotoGaleri = await _fotoGaleriService.GetByAsync(x=>x.Id==galeriId);

            model.FotoGaleri=fotoGaleri;

            if (id == 0)
            {
                Fotograf fotograf = new Fotograf
                {
                    Id = id,
                    Durum = true,
                    FotoGaleriId=galeriId,
                    Sira = fotografler.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Fotograf = fotograf;

                return View(model);
            }
            else
            {
                model.Fotograf = await _fotografService.GetByIdAsync(id);
                if (model.Fotograf == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(FotografViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Dosya != null)
                {

                   

                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Fotograf.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Fotograf.OneCikanGorsel = imageUrl;
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

                if (model.Fotograf.Id == 0)
                {
                    model.Fotograf.Ekleme = DateTime.Now;
                    await _fotografService.AddAsync(model.Fotograf);
                    return RedirectToAction("Index", new { id = model.Fotograf.FotoGaleriId });
                }
                else
                {
                    var oldEntity = await _fotografService.GetByIdAsync(model.Fotograf.Id);

                    if (model.Dosya == null)
                        model.Fotograf.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Fotograf.Ekleme = oldEntity.Ekleme;
                    await _fotografService.UpdateAsync(model.Fotograf);
                    return RedirectToAction("Index", new { id = model.Fotograf.FotoGaleriId });
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

            var itemIsValid = await _fotografService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _fotografService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}
