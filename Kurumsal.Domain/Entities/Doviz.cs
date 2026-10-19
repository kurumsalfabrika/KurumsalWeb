using Kurumsal.Domain.Entities.Base;

namespace Kurumsal.Domain.Entities
{
    public class Doviz : BaseTenantEntity
    {
        public string Ad { get; set; } = null!;   // USD, EUR, TRY (okunur ad)
        public string? Sembol { get; set; }       // $, €, ₺
        public string? Ulke { get; set; }         // Amerika, Avrupa Birliği, Türkiye

        // Opsiyonel kurlar (talebine göre ekledim)
        public decimal? AlisKuru { get; set; }    // Örn: 1 USD = X TL (alış)
        public decimal? SatisKuru { get; set; }   // Örn: 1 USD = X TL (satış)
        public decimal? ProgramKuru { get; set; } // Sistem içi sabit/özel kur

        public bool AktifMi { get; set; } = true;
    }
}
