using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class UrunKategoriController : Controller
    {
        IUrunKategoriService _urunKategoriService;

        private readonly ImageController _imageController;
        public UrunKategoriController(IUrunKategoriService urunKategoriService, ImageController imageController)
        {
            _urunKategoriService = urunKategoriService;
            _imageController = imageController;
        }
        public async Task<IActionResult> Index()
        {
            UrunKategoriViewModel model = new UrunKategoriViewModel();
            var urunKategoriler = await _urunKategoriService.GetAllAsync(X => X.UstKategoriId == null);
            var tumKategoriler = await _urunKategoriService.GetAllAsync();

            List<UrunKategori> tumUrunKategorileri = new List<UrunKategori>();

            foreach (var item1 in urunKategoriler)
            {
                UrunKategori yeniUrunKategori1 = new UrunKategori();
                var yeniUrunKategori1Adi = item1.KategoriAdi;
                yeniUrunKategori1.Id = item1.Id;
                yeniUrunKategori1.KategoriAdi = yeniUrunKategori1Adi;
                tumUrunKategorileri.Add(yeniUrunKategori1);

                foreach (var item2 in tumKategoriler.Where(x => x.UstKategoriId == item1.Id))
                {
                    UrunKategori yeniUrunKategori2 = new UrunKategori();
                    var yeniUrunKategori2Adi = yeniUrunKategori1Adi + " > " + item2.KategoriAdi;
                    yeniUrunKategori2.Id = item2.Id;
                    yeniUrunKategori2.KategoriAdi = yeniUrunKategori2Adi;
            
                    tumUrunKategorileri.Add(yeniUrunKategori2);

                    foreach (var item3 in tumKategoriler.Where(x => x.UstKategoriId == item2.Id))
                    {
                        UrunKategori yeniUrunKategori3 = new UrunKategori();
                        var yeniUrunKategori3Adi = yeniUrunKategori2Adi + " > " + item3.KategoriAdi;
                        yeniUrunKategori3.Id = item3.Id;
                        yeniUrunKategori3.KategoriAdi = yeniUrunKategori3Adi;
                        tumUrunKategorileri.Add(yeniUrunKategori3);
                    }
                }
            }

            model.UrunKategoriler = tumUrunKategorileri;
            model.UrunUstKategoriler = tumUrunKategorileri;

            return View(model);
        }

		[HttpGet]
		[Route("UrunKategori/AddOrUpdate/{id?}")]
		public async Task<ActionResult> AddOrUpdate(int id = 0)
		{
			UrunKategoriViewModel model = new UrunKategoriViewModel();
			var urunKategoriler = await _urunKategoriService.GetAllAsync(X=>X.UstKategoriId==null);
			var tumKategoriler = await _urunKategoriService.GetAllAsync();

			List<UrunKategori> tumUrunKategorileri = new List<UrunKategori>();

			foreach (var item1 in urunKategoriler)
			{
				UrunKategori yeniUrunKategori1 = new UrunKategori();
                var yeniUrunKategori1Adi = item1.KategoriAdi;
                yeniUrunKategori1.Id=item1.Id;
                yeniUrunKategori1.KategoriAdi= yeniUrunKategori1Adi;
             
                tumUrunKategorileri.Add(yeniUrunKategori1);

                foreach (var item2 in tumKategoriler.Where(x=>x.UstKategoriId==item1.Id))
				{
                    UrunKategori yeniUrunKategori2 = new UrunKategori();
                    var yeniUrunKategori2Adi = yeniUrunKategori1Adi +" > "+item2.KategoriAdi ;
                    yeniUrunKategori2.Id = item2.Id;
                    yeniUrunKategori2.KategoriAdi = yeniUrunKategori2Adi;
                    tumUrunKategorileri.Add(yeniUrunKategori2);

                    foreach (var item3 in tumKategoriler.Where(x => x.UstKategoriId == item2.Id))
                    {
                        UrunKategori yeniUrunKategori3 = new UrunKategori();
                        var yeniUrunKategori3Adi = yeniUrunKategori2Adi + " > " + item3.KategoriAdi;
                        yeniUrunKategori3.Id = item3.Id;
                        yeniUrunKategori3.KategoriAdi = yeniUrunKategori3Adi;
                        tumUrunKategorileri.Add(yeniUrunKategori3);
                    }
                }
			}


			model.UstKategoriList = new SelectList(tumUrunKategorileri, "Id", "KategoriAdi");

			if (id == 0)
			{
				UrunKategori urunKategori = new UrunKategori
				{
					Id = id,
					Durum = true,
					Sira = tumUrunKategorileri.Count + 1,
					Ekleme = DateTime.Now
				};
				model.UrunKategori = urunKategori;
			}
			else
			{
				model.UrunKategori = await _urunKategoriService.GetByIdAsync(id);
				if (model.UrunKategori == null)
				{
					return NotFound();
				}
			}

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> AddOrUpdate(UrunKategoriViewModel model)
		{
			if (ModelState.IsValid)
			{
				if (model.Dosya != null)
				{
					var result = await _imageController.UploadImageAsync(model.Dosya, model.UrunKategori.OneCikanGorsel);
					if (result is OkObjectResult okResult)
					{
						var imageUrl = okResult.Value as string;
						if (imageUrl != null)
						{
							model.UrunKategori.OneCikanGorsel = imageUrl;
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

				if (model.UrunKategori.Id == 0)
				{
					model.UrunKategori.Ekleme = DateTime.Now;
					await _urunKategoriService.AddAsync(model.UrunKategori);
				}
				else
				{
					var oldEntity = await _urunKategoriService.GetByIdAsync(model.UrunKategori.Id);
					if (model.Dosya == null)
						model.UrunKategori.OneCikanGorsel = oldEntity.OneCikanGorsel;

					model.UrunKategori.Ekleme = oldEntity.Ekleme;
					await _urunKategoriService.UpdateAsync(model.UrunKategori);
				}

				return RedirectToAction("Index");
			}

			var urunKategoriler = await _urunKategoriService.GetAllAsync();
			model.UstKategoriList = new SelectList(urunKategoriler, "Id", "KategoriAdi");

			return View(model);
		}

		public async Task<JsonResult> Delete(int id)
        {
            if (id == 0)
            {
                return Json(0);
            }

            var itemIsValid = await _urunKategoriService.GetByIdAsync(id);
            if (itemIsValid == null)
            {
                return Json(0);
            }
            try
            {
                await _urunKategoriService.DeleteAsync(itemIsValid.Id);
                return Json(1);
            }
            catch (Exception)
            {
                return Json(0);
            }
        }

    }

}
