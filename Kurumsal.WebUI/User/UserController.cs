using Kurumsal.WebUI.Context;
using Kurumsal.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.User
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserViewModel model = new UserViewModel();

            model.AppUsers = _userManager.Users.ToList();
     
            return View(model);

        }


        public async Task<IActionResult> Profil()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserViewModel model = new UserViewModel
            {
                Ad=user.Ad,
                Soyad=user.Soyad,
                Adres=user.Adres,
                AdresDevam=user.AdresDevam,
                DogumYili=user.DogumYili,
                DovizTipi=user.DovizTipi,
                Email=user.Email,
                Ulke=user.Ulke,
                FirmaAdi=user.FirmaAdi,
                Fotograf=user.Fotograf,
                Gsm=user.Gsm,
                Ilce=user.Ilce,
                PostaKodu=user.PostaKodu,
                Sehir=user.Sehir,
                SMSBilgilendirme=user.SMSBilgilendirme,
                TCKimlikNo=user.TCKimlikNo,
                Telefon=user.Telefon,
                UyelikTipi=user.UyelikTipi,
                VergiDairesi=user.VergiDairesi,
                VergiNo=user.VergiNo
            };

            return View(model);

        }

        public async Task<IActionResult> Update()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserViewModel model = new UserViewModel() { 
            Ad=user.Ad,
            Soyad=user.Soyad,
            Sehir=user.Sehir,
            Telefon=user.Telefon,
            Email=user.Email,
            Adres=user.Adres,
            AdresDevam=user.AdresDevam,
            DogumYili=user.DogumYili,
            DovizTipi=user.DovizTipi,
            Fotograf=user.Fotograf,
            FirmaAdi=user.FirmaAdi,
            Gsm=user.Gsm,
            Ilce=user.Ilce,
            PostaKodu=user.PostaKodu,
            TCKimlikNo=user.TCKimlikNo,
            SMSBilgilendirme=user.SMSBilgilendirme,
            Ulke=user.Ulke,
            UyelikTipi=user.UyelikTipi,
            VergiDairesi=user.VergiDairesi,
            VergiNo=user.VergiNo
            };
            model.AppUsers = _userManager.Users.ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                if(model.Dosya!=null)
                {
                    var uygulamaPath= Directory.GetCurrentDirectory();
                    var uzanti = Path.GetExtension(model.Dosya.FileName);
                    var resimAd = Guid.NewGuid().ToString();
                    var kaydedilecekYer = uygulamaPath + "/wwwroot/Images/" + resimAd+uzanti;
                   using var stream = new FileStream(kaydedilecekYer, FileMode.Create);

                    await model.Dosya.CopyToAsync(stream);
                    user.Fotograf = resimAd + uzanti;
                }

                AppUser newUser = new AppUser
                {
                    Ad = model.Ad,
                    Soyad = model.Soyad,
                    Sehir = model.Sehir,
                    Telefon = model.Telefon,
                    Email = model.Email,
                    Adres = model.Adres,
                    AdresDevam = model.AdresDevam,
                    DogumYili = model.DogumYili,
                    DovizTipi = model.DovizTipi,
                    Fotograf = user.Fotograf,
                    FirmaAdi = model.FirmaAdi,
                    Gsm = model.Gsm,
                    Ilce = model.Ilce,
                    PostaKodu = model.PostaKodu,
                    TCKimlikNo = model.TCKimlikNo,
                    SMSBilgilendirme = model.SMSBilgilendirme,
                    Ulke = model.Ulke,
                    UyelikTipi = model.UyelikTipi,
                    VergiDairesi = model.VergiDairesi,
                    VergiNo = model.VergiNo
                };


                var result = await _userManager.UpdateAsync(user);


                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);

                }
            }

            return View(model);
        }


        public async Task<IActionResult> Login()
        {
            return View(new UserLoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {

            if(ModelState.IsValid)
            {
             var identityResult =  await  _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

                if(identityResult.IsLockedOut)
                {
                    var gelen = await _userManager.GetLockoutEndDateAsync(await _userManager.FindByNameAsync(model.Email));
                    var kisitlananSure = gelen.Value;
                    var kalanDakika = kisitlananSure.Minute-DateTime.Now.Minute;
                    ModelState.AddModelError("", $"5 Kere yanlış denemeden dolayı hesabınız kilitlendi! {kalanDakika} dakika sonra açılacak!");
                    return View("Login", model);
                }

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }

                if (identityResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", $"E-Mail adresinizi lütfen doğrulayınız!");
                    return View("Login", model);
                };


                var yanlisGirilmeSayisi = 0;
                ModelState.AddModelError("", $"Kullanıcı Adı veya Şifre hatalı!");
                if (_userManager!=null)
                {
                    try
                    {
                        yanlisGirilmeSayisi = await _userManager.GetAccessFailedCountAsync(await _userManager.FindByNameAsync(model.Email));
                        ModelState.AddModelError("", $"{5-yanlisGirilmeSayisi} deneme hakkınız kaldı!");
                    }
                    catch (Exception)
                    {

                    }
                        
                }
   
            }
            return View("Login",model);
        }


        public IActionResult Register()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {

            if(ModelState.IsValid)
            {

                AppUser user = new AppUser
                {
                    Ad = model.Ad,
                    UserName = model.Email,
                    Soyad = model.Soyad,
                    Email = model.Email,
                    Telefon = model.Telefon,
                    FirmaAdi = model.FirmaAdi,
                    Adres = model.Adres,
                    AdresDevam = model.AdresDevam,
                    Sehir = model.Sehir,
                    Ilce = model.Ilce,
                    PostaKodu = model.PostaKodu,
                    Ulke = model.Ulke,
                    UyelikTipi = model.UyelikTipi,
                    Gsm = model.Gsm,
                    SMSBilgilendirme = model.SMSBilgilendirme,
                    TCKimlikNo = model.TCKimlikNo,
                    DogumYili = model.DogumYili,
                    VergiDairesi = model.VergiDairesi,
                    VergiNo = model.VergiNo,
                    DovizTipi = model.DovizTipi

                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

       
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();  
            return RedirectToAction("Login", "User");  
        }


    }
}
