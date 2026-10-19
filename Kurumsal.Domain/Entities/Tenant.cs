using Kurumsal.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Domain.Entities
{
    public class Tenant : BaseEntity
    {
        // Temel
        public string SirketAdi { get; set; } = null!;
        public string FaturaUnvani { get; set; } = null!;
        public string? LogoUrl { get; set; }

        // Şahıs şirketi opsiyonu
        public bool SahisSirketiMi { get; set; } = false;
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        [NotMapped]
        public string AdSoyad => $"{Ad} {Soyad}".Trim();

        // Finans / Para Birimi (tenant’a özel Doviz tablon varsa opsiyonel)
        public Guid? DovizId { get; set; }
        public Doviz? Doviz { get; set; }

        // İletişim
        public string? Telefon { get; set; }
        public string? Gsm { get; set; }
        public string? Faks { get; set; }
        public string? Eposta { get; set; }
        public string? WebSitesi { get; set; }

        // Adres
        public Guid? UlkeId { get; set; }
        public Ulke? Ulke { get; set; }
        public Guid? SehirId { get; set; }
        public Sehir? Sehir { get; set; }
        public Guid? IlceId { get; set; }
        public Ilce? Ilce { get; set; }
        public string? FaturaAdresi { get; set; }

        // Banka / Vergi
        public string? IBAN { get; set; }
        public string? BankaAdi { get; set; }
        public string? VergiDairesi { get; set; }
        public string? TCKimlikNo { get; set; } // şahıs için
        public string? VergiNo { get; set; }    // tüzel için
        public string? MersisNo { get; set; }
        public string? SicilNo { get; set; }

        // Lisans
        public DateTime? LisansBaslangicTarihi { get; set; }
        public DateTime? LisansBitisTarihi { get; set; }
        public string? LisansTuru { get; set; }
        public bool LisansAktifMi { get; set; } = true;

        public ICollection<AppUser> Kullanicilar { get; set; } = new List<AppUser>();
    }
}
