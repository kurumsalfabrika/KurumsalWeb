namespace Kurumsal.Application.DTOs.Sektor
{
    public class SektorCreateDto
    {
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
