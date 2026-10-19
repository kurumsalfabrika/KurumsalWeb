using Kurumsal.Business.Abstract;
using Kurumsal.Entities.Concrete;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Controllers
{
    public class MenuController : Controller
    {
        IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task OnGet()
        {
            var tumMenuler = await _menuService.GetAllAsync();  // Verileri asenkron olarak al
            Menuler = tumMenuler.Where(m => m.AnaMenuId == 0).ToList();  // LINQ ile filtreleme
            MenuModel = new MenuViewModel();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return View(); // Hata varsa formu tekrar göster
            }

            try
            {
                await _menuService.AddAsync(MenuModel.Menu); // Menüyü ekle
                return RedirectToPage("./Index"); // İşlem başarılıysa başka bir sayfaya yönlendir
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Menü eklenirken bir hata oluştu: " + ex.Message);
                return View(); // Hata durumunda formu tekrar göster
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetMenuById(int id)
        {
            var menu = await _menuService.GetByIdAsync(id);
            if (menu == null)
            {
                return Json(new { success = false, message = "Menü bulunamadı." });
            }
            return Json(new { success = true, menu = menu });
        }



        [HttpPost]
        public async Task<IActionResult> UpdateMenu([FromForm] MenuViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Form verilerinin geçerli olmaması durumunda döndürülecek hata mesajlarını iyileştirin.
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return Json(new { success = false, message = "Form verileri geçerli değil.", errors = errors });
            }

            try
            {
                var menu = await _menuService.GetByIdAsync(model.Menu.Id);
                if (menu == null)
                {
                    return Json(new { success = false, message = "Güncellenecek menü bulunamadı." });
                }

                // Menü bilgilerini güncelle
                menu.MenuAdi = model.Menu.MenuAdi;
                menu.AnaMenuId = model.Menu.AnaMenuId;
                menu.BaglantiAdresi = model.Menu.BaglantiAdresi;
                menu.BagliSayfaId = model.Menu.BagliSayfaId;
                menu.MenuSira = model.Menu.MenuSira;
                menu.MenuAciklama = model.Menu.MenuAciklama;
                menu.MenuIcon = model.Menu.MenuIcon;
                menu.OtomatikListelemeId = model.Menu.OtomatikListelemeId;
                menu.OtomatikListelemeLimiti = model.Menu.OtomatikListelemeLimiti;
                menu.YeniPenceredeAc = model.Menu.YeniPenceredeAc;
                menu.Durum = model.Menu.Durum;

                await _menuService.UpdateAsync(menu);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama yaparak hata yönetimini güçlendirin.

                return Json(new { success = false, message = "Menü güncellenirken bir hata oluştu.", detail = ex.Message });
            }
        }



        public List<Menu> Menuler { get; set; }
        public MenuViewModel MenuModel { get; set; }


        public async Task<IActionResult> Index()
        {
            var menuler = await _menuService.GetAllAsync();
            MenuViewModel model = new MenuViewModel
            {
                Menuler = menuler
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetAnaMenuOptions(int menuYeriId)
        {
            var menus = await _menuService.GetAllAsync();
            menus = menus.Where(m => m.AnaMenuId == 0 && m.MenuYeriId == menuYeriId).ToList();
            return Json(menus.Select(m => new { id = m.Id, menuAdi = m.MenuAdi }));
        }



        [HttpPost]
        public async Task<IActionResult> AddMenu([FromForm] MenuViewModel model)
        {
            model.Menu.Durum = true;
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                return Json(new { success = false, message = "Veri doğrulama hatası.", errors = errors });
            }

            try
            {
                await _menuService.AddAsync(model.Menu);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public async Task<ActionResult> AddOrUpdate(int Id)
        {

            var menuler = await _menuService.GetAllAsync();

            MenuViewModel model = new MenuViewModel();
            model.Menu = await _menuService.GetByIdAsync(Id);
            model.Menuler = menuler;
            if (model.Menu == null)
            {
                Menu menu = new Menu
                {
                    Id = 0

                };
                model.Menu = menu;
            }
            return View(model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrUpdate(MenuViewModel model)
        {
            if (ModelState.IsValid)
            {


                if (model.Dosya != null)
                {
                    var path = $@"Files/Images/";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    var uzanti = Path.GetExtension(model.Dosya.FileName);
                    var resimAd = Guid.NewGuid() + uzanti;
                    var kaydedilecekYer = path + resimAd;
                    using var stream = new FileStream(kaydedilecekYer, FileMode.Create);
                    model.Dosya.CopyTo(stream);

                    model.Menu.OneCikanGorsel = resimAd;

                }


                if (model.Menu.Id == 0)
                {
                    model.Menu.Ekleme = DateTime.Now;
                    await _menuService.AddAsync(model.Menu);
                    return RedirectToAction("Index");
                }
                else
                {
                    var oldEntity = await _menuService.GetByIdAsync(model.Menu.Id);

                    if (model.Dosya == null)
                        model.Menu.OneCikanGorsel = oldEntity.OneCikanGorsel;

                    model.Menu.Ekleme = oldEntity.Ekleme;
                    await _menuService.UpdateAsync(model.Menu);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }


        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<JsonResult> UpdateMenuSection(int id, int newMenuYeriId)
        {
            var menu = await _menuService.GetByIdAsync(id);
            if (menu == null)
            {
                return Json(new { success = false, message = "Menu not found." });
            }

            try
            {
                menu.MenuYeriId = newMenuYeriId;  // Yeni bölge ID'si güncelleniyor
                await _menuService.UpdateAsync(menu);  // Güncellenmiş menüyü kaydet
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _menuService.DeleteAsync(id);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        //public JsonResult Delete(int id)
        //{
        //    if (id == 0)
        //    {
        //        return Json(0);
        //    }

        //    var itemIsValid = _menuService.GetById(id);
        //    if (itemIsValid == null)
        //    {
        //        return Json(0);
        //    }
        //    try
        //    {
        //        _menuService.Delete(itemIsValid.Id);
        //        return Json(1);
        //    }
        //    catch (Exception)
        //    {
        //        return Json(0);
        //    }
        //}


    }


}
