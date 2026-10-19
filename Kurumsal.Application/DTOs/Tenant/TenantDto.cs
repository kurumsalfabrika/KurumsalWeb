using System;

namespace Kurumsal.Application.DTOs.Tenant
{
    public class TenantDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;

        // Temel
        public string SirketAdi { get; set; } = null!;
        public string FaturaUnvani { get; set; } = null!;
        public string? LogoUrl { get; set; }

        // Şahıs şirketi
        public bool SahisSirketiMi { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }

        // Finans / para birimi
        public Guid? DovizId { get; set; }

        // İletişim
        public string? Telefon { get; set; }
        public string? Gsm { get; set; }
        public string? Faks { get; set; }
        public string? Eposta { get; set; }
        public string? WebSitesi { get; set; }

        // Adres
        public Guid? UlkeId { get; set; }
        public Guid? SehirId { get; set; }
        public Guid? IlceId { get; set; }
        public string? FaturaAdresi { get; set; }

        // Banka / Vergi
        public string? IBAN { get; set; }
        public string? BankaAdi { get; set; }
        public string? VergiDairesi { get; set; }
        public string? TCKimlikNo { get; set; }
        public string? VergiNo { get; set; }
        public string? MersisNo { get; set; }
        public string? SicilNo { get; set; }

        // Lisans
        public DateTime? LisansBaslangicTarihi { get; set; }
        public DateTime? LisansBitisTarihi { get; set; }
        public string? LisansTuru { get; set; }
        public bool LisansAktifMi { get; set; }
    }
}
