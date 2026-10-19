using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurumsal.WebUI.Context
{
    public class AppUser:IdentityUser<int>
    {
        public string Fotograf { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
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
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
