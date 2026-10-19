using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
	public class UrunController : Controller
	{
		private readonly IUrunService _urunService;
		private readonly IUrunKategoriService _urunKategoriService;
        private readonly IFotografService _fotografService;
        public readonly ISiteAyarService _siteAyarService;
        public readonly IFtpService _ftpService;
        private readonly ImageController _imageController;
        public UrunController(IFotografService fotografService, IUrunService urunService, ImageController imageController, IUrunKategoriService urunKategoriService, ISiteAyarService siteAyarService, IFtpService ftpService)
        {
            _urunService = urunService;
            _imageController = imageController;
            _urunKategoriService = urunKategoriService;
            _fotografService = fotografService;
            _siteAyarService = siteAyarService;
            _ftpService = ftpService;
        }
        public async Task<IActionResult> Index()
		{
			var urunler = await _urunService.GetAllAsync(null, query => query.Include(h => h.UrunKategori));

            var ftp = await _ftpService.GetByIdAsync(1);
         
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
        

            UrunViewModel model = new UrunViewModel
			{
				Urunler = urunler,
				Ftp = ftp,
                SiteAyar = siteAyar
            };
			return View(model);
		}

		[HttpGet]
		[Route("Urun/AddOrUpdate/{id?}")]
		public async Task<ActionResult> AddOrUpdate(int id = 0)
		{
			UrunViewModel model = new UrunViewModel();
            var ftp = await _ftpService.GetByIdAsync(1);
            model.Ftp = ftp;
            var siteAyar = await _siteAyarService.GetByIdAsync(1);
            model.SiteAyar = siteAyar;

            var urunler = await _urunService.GetAllAsync();

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


            model.UrunKategoriList = new SelectList(tumUrunKategorileri, "Id", "KategoriAdi");


            model.Fotograflar = await _fotografService.GetAllAsync(x => x.UrunId == id);


            if (id == 0)
			{
				Urun urun = new Urun
				{
					Id = id,
					Durum = true,
					Sira = urunler.Count + 1,
					Ekleme = DateTime.Now

				};
				model.Urun = urun;

				return View(model);
			}
			else
			{
				model.Urun = await _urunService.GetByIdAsync(id);
				if (model.Urun == null)
				{
					return NotFound();
				}

				return View(model);
			}
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> AddOrUpdate(UrunViewModel model)
		{
			if (ModelState.IsValid)
			{
				if (model.Dosya != null)
				{
					var result = await _imageController.UploadImageAsync(model.Dosya, model.Urun.OneCikanGorsel);
					
					if (result is OkObjectResult okResult)
					{
						var imageUrl = okResult.Value as string;
						if (imageUrl != null)
						{
							model.Urun.OneCikanGorsel = imageUrl;
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
				if (model.DosyaVitrin != null)
				{
					model.Urun.AnaSayfaVitrinResmi=Guid.NewGuid().ToString();
					var result = await _imageController.UploadImageAsync(model.DosyaVitrin, model.Urun.AnaSayfaVitrinResmi);
					
					if (result is OkObjectResult okResult)
					{
						var imageUrl = okResult.Value as string;
						if (imageUrl != null)
						{
							model.Urun.AnaSayfaVitrinResmi = imageUrl;
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

				if (model.Urun.Id == 0)
				{
					model.Urun.Ekleme = DateTime.Now;
					await _urunService.AddAsync(model.Urun);
					return RedirectToAction("Index");
				}
				else
				{
					var oldEntity = await _urunService.GetByIdAsync(model.Urun.Id);
					if (model.Dosya == null)
					{
						model.Urun.OneCikanGorsel = oldEntity.OneCikanGorsel;
					}

					if (model.DosyaVitrin == null)
					{
						model.Urun.AnaSayfaVitrinResmi = oldEntity.AnaSayfaVitrinResmi;
					}
						

					model.Urun.Ekleme = oldEntity.Ekleme;
					await _urunService.UpdateAsync(model.Urun);
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

			var itemIsValid = await _urunService.GetByIdAsync(id);
			if (itemIsValid == null)
			{
				return Json(0);
			}
			try
			{
				await _urunService.DeleteAsync(itemIsValid.Id);
				return Json(1);
			}
			catch (Exception)
			{
				return Json(0);
			}
		}

        public async Task<JsonResult> AddFoto(int urunId, IFormFile dosya)
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
							FotoGaleriId=null,
                            OneCikanGorsel = imageUrl,
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
