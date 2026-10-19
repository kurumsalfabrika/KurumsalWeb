namespace Kurumsal.Application.DTOs.Sektor
{
    public class SektorUpdateDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}
