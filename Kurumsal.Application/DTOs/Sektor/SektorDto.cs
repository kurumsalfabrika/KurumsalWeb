namespace Kurumsal.Application.DTOs.Sektor
{
    public class SektorDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
