namespace Kurumsal.Application.DTOs.Ilce
{
    public class IlceUpdateDto
    {
        public Guid Id { get; set; }
        public string Kod { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public Guid SehirId { get; set; }
    }
}
