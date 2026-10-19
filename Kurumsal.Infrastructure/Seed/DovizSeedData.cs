using Kurumsal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public static class DovizSeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var created = new DateTime(2025, 1, 1);
        var tenantId = TenantSeedData.SystemTenantId;

        modelBuilder.Entity<Doviz>().HasData(new Doviz
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000001"),
            TenantId = tenantId,
            Kod = "TRY",
            Ad = "Türk Lirası",
            Sembol = "₺",
            Ulke = "Türkiye",
            AlisKuru= 1.0m,
            SatisKuru = 1.0m,
            ProgramKuru = 1.0m,
            AktifMi = true,
            IsDeleted = false,
            CreatedAt = created
        });
    }
}
