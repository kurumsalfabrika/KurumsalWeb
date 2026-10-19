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
    public class SubeController : Controller
    {


        private readonly IFotoGaleriService _fotoGaleriService;
        private readonly ISubeService _subeService;
        readonly IFtpService _ftpService;

        private readonly ImageController _imageController;
        public SubeController(ImageController imageController, ISubeService subeService,  IFtpService ftpService, IFotoGaleriService fotoGaleriService)
        {
            _imageController = imageController;
            _subeService = subeService;
            _ftpService = ftpService;
            _fotoGaleriService = fotoGaleriService;
        }
        public async Task<IActionResult> Index()
        {
            var subeler = await _subeService.GetAllAsync();
            var ftp = await _ftpService.GetByIdAsync(1);
            SubeViewModel model = new SubeViewModel
            {
                Subeler = subeler,
                Ftp = ftp
            };
            return View(model);
        }

        [HttpGet]
        [Route("Sube/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            SubeViewModel model = new SubeViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);  

            var subelar = await _subeService.GetAllAsync();
            var fotoGaleriler = await _fotoGaleriService.GetAllAsync();
            model.Ftp = ftp;
            model.FotoGaleriList = fotoGaleriler.Select(k => new SelectListItem
            {
                Value = k.Id.ToString(),
                Text = k.GaleriAdi
            }).ToList();


            if (id == 0)
            {
                Sube sube = new Sube
                {
                    Id = id,

                    Sira = subelar.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Sube = sube;

                return View(model);
            }
            else
            {
                model.Sube = await _subeService.GetByIdAsync(id);
                if (model.Sube == null)
                {
                    return NotFound();
                }

                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SubeViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Sube.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Sube.OneCikanGorsel = imageUrl;
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

                if (model.Sube.Id == 0)
                {
                    model.Sube.Ekleme = DateTime.Now;
                    await _subeService.AddAsync(model.Sube);
                    return RedirectToAction("Index");
                }
                else
                {

                    //= await _subeService.GetAllAsync(null,query => query.Include(h => h.SubeKategori));
                    var oldEntity = await _subeService.GetByIdAsync(model.Sube.Id);

                    if (model.Dosya == null)
                        model.Sube.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Sube.Ekleme = oldEntity.Ekleme;
                    await _subeService.UpdateAsync(model.Sube);
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

            var itemIsValid = await _subeService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _subeService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }
    }
}