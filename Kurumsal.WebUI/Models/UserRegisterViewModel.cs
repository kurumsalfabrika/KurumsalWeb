using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Ad alanı boş geçilemez!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez!")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "E-Mail alanı boş geçilemez!")]
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string AdresDevam { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public int UyelikTipi { get; set; }
        public string Gsm { get; set; }
        public bool SMSBilgilendirme { get; set; }
        public string TCKimlikNo { get; set; }
        public int DogumYili { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public int DovizTipi { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Parolalar birbiri ile eşleşmiyor! ")]
        public string RePassword { get; set; }
    }
}
