namespace Kurumsal.Application.DTOs.Doviz
{
    public class DovizDto
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }          // Eğer tenant token’dan okunacaksa çıkarabilirsin
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? Sembol { get; set; }         // $, €, ₺
        public string? Ulke { get; set; }           // Amerika, AB, Türkiye
        public decimal? AlisKuru { get; set; }
        public decimal? SatisKuru { get; set; }
        public decimal? ProgramKuru { get; set; }
        public bool AktifMi { get; set; } = true;
    }
}
