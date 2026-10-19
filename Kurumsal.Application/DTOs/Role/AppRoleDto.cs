namespace Kurumsal.Application.DTOs.Role
{
    public class AppRoleDto
    {
        public Guid Id { get; set; }
        public Guid? TenantId { get; set; }   // Global rol ise null
        public string Name { get; set; } = null!;
        public string? Aciklama { get; set; }
    }
}