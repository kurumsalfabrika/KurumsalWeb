using Kurumsal.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Kurumsal.Entities.Concrete
{
	public class Rezervasyon : IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required(ErrorMessage = "Ad Soyad zorunludur")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi zorunludur")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        public string Eposta { get; set; }
        [Required(ErrorMessage = "Telefon zorunludur")]
        public string Telefon { get; set; }
        public string Not { get; set; }
        public int OdaId { get; set; }
        [Required(ErrorMessage = "Giriş Tarihi zorunludur")]
        public DateTime GirisTarihi { get; set; }=DateTime.Now;
        [Required(ErrorMessage = "Çıkış Tarihi zorunludur")]
        public DateTime CikisTarihi { get; set; } = DateTime.Now.AddMonths(1);
        public int ToplamGun { get; set; }
        public decimal GunlukUcret { get; set; }
        public string GunlukUcretDovizKodu { get; set; }
        public string GunlukUcretDovizAdi { get; set; }
        public decimal ToplamTutar { get; set; }
        [Required(ErrorMessage = "T.C. Kimlik No zorunludur")]
        public string TCKimlikNo { get; set; }
        public string VergiNo { get; set; }
        public string FirmaAdi { get; set; }
        [Required(ErrorMessage = "Fatura Adresi zorunludur")]
        public string FaturaAdresi { get; set; }
        public string VergiDairesi { get; set; }
        public int? OdemeKayitId { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
        public string KayitIP { get; set; }


        public string ClientId { get; set; }
        public string Amount { get; set; }

        public string TranType { get; set; }
        public string? Instalment { get; set; }
        public string Rnd { get; set; }
        public string CallbackUrl { get; set; }
        public string Currency { get; set; }



        public string Lang { get; set; }
        public string HashAlgorithm { get; set; }
        public string StoreType { get; set; }




    } 
}
