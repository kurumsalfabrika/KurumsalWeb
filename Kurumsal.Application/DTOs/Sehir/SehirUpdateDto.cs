namespace Kurumsal.Application.DTOs.Sehir
{
    public class SehirUpdateDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; }
        public Guid UlkeId { get; set; }
    }
}
