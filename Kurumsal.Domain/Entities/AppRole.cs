using Microsoft.AspNetCore.Identity;
using System;

namespace Kurumsal.Domain.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public Guid? TenantId { get; set; } // roller global kalsın istersen nullable bırak
        public string? Aciklama { get; set; }
    }
}
