namespace Kurumsal.Application.DTOs.Ilce
{
    public class IlceDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public Guid SehirId { get; set; }
        public string SehirAd { get; set; } = null!; // Navigation'dan gösterim için
    }
}
