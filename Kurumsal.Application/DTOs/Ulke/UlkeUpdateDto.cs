namespace Kurumsal.Application.DTOs.Ulke
{
    public class UlkeUpdateDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? TelefonKodu { get; set; }
    }
}
