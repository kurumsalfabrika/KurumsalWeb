using Kurumsal.WebUI.Context;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kurumsal.WebUI.Models
{
    public class UserViewModel
    {

        public List<AppUser> AppUsers { get; set; }

        public string Fotograf { get; set; }
        [Required(ErrorMessage ="Lütfen Ad giriniz.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen Soyad giriniz.")]
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string AdresDevam { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string PostaKodu { get; set; }
        [Required(ErrorMessage = "Lütfen E-Posta adresi giriniz.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }
        public string Ulke { get; set; }
        public int UyelikTipi { get; set; }
        public string Gsm { get; set; }
        public bool SMSBilgilendirme { get; set; }
        public string TCKimlikNo { get; set; }
        public int DogumYili { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public int DovizTipi { get; set; }

        public string Password { get; set; }
        public string RePassword { get; set; }

        public IFormFile Dosya { get; set; }


    }
}
