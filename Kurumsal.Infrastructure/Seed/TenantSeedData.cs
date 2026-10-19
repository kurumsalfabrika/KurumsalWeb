using Kurumsal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public static class TenantSeedData
{
    public static readonly Guid SystemTenantId = Guid.Parse("00000000-0000-0000-0000-000000000101");

    public static void Seed(ModelBuilder modelBuilder)
    {
        var created = new DateTime(2025, 1, 1);

        modelBuilder.Entity<Tenant>().HasData(new Tenant
        {
            Id = SystemTenantId,
            Kod = "TEN001",
            SirketAdi = "System Tenant",
            FaturaUnvani = "System Tenant",
            CreatedAt = created,
            IsDeleted = false
        });
    }
}
