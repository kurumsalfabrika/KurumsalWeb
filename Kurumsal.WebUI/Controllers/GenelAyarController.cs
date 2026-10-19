using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Functions;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class GenelAyarController : Controller
    {
        IGenelAyarService _genelAyarService;

        public GenelAyarController(IGenelAyarService genelAyarService)
        {
            _genelAyarService = genelAyarService;
        }
        public async Task<IActionResult> Index()
        {

            GenelAyarViewModel model = new GenelAyarViewModel();

            try
            {
                model.GenelAyar = await _genelAyarService.GetByIdAsync(1);
            }
            catch (Exception)
            {
                GenelAyar genelAyar = new GenelAyar
                {
                    Id = 0

                };
                model.GenelAyar = genelAyar;
            }

            if (model.GenelAyar == null)
            {
                GenelAyar genelAyar = new GenelAyar
                {
                    Id = 0

                };
                model.GenelAyar = genelAyar;
            }

            return View(model);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(GenelAyarViewModel model)
        {
            if (ModelState.IsValid)
            {
                //model.GenelAyar.HeaderLogo = GeneralFunctions.DosyaYukle($@"Files/Images/", model.HeaderLogoDosya);
                //model.GenelAyar.FooterLogo = GeneralFunctions.DosyaYukle($@"Files/Images/", model.FooterLogoDosya);
                //model.GenelAyar.Favicon = GeneralFunctions.DosyaYukle($@"Files/Images/", model.FaviconDosya);
                //model.GenelAyar.SiteUstuGorsel = GeneralFunctions.DosyaYukle($@"Files/Images/", model.SiteUstuGorselDosya);

                if (model.GenelAyar.Id == 0)
                {
                    model.GenelAyar.Ekleme = DateTime.Now;
                    await _genelAyarService.AddAsync(model.GenelAyar);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _genelAyarService.GetByIdAsync(model.GenelAyar.Id);

                    //if (model.HeaderLogoDosya == null)
                    //    model.GenelAyar.HeaderLogo = oldEntity.HeaderLogo;

                    //if (model.FooterLogoDosya == null)
                    //    model.GenelAyar.FooterLogo = oldEntity.FooterLogo;

                    //if (model.FaviconDosya == null)
                    //    model.GenelAyar.Favicon = oldEntity.Favicon;

                    //if (model.SiteUstuGorselDosya == null)
                    //    model.GenelAyar.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.GenelAyar.Ekleme = oldEntity.Ekleme;
                    await _genelAyarService.UpdateAsync(model.GenelAyar);
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index", model);
        }


        public async Task<JsonResult> Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }

            var itemIsValid = await _genelAyarService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _genelAyarService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
