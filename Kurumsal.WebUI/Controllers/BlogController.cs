using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{

	public class BlogController : Controller
    {
        IBlogService _blogService;

        private readonly ImageController _imageController;
        public BlogController(IBlogService blogService, ImageController imageController)
        {
            _blogService = blogService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            var bloglar = await _blogService.GetAllAsync();
            BlogViewModel model = new BlogViewModel
            {
                Bloglar = bloglar
            };
            return View(model);
        }




        [HttpGet]
        [Route("Blog/AddOrUpdate/{id?}")]
        public async Task<ActionResult> AddOrUpdate(int id = 0)
        {


            BlogViewModel model = new BlogViewModel();

            var bloglar = await _blogService.GetAllAsync();

            if (id == 0)
            {
                Blog blog = new Blog
                {
                    Id = id,
                    YayinTarihi = DateTime.Now,
                    AnaSayfadaGoster = true,
                    Durum = true,
                    Sira = bloglar.Count + 1,
                    Ekleme = DateTime.Now

                };
                model.Blog = blog;

                return View(model);
            }
            else
            {
                model.Blog = await _blogService.GetByIdAsync(id);
                if (model.Blog == null)
                {
                    return NotFound();
                }

                return View(model);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var result = await _imageController.UploadImageAsync(model.Dosya, model.Blog.OneCikanGorsel);

                    if (result is OkObjectResult okResult)
                    {
                        var imageUrl = okResult.Value as string;  // String'e cast etme işlemi
                        if (imageUrl != null)
                        {
                            model.Blog.OneCikanGorsel = imageUrl;
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


                if (model.Blog.Id == 0)
                {
                    model.Blog.Ekleme = DateTime.Now;
                    await _blogService.AddAsync(model.Blog);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _blogService.GetByIdAsync(model.Blog.Id);

                    if (model.Dosya == null)
                        model.Blog.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Blog.Ekleme = oldEntity.Ekleme;
                    await _blogService.UpdateAsync(model.Blog);
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

            var itemIsValid = await _blogService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _blogService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }


    }
}
