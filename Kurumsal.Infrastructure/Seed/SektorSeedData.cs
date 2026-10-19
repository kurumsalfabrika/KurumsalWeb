using Kurumsal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Seed
{
    public static class SektorSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var created = new DateTime(2025, 1, 1);

            modelBuilder.Entity<Sektor>().HasData(
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000001"), Kod = "SEK001", Ad = "SMMM Hizmetleri", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000002"), Kod = "SEK002", Ad = "Muhasebe / Finans", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000003"), Kod = "SEK003", Ad = "Tarım / Ziraat", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000004"), Kod = "SEK004", Ad = "Apartman / Site Yönetimi", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000005"), Kod = "SEK005", Ad = "Mimarlık", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000006"), Kod = "SEK006", Ad = "Otomotiv", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000007"), Kod = "SEK007", Ad = "Reklam / Tasarım / Medya", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000008"), Kod = "SEK008", Ad = "Eğitim / Danışmanlık", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000009"), Kod = "SEK009", Ad = "Enerji", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000010"), Kod = "SEK010", Ad = "E-Ticaret", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000011"), Kod = "SEK011", Ad = "Gıda", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000012"), Kod = "SEK012", Ad = "Sağlık Hizmetleri", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000013"), Kod = "SEK013", Ad = "Sigorta / Ekspertiz", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000014"), Kod = "SEK014", Ad = "Hukuk Hizmetleri", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000015"), Kod = "SEK015", Ad = "Lojistik", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000016"), Kod = "SEK016", Ad = "Basın / Yayın", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000017"), Kod = "SEK017", Ad = "Mikro İşletme / Esnaf", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000018"), Kod = "SEK018", Ad = "Üretim", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000019"), Kod = "SEK019", Ad = "Halkla İlişkiler & Organizasyon", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000020"), Kod = "SEK020", Ad = "İnşaat / Yapı / Gayrimenkul", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000021"), Kod = "SEK021", Ad = "Perakende", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000022"), Kod = "SEK022", Ad = "Yazılım / Teknoloji", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000023"), Kod = "SEK023", Ad = "Telekomünikasyon", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000024"), Kod = "SEK024", Ad = "Tekstil", CreatedAt = created, IsDeleted = false },
                new Sektor { Id = Guid.Parse("20000000-0000-0000-0000-000000000025"), Kod = "SEK025", Ad = "Turizm", CreatedAt = created, IsDeleted = false }
            );
        }
    }
}
