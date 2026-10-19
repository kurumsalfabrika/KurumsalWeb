namespace Kurumsal.Application.DTOs.Ulke
{
    public class UlkeCreateDto
    {
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; }
    }
}
