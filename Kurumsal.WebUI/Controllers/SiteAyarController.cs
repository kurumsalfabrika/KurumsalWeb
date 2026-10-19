using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class SiteAyarController : Controller
    {
        ISiteAyarService _siteAyarService;
        private readonly ImageController _imageController;
        public SiteAyarController(ISiteAyarService siteAyarService, ImageController imageController)
        {
            _siteAyarService = siteAyarService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var siteAyarlar = await _siteAyarService.GetByIdAsync(1);
            SiteAyarViewModel siteAyarModel = new SiteAyarViewModel();

            SiteAyar siteAyar = new SiteAyar();


            if (siteAyarlar == null)
            {
                siteAyar.Id = 1;
                siteAyarModel.SiteAyar = siteAyar;
                return View(siteAyarModel);
            }
            else
            {
                siteAyarModel.SiteAyar = siteAyarlar;
                return View(siteAyarModel);

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(SiteAyarViewModel model)
        {
            if (ModelState.IsValid)
            {
                var oldEntity = await _siteAyarService.GetByIdAsync(1);

                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.SiteAyar.HeaderLogoAcikRenk);
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SiteAyar.HeaderLogoAcikRenk = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Header Logo yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }
                }
                else
                {
                    try
                    {
                        model.SiteAyar.HeaderLogoAcikRenk = oldEntity.HeaderLogoAcikRenk;
                    }
                    catch (System.Exception)
                    {

                    }
                }


                if (model.Dosya1 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya1, model.SiteAyar.HeaderLogoKoyuRenk);
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SiteAyar.HeaderLogoKoyuRenk = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Header Logo yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }
                }
                else
                {
                    try
                    {
                        model.SiteAyar.HeaderLogoKoyuRenk = oldEntity.HeaderLogoKoyuRenk;
                    }
                    catch (System.Exception)
                    {

                    }
                }


                if (model.Dosya2 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya2, model.SiteAyar.HolderLogo);
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SiteAyar.HolderLogo = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Holder Logo yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }
                }
                else
                {
                    try
                    {
                        model.SiteAyar.HolderLogo = oldEntity.HolderLogo;
                    }
                    catch (System.Exception)
                    {

                    }
                }




                if (model.Dosya3 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya3, model.SiteAyar.FooterLogo);
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SiteAyar.FooterLogo = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Footer Logo yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }
                }
                else
                {
                    try
                    {
                        model.SiteAyar.FooterLogo = oldEntity.FooterLogo;
                    }
                    catch (System.Exception)
                    {


                    }

                }


                if (model.Dosya4 != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya4, model.SiteAyar.Favicon);
                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.SiteAyar.Favicon = imageUrl;
                        }
                        else
                        {
                            return BadRequest("Favori İkonu yüklenemedi.");
                        }
                    }
                    else if (result is BadRequestObjectResult badRequestResult)
                    {
                        return BadRequest(badRequestResult.Value);
                    }
                }
                else
                {
                    try
                    {
                        model.SiteAyar.Favicon = oldEntity.Favicon;
                    }
                    catch (System.Exception)
                    {
                    }
                }


                var siteAyarlar = await _siteAyarService.GetByIdAsync(1);

                bool isAdded = false;
                if (siteAyarlar == null)
                {
                    model.SiteAyar.Id = 1;
                    await _siteAyarService.AddAsync(model.SiteAyar);
                    isAdded = true;
                }
                else
                {
                    model.SiteAyar.Id = 1;
                    await _siteAyarService.UpdateAsync(model.SiteAyar);
                }

                // Burada bir JSON nesnesi döndürüyoruz
                return Json(new { success = true, message = isAdded ? "Ekleme işlemi başarılı!" : "Güncelleme işlemi başarılı!" });
            }
            // Hata durumunda
            return Json(new { success = false, message = "Form verileri geçersiz!" });
        }

    }
}
