using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.Entities.Enums;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class InsaatProjeController : Controller
    {
        private readonly IInsaatProjeService _insaatProjeService;
        private readonly IFotografService _fotografService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        private readonly ImageController _imageController;
        public InsaatProjeController(IInsaatProjeService insaatProjeService, ImageController imageController, IFotografService fotografService, ISiteAyarService siteAyarService, IFtpService ftpService)
        {
            _insaatProjeService = insaatProjeService;
            _imageController = imageController;
            _fotografService = fotografService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
        }
        public async Task<IActionResult> Index()
        {
            var insaatProjeler = await _insaatProjeService.GetAllAsync();
            InsaatProjeViewModel model = new InsaatProjeViewModel
            {
                InsaatProjeler = insaatProjeler
            };
            return View(model);
        }


        [HttpGet]
        [Route("InsaatProje/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {
            InsaatProjeViewModel model = new InsaatProjeViewModel();

            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            model.ProjeDurumlari = EnumHelper.GetEnumDescriptionList<ProjeDurumu>()
                                     .Select(e => new SelectListItem
                                     {
                                         Value = e.Key.ToString(),
                                         Text = e.Value
                                     })
                                     .ToList();


            var insaatProjeler = await _insaatProjeService.GetAllAsync();




            if (id == 0)
            {
                InsaatProje insaatProje = new InsaatProje
                {
                    Id = id,
                    Durum = true,
                    Ekleme = DateTime.Now

                };
                model.InsaatProje = insaatProje;

                return View(model);
            }
            else
            {
                model.InsaatProje = await _insaatProjeService.GetByIdAsync(id);



                model.IcMekanGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == id && X.ListeKodu == "ICMEKAN");
                model.DisMekanGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == id && X.ListeKodu == "DISMEKAN");
                model.KrokiGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == id && X.ListeKodu == "KROKI");


                if (model.InsaatProje == null)
                {
                    return NotFound();
                }
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(InsaatProjeViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.InsaatProje.OneCikanGorsel);


                   
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.InsaatProje.OneCikanGorsel = imageUrl;
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

                if (model.InsaatProje.Id == 0)
                {
                    model.InsaatProje.Ekleme = DateTime.Now;
                    await _insaatProjeService.AddAsync(model.InsaatProje);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _insaatProjeService.GetByIdAsync(model.InsaatProje.Id);

                    if (model.Dosya == null)
                        model.InsaatProje.OneCikanGorsel = oldEntity.OneCikanGorsel;


                    model.IcMekanGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == model.InsaatProje.Id && X.ListeKodu == "ICMEKAN");
                    model.DisMekanGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == model.InsaatProje.Id && X.ListeKodu == "DISMEKAN");
                    model.KrokiGorselleri = await _fotografService.GetAllAsync(X => X.UrunId == model.InsaatProje.Id && X.ListeKodu == "KROKI");


                    model.InsaatProje.Ekleme = oldEntity.Ekleme;
                    await _insaatProjeService.UpdateAsync(model.InsaatProje);
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

            var itemIsValid = await _insaatProjeService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _insaatProjeService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

        public async Task<JsonResult> AddDisMekanFoto(int urunId, IFormFile dosya)
        {
            if (dosya != null)
            {
                var result = await _imageController.UploadImageAsync(dosya, null);
                if (result is OkObjectResult okResult)
                {
                    var imageUrl = okResult.Value as string;
                    if (imageUrl != null)
                    {
                        Fotograf fotograf = new Fotograf
                        {
                            Durum = true,
                            UrunId = urunId,
                            FotoGaleriId = null,
                            OneCikanGorsel = imageUrl,
                            ListeKodu="DISMEKAN",
                            Ekleme = DateTime.Now
                        };
                        await _fotografService.AddAsync(fotograf);
                        return Json(new { success = true, url = imageUrl });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Dosya yüklenemedi." });
                    }
                }
                else if (result is BadRequestObjectResult badRequestResult)
                {
                    return Json(new { success = false, message = badRequestResult.Value });
                }
            }
            return Json(new { success = false, message = "Dosya seçilmedi." });
        }
        
        public async Task<JsonResult> AddKrokiFoto(int urunId, IFormFile dosya)
        {
            if (dosya != null)
            {
                var result = await _imageController.UploadImageAsync(dosya, null);
                if (result is OkObjectResult okResult)
                {
                    var imageUrl = okResult.Value as string;
                    if (imageUrl != null)
                    {
                        Fotograf fotograf = new Fotograf
                        {
                            Durum = true,
                            UrunId = urunId,
                            FotoGaleriId = null,
                            OneCikanGorsel = imageUrl,
                            ListeKodu="KROKI",
                            Ekleme = DateTime.Now
                        };
                        await _fotografService.AddAsync(fotograf);
                        return Json(new { success = true, url = imageUrl });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Dosya yüklenemedi." });
                    }
                }
                else if (result is BadRequestObjectResult badRequestResult)
                {
                    return Json(new { success = false, message = badRequestResult.Value });
                }
            }
            return Json(new { success = false, message = "Dosya seçilmedi." });
        }
        
        public async Task<JsonResult> AddIcMekanFoto(int urunId, IFormFile dosya)
        {
            if (dosya != null)
            {
                var result = await _imageController.UploadImageAsync(dosya, null);
                if (result is OkObjectResult okResult)
                {
                    var imageUrl = okResult.Value as string;
                    if (imageUrl != null)
                    {
                        Fotograf fotograf = new Fotograf
                        {
                            Durum = true,
                            UrunId = urunId,
                            FotoGaleriId = null,
                            OneCikanGorsel = imageUrl,
                            ListeKodu="ICMEKAN",
                            Ekleme = DateTime.Now
                        };
                        await _fotografService.AddAsync(fotograf);
                        return Json(new { success = true, url = imageUrl });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Dosya yüklenemedi." });
                    }
                }
                else if (result is BadRequestObjectResult badRequestResult)
                {
                    return Json(new { success = false, message = badRequestResult.Value });
                }
            }
            return Json(new { success = false, message = "Dosya seçilmedi." });
        }


        public async Task<JsonResult> DeleteFoto(int id)
        {
            var fotograf = await _fotografService.GetByIdAsync(id);
            if (fotograf != null)
            {
                await _fotografService.DeleteAsync(id);
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Fotoğraf bulunamadı." });
        }


    }
}
