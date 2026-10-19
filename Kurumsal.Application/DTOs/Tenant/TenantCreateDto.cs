using System;

namespace Kurumsal.Application.DTOs.Tenant
{
    public class TenantCreateDto
    {
        public string Kod { get; set; } = null!;

        public string SirketAdi { get; set; } = null!;
        public string FaturaUnvani { get; set; } = null!;
        public string? LogoUrl { get; set; }

        public bool SahisSirketiMi { get; set; } = false;
        public string? Ad { get; set; }
        public string? Soyad { get; set; }

        public Guid? DovizId { get; set; }

        public string? Telefon { get; set; }
        public string? Gsm { get; set; }
        public string? Faks { get; set; }
        public string? Eposta { get; set; }
        public string? WebSitesi { get; set; }

        public Guid? UlkeId { get; set; }
        public Guid? SehirId { get; set; }
        public Guid? IlceId { get; set; }
        public string? FaturaAdresi { get; set; }

        public string? IBAN { get; set; }
        public string? BankaAdi { get; set; }
        public string? VergiDairesi { get; set; }
        public string? TCKimlikNo { get; set; }
        public string? VergiNo { get; set; }
        public string? MersisNo { get; set; }
        public string? SicilNo { get; set; }

        public DateTime? LisansBaslangicTarihi { get; set; }
        public DateTime? LisansBitisTarihi { get; set; }
        public string? LisansTuru { get; set; }
        public bool LisansAktifMi { get; set; } = true;
    }
}
