using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Kurumsal.WebUI.Controllers
{

        public class MesajController : Controller
        {
            IMesajService _mesajService;
            private readonly ImageController _imageController;
            public MesajController(IMesajService mesajService, ImageController imageController)
            {
                _mesajService = mesajService;
                _imageController = imageController;
            }
            public async Task<IActionResult> Index()
            {
                var mesajler = await _mesajService.GetAllAsync();
                MesajViewModel model = new MesajViewModel
                {
                    Mesajlar = mesajler
                };
                return View(model);
            }


            [HttpGet]
            [Route("Mesaj/AddOrUpdate/{id?}")]
            public async Task<ActionResult> AddOrUpdate(int id = 0)
            {
                MesajViewModel model = new MesajViewModel();


                var mesajler = await _mesajService.GetAllAsync();


                if (id == 0)
                {
                    Mesaj mesaj = new Mesaj
                    {
                        Id = id,

                        Durum = false,
                        GelisTarihi = DateTime.Now

                    };
                    model.Mesaj = mesaj;

                    return View(model);
                }
                else
                {
                    model.Mesaj = await _mesajService.GetByIdAsync(id);
                    if (model.Mesaj == null)
                    {
                        return NotFound();
                    }

                    return View(model);
                }
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> AddOrUpdate(MesajViewModel model)
            {
                if (ModelState.IsValid)
                {




                    if (model.Mesaj.Id == 0)
                    {
                        model.Mesaj.GelisTarihi = DateTime.Now;
                        await _mesajService.AddAsync(model.Mesaj);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        var oldEntity = await _mesajService.GetByIdAsync(model.Mesaj.Id);

         

                        model.Mesaj.GelisTarihi = oldEntity.GelisTarihi;
                        model.Mesaj.OkunmaTarihi = DateTime.Now;
                        await _mesajService.UpdateAsync(model.Mesaj);
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

                var itemIsValid = await _mesajService.GetByIdAsync(id);
                if (itemIsValid == null)
                {
                    return Json(0);
                }
                try
                {
                    await _mesajService.DeleteAsync(itemIsValid.Id);
                    return Json(1);
                }
                catch (Exception)
                {
                    return Json(0);
                }
            }


        }
    }
