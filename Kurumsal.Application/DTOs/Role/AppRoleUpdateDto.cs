namespace Kurumsal.Application.DTOs.Role
{
    public class AppRoleUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Aciklama { get; set; }
        // TenantId değiştirilmez
    }
}
