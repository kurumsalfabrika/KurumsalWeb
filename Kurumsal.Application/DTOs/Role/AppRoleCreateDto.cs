namespace Kurumsal.Application.DTOs.Role
{
    public class AppRoleCreateDto
    {
        // TenantId DTO'da yok; ITenantProvider'dan alınacak (global yaratmak istersen null destekleyebiliriz)
        public string Name { get; set; } = null!;
        public string? Aciklama { get; set; }
        public bool GlobalRolMu { get; set; } = false; // true ise TenantId = null
    }
}
