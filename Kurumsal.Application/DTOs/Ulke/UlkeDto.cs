namespace Kurumsal.Application.DTOs.Ulke
{
    public class UlkeDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; }
    }
}
