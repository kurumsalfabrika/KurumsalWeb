namespace Kurumsal.Application.DTOs.Doviz
{
    public class DovizCreateDto
    {
        public Guid TenantId { get; set; }          // Tenant’ı context’ten set ediyorsan bunu kaldır
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? Sembol { get; set; }
        public string? Ulke { get; set; }
        public decimal? AlisKuru { get; set; }
        public decimal? SatisKuru { get; set; }
        public decimal? ProgramKuru { get; set; }
        public bool AktifMi { get; set; } = true;
    }
}
