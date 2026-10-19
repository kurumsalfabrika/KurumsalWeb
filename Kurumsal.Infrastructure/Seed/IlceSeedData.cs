using Kurumsal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.Infrastructure.Seed
{
    public static class IlceSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var createdDate = new DateTime(2025, 1, 1);

            // Sehir Id'leri (SehirSeedData'daki GUID'lerle birebir)
            var adanaId = Guid.Parse("10000000-0000-0000-0000-000000000001"); // 01
            var adiyamanId = Guid.Parse("10000000-0000-0000-0000-000000000002"); // 02
            var afyonId = Guid.Parse("10000000-0000-0000-0000-000000000003"); // 03
            var agriId = Guid.Parse("10000000-0000-0000-0000-000000000004"); // 04
            var amasyaId = Guid.Parse("10000000-0000-0000-0000-000000000005"); // 05
            var ankaraId = Guid.Parse("10000000-0000-0000-0000-000000000006"); // 06
            var antalyaId = Guid.Parse("10000000-0000-0000-0000-000000000007"); // 07
            var artvinId = Guid.Parse("10000000-0000-0000-0000-000000000008"); // 08
            var aydinId = Guid.Parse("10000000-0000-0000-0000-000000000009"); // 09
            var balikesirId = Guid.Parse("10000000-0000-0000-0000-000000000010"); // 10

            modelBuilder.Entity<Ilce>().HasData(
                // 01 — Adana (15)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000001"), Kod = "01-01", Ad = "Aladağ", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000002"), Kod = "01-02", Ad = "Ceyhan", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000003"), Kod = "01-03", Ad = "Çukurova", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000004"), Kod = "01-04", Ad = "Feke", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000005"), Kod = "01-05", Ad = "İmamoğlu", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000006"), Kod = "01-06", Ad = "Karaisalı", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000007"), Kod = "01-07", Ad = "Karataş", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000008"), Kod = "01-08", Ad = "Kozan", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000009"), Kod = "01-09", Ad = "Pozantı", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000010"), Kod = "01-10", Ad = "Saimbeyli", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000011"), Kod = "01-11", Ad = "Sarıçam", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000012"), Kod = "01-12", Ad = "Seyhan", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000013"), Kod = "01-13", Ad = "Tufanbeyli", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000014"), Kod = "01-14", Ad = "Yüreğir", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000015"), Kod = "01-15", Ad = "Yumurtalık", SehirId = adanaId, CreatedAt = createdDate, IsDeleted = false },

                // 02 — Adıyaman (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000016"), Kod = "02-01", Ad = "Merkez", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000017"), Kod = "02-02", Ad = "Besni", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000018"), Kod = "02-03", Ad = "Çelikhan", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000019"), Kod = "02-04", Ad = "Gerger", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000020"), Kod = "02-05", Ad = "Gölbaşı", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000021"), Kod = "02-06", Ad = "Kahta", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000022"), Kod = "02-07", Ad = "Samsat", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000023"), Kod = "02-08", Ad = "Sincik", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000024"), Kod = "02-09", Ad = "Tut", SehirId = adiyamanId, CreatedAt = createdDate, IsDeleted = false },

                // 03 — Afyonkarahisar (18)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000025"), Kod = "03-01", Ad = "Merkez", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000026"), Kod = "03-02", Ad = "Başmakçı", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000027"), Kod = "03-03", Ad = "Bayat", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000028"), Kod = "03-04", Ad = "Bolvadin", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000029"), Kod = "03-05", Ad = "Çay", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000030"), Kod = "03-06", Ad = "Çobanlar", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000031"), Kod = "03-07", Ad = "Dazkırı", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000032"), Kod = "03-08", Ad = "Dinar", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000033"), Kod = "03-09", Ad = "Emirdağ", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000034"), Kod = "03-10", Ad = "Evciler", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000035"), Kod = "03-11", Ad = "Hocalar", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000036"), Kod = "03-12", Ad = "İhsaniye", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000037"), Kod = "03-13", Ad = "İscehisar", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000038"), Kod = "03-14", Ad = "Kızılören", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000039"), Kod = "03-15", Ad = "Sandıklı", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000040"), Kod = "03-16", Ad = "Sinanpaşa", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000041"), Kod = "03-17", Ad = "Sultandağı", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000042"), Kod = "03-18", Ad = "Şuhut", SehirId = afyonId, CreatedAt = createdDate, IsDeleted = false },

                // 04 — Ağrı (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000043"), Kod = "04-01", Ad = "Merkez", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000044"), Kod = "04-02", Ad = "Diyadin", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000045"), Kod = "04-03", Ad = "Doğubayazıt", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000046"), Kod = "04-04", Ad = "Eleşkirt", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000047"), Kod = "04-05", Ad = "Hamur", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000048"), Kod = "04-06", Ad = "Patnos", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000049"), Kod = "04-07", Ad = "Taşlıçay", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000050"), Kod = "04-08", Ad = "Tutak", SehirId = agriId, CreatedAt = createdDate, IsDeleted = false },

                // 05 — Amasya (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000051"), Kod = "05-01", Ad = "Merkez", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000052"), Kod = "05-02", Ad = "Göynücek", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000053"), Kod = "05-03", Ad = "Gümüşhacıköy", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000054"), Kod = "05-04", Ad = "Hamamözü", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000055"), Kod = "05-05", Ad = "Merzifon", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000056"), Kod = "05-06", Ad = "Suluova", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000057"), Kod = "05-07", Ad = "Taşova", SehirId = amasyaId, CreatedAt = createdDate, IsDeleted = false },

    // 06 — Ankara (25)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000058"), Kod = "06-01", Ad = "Altındağ", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000059"), Kod = "06-02", Ad = "Akyurt", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000060"), Kod = "06-03", Ad = "Ayaş", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000061"), Kod = "06-04", Ad = "Bala", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000062"), Kod = "06-05", Ad = "Beypazarı", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000063"), Kod = "06-06", Ad = "Çamlıdere", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000064"), Kod = "06-07", Ad = "Çankaya", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000065"), Kod = "06-08", Ad = "Çubuk", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000066"), Kod = "06-09", Ad = "Elmadağ", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000067"), Kod = "06-10", Ad = "Etimesgut", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000068"), Kod = "06-11", Ad = "Evren", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000069"), Kod = "06-12", Ad = "Gölbaşı", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000070"), Kod = "06-13", Ad = "Güdül", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000071"), Kod = "06-14", Ad = "Haymana", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000072"), Kod = "06-15", Ad = "Kahramankazan", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false }, // (eski: Kazan)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000073"), Kod = "06-16", Ad = "Kalecik", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000074"), Kod = "06-17", Ad = "Keçiören", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000075"), Kod = "06-18", Ad = "Kızılcahamam", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000076"), Kod = "06-19", Ad = "Mamak", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000077"), Kod = "06-20", Ad = "Nallıhan", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000078"), Kod = "06-21", Ad = "Polatlı", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000079"), Kod = "06-22", Ad = "Pursaklar", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000080"), Kod = "06-23", Ad = "Sincan", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000081"), Kod = "06-24", Ad = "Şereflikoçhisar", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000082"), Kod = "06-25", Ad = "Yenimahalle", SehirId = ankaraId, CreatedAt = createdDate, IsDeleted = false },

    // 07 — Antalya (19)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000083"), Kod = "07-01", Ad = "Akseki", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000084"), Kod = "07-02", Ad = "Aksu", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000085"), Kod = "07-03", Ad = "Alanya", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000086"), Kod = "07-04", Ad = "Demre", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false }, // (eski: Kale)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000087"), Kod = "07-05", Ad = "Döşemealtı", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000088"), Kod = "07-06", Ad = "Elmalı", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000089"), Kod = "07-07", Ad = "Finike", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000090"), Kod = "07-08", Ad = "Gazipaşa", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000091"), Kod = "07-09", Ad = "Gündoğmuş", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000092"), Kod = "07-10", Ad = "İbradı", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000093"), Kod = "07-11", Ad = "Kaş", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000094"), Kod = "07-12", Ad = "Kemer", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000095"), Kod = "07-13", Ad = "Kepez", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000096"), Kod = "07-14", Ad = "Konyaaltı", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000097"), Kod = "07-15", Ad = "Korkuteli", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000098"), Kod = "07-16", Ad = "Kumluca", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000099"), Kod = "07-17", Ad = "Manavgat", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000100"), Kod = "07-18", Ad = "Muratpaşa", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000101"), Kod = "07-19", Ad = "Serik", SehirId = antalyaId, CreatedAt = createdDate, IsDeleted = false },

    // 08 — Artvin (9)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000102"), Kod = "08-01", Ad = "Ardanuç", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000103"), Kod = "08-02", Ad = "Arhavi", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000104"), Kod = "08-03", Ad = "Borçka", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000105"), Kod = "08-04", Ad = "Hopa", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000106"), Kod = "08-05", Ad = "Kemalpaşa", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000107"), Kod = "08-06", Ad = "Murgul", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000108"), Kod = "08-07", Ad = "Şavşat", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000109"), Kod = "08-08", Ad = "Yusufeli", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000110"), Kod = "08-09", Ad = "Merkez", SehirId = artvinId, CreatedAt = createdDate, IsDeleted = false },

    // 09 — Aydın (17)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000111"), Kod = "09-01", Ad = "Bozdoğan", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000112"), Kod = "09-02", Ad = "Buharkent", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000113"), Kod = "09-03", Ad = "Çine", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000114"), Kod = "09-04", Ad = "Didim", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000115"), Kod = "09-05", Ad = "Efeler", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000116"), Kod = "09-06", Ad = "Germencik", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000117"), Kod = "09-07", Ad = "İncirliova", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000118"), Kod = "09-08", Ad = "Karacasu", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000119"), Kod = "09-09", Ad = "Karpuzlu", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000120"), Kod = "09-10", Ad = "Koçarlı", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000121"), Kod = "09-11", Ad = "Köşk", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000122"), Kod = "09-12", Ad = "Kuşadası", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000123"), Kod = "09-13", Ad = "Kuyucak", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000124"), Kod = "09-14", Ad = "Nazilli", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000125"), Kod = "09-15", Ad = "Söke", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000126"), Kod = "09-16", Ad = "Sultanhisar", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000127"), Kod = "09-17", Ad = "Yenipazar", SehirId = aydinId, CreatedAt = createdDate, IsDeleted = false },

    // 10 — Balıkesir (20)
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000128"), Kod = "10-01", Ad = "Altıeylül", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000129"), Kod = "10-02", Ad = "Ayvalık", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000130"), Kod = "10-03", Ad = "Balya", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000131"), Kod = "10-04", Ad = "Bandırma", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000132"), Kod = "10-05", Ad = "Bigadiç", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000133"), Kod = "10-06", Ad = "Burhaniye", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000134"), Kod = "10-07", Ad = "Dursunbey", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000135"), Kod = "10-08", Ad = "Edremit", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000136"), Kod = "10-09", Ad = "Erdek", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000137"), Kod = "10-10", Ad = "Gömeç", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000138"), Kod = "10-11", Ad = "Gönen", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000139"), Kod = "10-12", Ad = "Havran", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000140"), Kod = "10-13", Ad = "İvrindi", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000141"), Kod = "10-14", Ad = "Karesi", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000142"), Kod = "10-15", Ad = "Kepsut", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000143"), Kod = "10-16", Ad = "Manyas", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000144"), Kod = "10-17", Ad = "Marmara", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000145"), Kod = "10-18", Ad = "Savaştepe", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000146"), Kod = "10-19", Ad = "Sındırgı", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false },
    new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000147"), Kod = "10-20", Ad = "Susurluk", SehirId = balikesirId, CreatedAt = createdDate, IsDeleted = false }


                );



            // 11–15 şehir Id'leri (SehirSeedData'daki GUID'lerle birebir olmalı)
            var bilecikId = Guid.Parse("10000000-0000-0000-0000-000000000011"); // 11
            var bingolId = Guid.Parse("10000000-0000-0000-0000-000000000012"); // 12
            var bitlisId = Guid.Parse("10000000-0000-0000-0000-000000000013"); // 13
            var boluId = Guid.Parse("10000000-0000-0000-0000-000000000014"); // 14
            var burdurId = Guid.Parse("10000000-0000-0000-0000-000000000015"); // 15

            modelBuilder.Entity<Ilce>().HasData(
                // 11 — Bilecik (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000148"), Kod = "11-01", Ad = "Merkez", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000149"), Kod = "11-02", Ad = "Bozüyük", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000150"), Kod = "11-03", Ad = "Gölpazarı", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000151"), Kod = "11-04", Ad = "İnhisar", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000152"), Kod = "11-05", Ad = "Osmaneli", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000153"), Kod = "11-06", Ad = "Pazaryeri", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000154"), Kod = "11-07", Ad = "Söğüt", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000155"), Kod = "11-08", Ad = "Yenipazar", SehirId = bilecikId, CreatedAt = createdDate, IsDeleted = false },

                // 12 — Bingöl (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000156"), Kod = "12-01", Ad = "Merkez", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000157"), Kod = "12-02", Ad = "Adaklı", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000158"), Kod = "12-03", Ad = "Genç", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000159"), Kod = "12-04", Ad = "Karlıova", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000160"), Kod = "12-05", Ad = "Kiğı", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000161"), Kod = "12-06", Ad = "Solhan", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000162"), Kod = "12-07", Ad = "Yayladere", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000163"), Kod = "12-08", Ad = "Yedisu", SehirId = bingolId, CreatedAt = createdDate, IsDeleted = false },

                // 13 — Bitlis (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000164"), Kod = "13-01", Ad = "Merkez", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000165"), Kod = "13-02", Ad = "Adilcevaz", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000166"), Kod = "13-03", Ad = "Ahlat", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000167"), Kod = "13-04", Ad = "Güroymak", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false }, // (eski: Norşin)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000168"), Kod = "13-05", Ad = "Hizan", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000169"), Kod = "13-06", Ad = "Mutki", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000170"), Kod = "13-07", Ad = "Tatvan", SehirId = bitlisId, CreatedAt = createdDate, IsDeleted = false },

                // 14 — Bolu (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000171"), Kod = "14-01", Ad = "Merkez", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000172"), Kod = "14-02", Ad = "Dörtdivan", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000173"), Kod = "14-03", Ad = "Gerede", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000174"), Kod = "14-04", Ad = "Göynük", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000175"), Kod = "14-05", Ad = "Kıbrıscık", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000176"), Kod = "14-06", Ad = "Mengen", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000177"), Kod = "14-07", Ad = "Mudurnu", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000178"), Kod = "14-08", Ad = "Seben", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000179"), Kod = "14-09", Ad = "Yeniçağa", SehirId = boluId, CreatedAt = createdDate, IsDeleted = false },

                // 15 — Burdur (11)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000180"), Kod = "15-01", Ad = "Merkez", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000181"), Kod = "15-02", Ad = "Ağlasun", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000182"), Kod = "15-03", Ad = "Altınyayla", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false }, // (Dirmil)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000183"), Kod = "15-04", Ad = "Bucak", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000184"), Kod = "15-05", Ad = "Çavdır", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000185"), Kod = "15-06", Ad = "Çeltikçi", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000186"), Kod = "15-07", Ad = "Gölhisar", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000187"), Kod = "15-08", Ad = "Karamanlı", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000188"), Kod = "15-09", Ad = "Kemer", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000189"), Kod = "15-10", Ad = "Tefenni", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000190"), Kod = "15-11", Ad = "Yeşilova", SehirId = burdurId, CreatedAt = createdDate, IsDeleted = false }
            );

            // 16–20 şehir Id'leri (SehirSeedData'daki GUID'lerle birebir olmalı)
            var bursaId = Guid.Parse("10000000-0000-0000-0000-000000000016"); // 16
            var canakkaleId = Guid.Parse("10000000-0000-0000-0000-000000000017"); // 17
            var cankiriId = Guid.Parse("10000000-0000-0000-0000-000000000018"); // 18
            var corumId = Guid.Parse("10000000-0000-0000-0000-000000000019"); // 19
            var denizliId = Guid.Parse("10000000-0000-0000-0000-000000000020"); // 20

            modelBuilder.Entity<Ilce>().HasData(
                // 16 — Bursa (17)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000191"), Kod = "16-01", Ad = "Büyükorhan", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000192"), Kod = "16-02", Ad = "Gemlik", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000193"), Kod = "16-03", Ad = "Gürsu", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000194"), Kod = "16-04", Ad = "Harmancık", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000195"), Kod = "16-05", Ad = "İnegöl", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000196"), Kod = "16-06", Ad = "İznik", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000197"), Kod = "16-07", Ad = "Karacabey", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000198"), Kod = "16-08", Ad = "Keles", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000199"), Kod = "16-09", Ad = "Kestel", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000200"), Kod = "16-10", Ad = "Mudanya", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000201"), Kod = "16-11", Ad = "Mustafakemalpaşa", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000202"), Kod = "16-12", Ad = "Nilüfer", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000203"), Kod = "16-13", Ad = "Orhaneli", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000204"), Kod = "16-14", Ad = "Orhangazi", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000205"), Kod = "16-15", Ad = "Osmangazi", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000206"), Kod = "16-16", Ad = "Yenişehir", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000207"), Kod = "16-17", Ad = "Yıldırım", SehirId = bursaId, CreatedAt = createdDate, IsDeleted = false },

                // 17 — Çanakkale (12)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000208"), Kod = "17-01", Ad = "Ayvacık", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000209"), Kod = "17-02", Ad = "Bayramiç", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000210"), Kod = "17-03", Ad = "Biga", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000211"), Kod = "17-04", Ad = "Bozcaada", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000212"), Kod = "17-05", Ad = "Çan", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000213"), Kod = "17-06", Ad = "Eceabat", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000214"), Kod = "17-07", Ad = "Ezine", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000215"), Kod = "17-08", Ad = "Gelibolu", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000216"), Kod = "17-09", Ad = "Gökçeada", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000217"), Kod = "17-10", Ad = "Lapseki", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000218"), Kod = "17-11", Ad = "Merkez", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000219"), Kod = "17-12", Ad = "Yenice", SehirId = canakkaleId, CreatedAt = createdDate, IsDeleted = false },

                // 18 — Çankırı (12)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000220"), Kod = "18-01", Ad = "Atkaracalar", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000221"), Kod = "18-02", Ad = "Bayramören", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000222"), Kod = "18-03", Ad = "Çerkeş", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000223"), Kod = "18-04", Ad = "Eldivan", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000224"), Kod = "18-05", Ad = "Ilgaz", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000225"), Kod = "18-06", Ad = "Kızılırmak", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000226"), Kod = "18-07", Ad = "Korgun", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000227"), Kod = "18-08", Ad = "Kurşunlu", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000228"), Kod = "18-09", Ad = "Merkez", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000229"), Kod = "18-10", Ad = "Orta", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000230"), Kod = "18-11", Ad = "Şabanözü", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000231"), Kod = "18-12", Ad = "Yapraklı", SehirId = cankiriId, CreatedAt = createdDate, IsDeleted = false },

                // 19 — Çorum (14)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000232"), Kod = "19-01", Ad = "Alaca", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000233"), Kod = "19-02", Ad = "Bayat", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000234"), Kod = "19-03", Ad = "Boğazkale", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000235"), Kod = "19-04", Ad = "Dodurga", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000236"), Kod = "19-05", Ad = "İskilip", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000237"), Kod = "19-06", Ad = "Kargı", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000238"), Kod = "19-07", Ad = "Laçin", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000239"), Kod = "19-08", Ad = "Mecitözü", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000240"), Kod = "19-09", Ad = "Merkez", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000241"), Kod = "19-10", Ad = "Oğuzlar", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000242"), Kod = "19-11", Ad = "Ortaköy", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000243"), Kod = "19-12", Ad = "Osmancık", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000244"), Kod = "19-13", Ad = "Sungurlu", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000245"), Kod = "19-14", Ad = "Uğurludağ", SehirId = corumId, CreatedAt = createdDate, IsDeleted = false },

                // 20 — Denizli (19)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000246"), Kod = "20-01", Ad = "Acıpayam", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000247"), Kod = "20-02", Ad = "Babadağ", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000248"), Kod = "20-03", Ad = "Baklan", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000249"), Kod = "20-04", Ad = "Bekilli", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000250"), Kod = "20-05", Ad = "Beyağaç", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000251"), Kod = "20-06", Ad = "Bozkurt", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000252"), Kod = "20-07", Ad = "Buldan", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000253"), Kod = "20-08", Ad = "Çal", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000254"), Kod = "20-09", Ad = "Çameli", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000255"), Kod = "20-10", Ad = "Çardak", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000256"), Kod = "20-11", Ad = "Çivril", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000257"), Kod = "20-12", Ad = "Güney", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000258"), Kod = "20-13", Ad = "Honaz", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000259"), Kod = "20-14", Ad = "Kale", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000260"), Kod = "20-15", Ad = "Merkezefendi", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000261"), Kod = "20-16", Ad = "Pamukkale", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000262"), Kod = "20-17", Ad = "Sarayköy", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000263"), Kod = "20-18", Ad = "Serinhisar", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000264"), Kod = "20-19", Ad = "Tavas", SehirId = denizliId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 21–25 şehir Id'leri (SehirSeedData’daki GUID’lerle birebir olmalı)
            var diyarbakirId = Guid.Parse("10000000-0000-0000-0000-000000000021"); // 21
            var edirneId = Guid.Parse("10000000-0000-0000-0000-000000000022"); // 22
            var elazigId = Guid.Parse("10000000-0000-0000-0000-000000000023"); // 23
            var erzincanId = Guid.Parse("10000000-0000-0000-0000-000000000024"); // 24
            var erzurumId = Guid.Parse("10000000-0000-0000-0000-000000000025"); // 25

            modelBuilder.Entity<Ilce>().HasData(
                // 21 — Diyarbakır (17)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000265"), Kod = "21-01", Ad = "Bağlar", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000266"), Kod = "21-02", Ad = "Bismil", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000267"), Kod = "21-03", Ad = "Çermik", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000268"), Kod = "21-04", Ad = "Çınar", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000269"), Kod = "21-05", Ad = "Çüngüş", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000270"), Kod = "21-06", Ad = "Dicle", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000271"), Kod = "21-07", Ad = "Eğil", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000272"), Kod = "21-08", Ad = "Ergani", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000273"), Kod = "21-09", Ad = "Hani", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000274"), Kod = "21-10", Ad = "Hazro", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000275"), Kod = "21-11", Ad = "Kayapınar", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000276"), Kod = "21-12", Ad = "Kocaköy", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000277"), Kod = "21-13", Ad = "Kulp", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000278"), Kod = "21-14", Ad = "Lice", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000279"), Kod = "21-15", Ad = "Silvan", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000280"), Kod = "21-16", Ad = "Sur", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000281"), Kod = "21-17", Ad = "Yenişehir", SehirId = diyarbakirId, CreatedAt = createdDate, IsDeleted = false },

                // 22 — Edirne (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000282"), Kod = "22-01", Ad = "Merkez", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000283"), Kod = "22-02", Ad = "Enez", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000284"), Kod = "22-03", Ad = "Havsa", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000285"), Kod = "22-04", Ad = "İpsala", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000286"), Kod = "22-05", Ad = "Keşan", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000287"), Kod = "22-06", Ad = "Lalapaşa", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000288"), Kod = "22-07", Ad = "Meriç", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000289"), Kod = "22-08", Ad = "Süloğlu", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000290"), Kod = "22-09", Ad = "Uzunköprü", SehirId = edirneId, CreatedAt = createdDate, IsDeleted = false },

                // 23 — Elazığ (11)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000291"), Kod = "23-01", Ad = "Merkez", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000292"), Kod = "23-02", Ad = "Ağın", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000293"), Kod = "23-03", Ad = "Alacakaya", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000294"), Kod = "23-04", Ad = "Arıcak", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000295"), Kod = "23-05", Ad = "Baskil", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000296"), Kod = "23-06", Ad = "Karakoçan", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000297"), Kod = "23-07", Ad = "Keban", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000298"), Kod = "23-08", Ad = "Kovancılar", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000299"), Kod = "23-09", Ad = "Maden", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000300"), Kod = "23-10", Ad = "Palu", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000301"), Kod = "23-11", Ad = "Sivrice", SehirId = elazigId, CreatedAt = createdDate, IsDeleted = false },

                // 24 — Erzincan (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000302"), Kod = "24-01", Ad = "Merkez", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000303"), Kod = "24-02", Ad = "Çayırlı", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000304"), Kod = "24-03", Ad = "İliç", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000305"), Kod = "24-04", Ad = "Kemah", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000306"), Kod = "24-05", Ad = "Kemaliye", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000307"), Kod = "24-06", Ad = "Otlukbeli", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000308"), Kod = "24-07", Ad = "Refahiye", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000309"), Kod = "24-08", Ad = "Tercan", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000310"), Kod = "24-09", Ad = "Üzümlü", SehirId = erzincanId, CreatedAt = createdDate, IsDeleted = false },

                // 25 — Erzurum (20)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000311"), Kod = "25-01", Ad = "Aşkale", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000312"), Kod = "25-02", Ad = "Aziziye", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000313"), Kod = "25-03", Ad = "Çat", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000314"), Kod = "25-04", Ad = "Hınıs", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000315"), Kod = "25-05", Ad = "Horasan", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000316"), Kod = "25-06", Ad = "İspir", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000317"), Kod = "25-07", Ad = "Karaçoban", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000318"), Kod = "25-08", Ad = "Karayazı", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000319"), Kod = "25-09", Ad = "Köprüköy", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000320"), Kod = "25-10", Ad = "Narman", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000321"), Kod = "25-11", Ad = "Oltu", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000322"), Kod = "25-12", Ad = "Olur", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000323"), Kod = "25-13", Ad = "Palandöken", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000324"), Kod = "25-14", Ad = "Pasinler", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000325"), Kod = "25-15", Ad = "Pazaryolu", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000326"), Kod = "25-16", Ad = "Şenkaya", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000327"), Kod = "25-17", Ad = "Tekman", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000328"), Kod = "25-18", Ad = "Tortum", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000329"), Kod = "25-19", Ad = "Uzundere", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000330"), Kod = "25-20", Ad = "Yakutiye", SehirId = erzurumId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 26–30 şehir Id'leri (SehirSeedData'daki GUID'lerle birebir olmalı)
            var eskisehirId = Guid.Parse("10000000-0000-0000-0000-000000000026"); // 26
            var gaziantepId = Guid.Parse("10000000-0000-0000-0000-000000000027"); // 27
            var giresunId = Guid.Parse("10000000-0000-0000-0000-000000000028"); // 28
            var gumushaneId = Guid.Parse("10000000-0000-0000-0000-000000000029"); // 29
            var hakkariId = Guid.Parse("10000000-0000-0000-0000-000000000030"); // 30

            modelBuilder.Entity<Ilce>().HasData(
                // 26 — Eskişehir (14)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000331"), Kod = "26-01", Ad = "Alpu", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000332"), Kod = "26-02", Ad = "Beylikova", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000333"), Kod = "26-03", Ad = "Çifteler", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000334"), Kod = "26-04", Ad = "Günyüzü", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000335"), Kod = "26-05", Ad = "Han", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000336"), Kod = "26-06", Ad = "İnönü", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000337"), Kod = "26-07", Ad = "Mahmudiye", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000338"), Kod = "26-08", Ad = "Mihalgazi", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000339"), Kod = "26-09", Ad = "Mihalıççık", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000340"), Kod = "26-10", Ad = "Odunpazarı", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000341"), Kod = "26-11", Ad = "Sarıcakaya", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000342"), Kod = "26-12", Ad = "Seyitgazi", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000343"), Kod = "26-13", Ad = "Sivrihisar", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000344"), Kod = "26-14", Ad = "Tepebaşı", SehirId = eskisehirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe

                // 27 — Gaziantep (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000345"), Kod = "27-01", Ad = "Araban", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000346"), Kod = "27-02", Ad = "İslahiye", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000347"), Kod = "27-03", Ad = "Karkamış", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000348"), Kod = "27-04", Ad = "Nizip", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000349"), Kod = "27-05", Ad = "Nurdağı", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000350"), Kod = "27-06", Ad = "Oğuzeli", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000351"), Kod = "27-07", Ad = "Şahinbey", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000352"), Kod = "27-08", Ad = "Şehitkamil", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000353"), Kod = "27-09", Ad = "Yavuzeli", SehirId = gaziantepId, CreatedAt = createdDate, IsDeleted = false },

                // 28 — Giresun (16)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000354"), Kod = "28-01", Ad = "Alucra", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000355"), Kod = "28-02", Ad = "Bulancak", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000356"), Kod = "28-03", Ad = "Çamoluk", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000357"), Kod = "28-04", Ad = "Çanakçı", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000358"), Kod = "28-05", Ad = "Dereli", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000359"), Kod = "28-06", Ad = "Doğankent", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000360"), Kod = "28-07", Ad = "Espiye", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000361"), Kod = "28-08", Ad = "Eynesil", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000362"), Kod = "28-09", Ad = "Görele", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000363"), Kod = "28-10", Ad = "Güce", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000364"), Kod = "28-11", Ad = "Keşap", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000365"), Kod = "28-12", Ad = "Merkez", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false }, // Giresun Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000366"), Kod = "28-13", Ad = "Piraziz", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000367"), Kod = "28-14", Ad = "Şebinkarahisar", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000368"), Kod = "28-15", Ad = "Tirebolu", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000369"), Kod = "28-16", Ad = "Yağlıdere", SehirId = giresunId, CreatedAt = createdDate, IsDeleted = false },

                // 29 — Gümüşhane (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000370"), Kod = "29-01", Ad = "Kelkit", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000371"), Kod = "29-02", Ad = "Köse", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000372"), Kod = "29-03", Ad = "Kürtün", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000373"), Kod = "29-04", Ad = "Merkez", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000374"), Kod = "29-05", Ad = "Şiran", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000375"), Kod = "29-06", Ad = "Torul", SehirId = gumushaneId, CreatedAt = createdDate, IsDeleted = false },

                // 30 — Hakkâri (5)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000376"), Kod = "30-01", Ad = "Çukurca", SehirId = hakkariId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000377"), Kod = "30-02", Ad = "Derecik", SehirId = hakkariId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000378"), Kod = "30-03", Ad = "Merkez", SehirId = hakkariId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000379"), Kod = "30-04", Ad = "Şemdinli", SehirId = hakkariId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000380"), Kod = "30-05", Ad = "Yüksekova", SehirId = hakkariId, CreatedAt = createdDate, IsDeleted = false }
            );


            // 31–35 şehir Id'leri (SehirSeedData'daki GUID'lerle birebir)
            var hatayId = Guid.Parse("10000000-0000-0000-0000-000000000031"); // 31
            var ispartaId = Guid.Parse("10000000-0000-0000-0000-000000000032"); // 32
            var mersinId = Guid.Parse("10000000-0000-0000-0000-000000000033"); // 33
            var istanbulId = Guid.Parse("10000000-0000-0000-0000-000000000034"); // 34
            var izmirId = Guid.Parse("10000000-0000-0000-0000-000000000035"); // 35

            modelBuilder.Entity<Ilce>().HasData(
                // 31 — Hatay (15)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000381"), Kod = "31-01", Ad = "Altınözü", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000382"), Kod = "31-02", Ad = "Antakya", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000383"), Kod = "31-03", Ad = "Arsuz", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000384"), Kod = "31-04", Ad = "Belen", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000385"), Kod = "31-05", Ad = "Defne", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000386"), Kod = "31-06", Ad = "Dörtyol", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000387"), Kod = "31-07", Ad = "Erzin", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000388"), Kod = "31-08", Ad = "Hassa", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000389"), Kod = "31-09", Ad = "İskenderun", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000390"), Kod = "31-10", Ad = "Kırıkhan", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000391"), Kod = "31-11", Ad = "Kumlu", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000392"), Kod = "31-12", Ad = "Payas", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000393"), Kod = "31-13", Ad = "Reyhanlı", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000394"), Kod = "31-14", Ad = "Samandağ", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000395"), Kod = "31-15", Ad = "Yayladağı", SehirId = hatayId, CreatedAt = createdDate, IsDeleted = false },

                // 32 — Isparta (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000396"), Kod = "32-01", Ad = "Aksu", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000397"), Kod = "32-02", Ad = "Atabey", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000398"), Kod = "32-03", Ad = "Eğirdir", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000399"), Kod = "32-04", Ad = "Gelendost", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000400"), Kod = "32-05", Ad = "Gönen", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000401"), Kod = "32-06", Ad = "Keçiborlu", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000402"), Kod = "32-07", Ad = "Merkez", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false }, // Isparta Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000403"), Kod = "32-08", Ad = "Senirkent", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000404"), Kod = "32-09", Ad = "Sütçüler", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000405"), Kod = "32-10", Ad = "Şarkikaraağaç", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000406"), Kod = "32-11", Ad = "Uluborlu", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000407"), Kod = "32-12", Ad = "Yalvaç", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000408"), Kod = "32-13", Ad = "Yenişarbademli", SehirId = ispartaId, CreatedAt = createdDate, IsDeleted = false },

                // 33 — Mersin (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000409"), Kod = "33-01", Ad = "Akdeniz", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000410"), Kod = "33-02", Ad = "Anamur", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000411"), Kod = "33-03", Ad = "Aydıncık", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000412"), Kod = "33-04", Ad = "Bozyazı", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000413"), Kod = "33-05", Ad = "Çamlıyayla", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000414"), Kod = "33-06", Ad = "Erdemli", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000415"), Kod = "33-07", Ad = "Gülnar", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000416"), Kod = "33-08", Ad = "Mezitli", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000417"), Kod = "33-09", Ad = "Mut", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000418"), Kod = "33-10", Ad = "Silifke", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000419"), Kod = "33-11", Ad = "Tarsus", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000420"), Kod = "33-12", Ad = "Toroslar", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000421"), Kod = "33-13", Ad = "Yenişehir", SehirId = mersinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe

                // 34 — İstanbul (39)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000422"), Kod = "34-01", Ad = "Adalar", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000423"), Kod = "34-02", Ad = "Arnavutköy", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000424"), Kod = "34-03", Ad = "Ataşehir", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000425"), Kod = "34-04", Ad = "Avcılar", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000426"), Kod = "34-05", Ad = "Bağcılar", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000427"), Kod = "34-06", Ad = "Bahçelievler", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000428"), Kod = "34-07", Ad = "Bakırköy", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000429"), Kod = "34-08", Ad = "Başakşehir", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000430"), Kod = "34-09", Ad = "Bayrampaşa", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000431"), Kod = "34-10", Ad = "Beşiktaş", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000432"), Kod = "34-11", Ad = "Beykoz", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000433"), Kod = "34-12", Ad = "Beylikdüzü", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000434"), Kod = "34-13", Ad = "Beyoğlu", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000435"), Kod = "34-14", Ad = "Büyükçekmece", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000436"), Kod = "34-15", Ad = "Çatalca", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000437"), Kod = "34-16", Ad = "Çekmeköy", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000438"), Kod = "34-17", Ad = "Esenler", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000439"), Kod = "34-18", Ad = "Esenyurt", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000440"), Kod = "34-19", Ad = "Eyüpsultan", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false }, // (eski: Eyüp)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000441"), Kod = "34-20", Ad = "Fatih", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000442"), Kod = "34-21", Ad = "Gaziosmanpaşa", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000443"), Kod = "34-22", Ad = "Güngören", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000444"), Kod = "34-23", Ad = "Kadıköy", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000445"), Kod = "34-24", Ad = "Kağıthane", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000446"), Kod = "34-25", Ad = "Kartal", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000447"), Kod = "34-26", Ad = "Küçükçekmece", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000448"), Kod = "34-27", Ad = "Maltepe", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000449"), Kod = "34-28", Ad = "Pendik", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000450"), Kod = "34-29", Ad = "Sancaktepe", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000451"), Kod = "34-30", Ad = "Sarıyer", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000452"), Kod = "34-31", Ad = "Silivri", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000453"), Kod = "34-32", Ad = "Şile", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000454"), Kod = "34-33", Ad = "Şişli", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000455"), Kod = "34-34", Ad = "Sultanbeyli", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000456"), Kod = "34-35", Ad = "Sultangazi", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000457"), Kod = "34-36", Ad = "Tuzla", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000458"), Kod = "34-37", Ad = "Ümraniye", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000459"), Kod = "34-38", Ad = "Üsküdar", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000460"), Kod = "34-39", Ad = "Zeytinburnu", SehirId = istanbulId, CreatedAt = createdDate, IsDeleted = false },

                // 35 — İzmir (30)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000461"), Kod = "35-01", Ad = "Aliağa", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000462"), Kod = "35-02", Ad = "Balçova", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000463"), Kod = "35-03", Ad = "Bayındır", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000464"), Kod = "35-04", Ad = "Bayraklı", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000465"), Kod = "35-05", Ad = "Bergama", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000466"), Kod = "35-06", Ad = "Beydağ", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000467"), Kod = "35-07", Ad = "Bornova", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000468"), Kod = "35-08", Ad = "Buca", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000469"), Kod = "35-09", Ad = "Çeşme", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000470"), Kod = "35-10", Ad = "Çiğli", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000471"), Kod = "35-11", Ad = "Dikili", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000472"), Kod = "35-12", Ad = "Foça", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000473"), Kod = "35-13", Ad = "Gaziemir", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000474"), Kod = "35-14", Ad = "Güzelbahçe", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000475"), Kod = "35-15", Ad = "Karabağlar", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000476"), Kod = "35-16", Ad = "Karaburun", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000477"), Kod = "35-17", Ad = "Karşıyaka", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000478"), Kod = "35-18", Ad = "Kemalpaşa", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000479"), Kod = "35-19", Ad = "Kınık", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000480"), Kod = "35-20", Ad = "Kiraz", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000481"), Kod = "35-21", Ad = "Konak", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000482"), Kod = "35-22", Ad = "Menderes", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000483"), Kod = "35-23", Ad = "Menemen", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000484"), Kod = "35-24", Ad = "Narlıdere", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000485"), Kod = "35-25", Ad = "Ödemiş", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000486"), Kod = "35-26", Ad = "Seferihisar", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000487"), Kod = "35-27", Ad = "Selçuk", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000488"), Kod = "35-28", Ad = "Tire", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000489"), Kod = "35-29", Ad = "Torbalı", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000490"), Kod = "35-30", Ad = "Urla", SehirId = izmirId, CreatedAt = createdDate, IsDeleted = false }
            );

            // 36–40 şehir Id'leri (SehirSeedData ile birebir olmalı)
            var karsId = Guid.Parse("10000000-0000-0000-0000-000000000036"); // 36
            var kastamonuId = Guid.Parse("10000000-0000-0000-0000-000000000037"); // 37
                                                                                  // var kayseriId  = Guid.Parse("10000000-0000-0000-0000-000000000038"); // 38 (Kayseri daha önce eklendi)
            var kirklareliId = Guid.Parse("10000000-0000-0000-0000-000000000039"); // 39
            var kirsehirId = Guid.Parse("10000000-0000-0000-0000-000000000040"); // 40

            modelBuilder.Entity<Ilce>().HasData(
                // 36 — Kars (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000491"), Kod = "36-01", Ad = "Akyaka", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000492"), Kod = "36-02", Ad = "Arpaçay", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000493"), Kod = "36-03", Ad = "Digor", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000494"), Kod = "36-04", Ad = "Kağızman", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000495"), Kod = "36-05", Ad = "Merkez", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000496"), Kod = "36-06", Ad = "Sarıkamış", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000497"), Kod = "36-07", Ad = "Selim", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000498"), Kod = "36-08", Ad = "Susuz", SehirId = karsId, CreatedAt = createdDate, IsDeleted = false },

                // 37 — Kastamonu (20)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000499"), Kod = "37-01", Ad = "Abana", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000500"), Kod = "37-02", Ad = "Ağlı", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000501"), Kod = "37-03", Ad = "Araç", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000502"), Kod = "37-04", Ad = "Azdavay", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000503"), Kod = "37-05", Ad = "Bozkurt", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000504"), Kod = "37-06", Ad = "Cide", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000505"), Kod = "37-07", Ad = "Çatalzeytin", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000506"), Kod = "37-08", Ad = "Daday", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000507"), Kod = "37-09", Ad = "Devrekani", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000508"), Kod = "37-10", Ad = "Doğanyurt", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000509"), Kod = "37-11", Ad = "Hanönü", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000510"), Kod = "37-12", Ad = "İhsangazi", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000511"), Kod = "37-13", Ad = "İnebolu", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000512"), Kod = "37-14", Ad = "Küre", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000513"), Kod = "37-15", Ad = "Merkez", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000514"), Kod = "37-16", Ad = "Pınarbaşı", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000515"), Kod = "37-17", Ad = "Seydiler", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000516"), Kod = "37-18", Ad = "Şenpazar", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000517"), Kod = "37-19", Ad = "Taşköprü", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000518"), Kod = "37-20", Ad = "Tosya", SehirId = kastamonuId, CreatedAt = createdDate, IsDeleted = false },

                // 38 — Kayseri: daha önce tüm ilçeleri eklemiştik (38-01..38-15). 
                // Eğer ekli DEĞİLSE haber ver, 38 bloğunu da göndereyim.

                // 39 — Kırklareli (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000519"), Kod = "39-01", Ad = "Babaeski", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000520"), Kod = "39-02", Ad = "Demirköy", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000521"), Kod = "39-03", Ad = "Kofçaz", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000522"), Kod = "39-04", Ad = "Lüleburgaz", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000523"), Kod = "39-05", Ad = "Merkez", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000524"), Kod = "39-06", Ad = "Pehlivanköy", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000525"), Kod = "39-07", Ad = "Pınarhisar", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000526"), Kod = "39-08", Ad = "Vize", SehirId = kirklareliId, CreatedAt = createdDate, IsDeleted = false },

                // 40 — Kırşehir (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000527"), Kod = "40-01", Ad = "Akçakent", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000528"), Kod = "40-02", Ad = "Akpınar", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000529"), Kod = "40-03", Ad = "Boztepe", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000530"), Kod = "40-04", Ad = "Çiçekdağı", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000531"), Kod = "40-05", Ad = "Kaman", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000532"), Kod = "40-06", Ad = "Merkez", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000533"), Kod = "40-07", Ad = "Mucur", SehirId = kirsehirId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 41–45 şehir Id'leri (SehirSeedData’daki GUID’lerle birebir olmalı)
            var kocaeliId = Guid.Parse("10000000-0000-0000-0000-000000000041"); // 41
            var konyaId = Guid.Parse("10000000-0000-0000-0000-000000000042"); // 42
            var kutahyaId = Guid.Parse("10000000-0000-0000-0000-000000000043"); // 43
            var malatyaId = Guid.Parse("10000000-0000-0000-0000-000000000044"); // 44
            var manisaId = Guid.Parse("10000000-0000-0000-0000-000000000045"); // 45

            modelBuilder.Entity<Ilce>().HasData(
                // 41 — Kocaeli (12)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000534"), Kod = "41-01", Ad = "Başiskele", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000535"), Kod = "41-02", Ad = "Çayırova", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000536"), Kod = "41-03", Ad = "Darıca", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000537"), Kod = "41-04", Ad = "Derince", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000538"), Kod = "41-05", Ad = "Dilovası", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000539"), Kod = "41-06", Ad = "Gebze", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000540"), Kod = "41-07", Ad = "Gölcük", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000541"), Kod = "41-08", Ad = "İzmit", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000542"), Kod = "41-09", Ad = "Kandıra", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000543"), Kod = "41-10", Ad = "Karamürsel", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000544"), Kod = "41-11", Ad = "Kartepe", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000545"), Kod = "41-12", Ad = "Körfez", SehirId = kocaeliId, CreatedAt = createdDate, IsDeleted = false },

                // 42 — Konya (31)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000546"), Kod = "42-01", Ad = "Ahırlı", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000547"), Kod = "42-02", Ad = "Akören", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000548"), Kod = "42-03", Ad = "Akşehir", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000549"), Kod = "42-04", Ad = "Altınekin", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000550"), Kod = "42-05", Ad = "Beyşehir", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000551"), Kod = "42-06", Ad = "Bozkır", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000552"), Kod = "42-07", Ad = "Cihanbeyli", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000553"), Kod = "42-08", Ad = "Çeltik", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000554"), Kod = "42-09", Ad = "Çumra", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000555"), Kod = "42-10", Ad = "Derbent", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000556"), Kod = "42-11", Ad = "Derebucak", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000557"), Kod = "42-12", Ad = "Doğanhisar", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000558"), Kod = "42-13", Ad = "Emirgazi", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000559"), Kod = "42-14", Ad = "Ereğli", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000560"), Kod = "42-15", Ad = "Güneysınır", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000561"), Kod = "42-16", Ad = "Hadim", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000562"), Kod = "42-17", Ad = "Halkapınar", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000563"), Kod = "42-18", Ad = "Hüyük", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000564"), Kod = "42-19", Ad = "Ilgın", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false }, // "I" harfi
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000565"), Kod = "42-20", Ad = "Kadınhanı", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000566"), Kod = "42-21", Ad = "Karapınar", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000567"), Kod = "42-22", Ad = "Karatay", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000568"), Kod = "42-23", Ad = "Kulu", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000569"), Kod = "42-24", Ad = "Meram", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000570"), Kod = "42-25", Ad = "Sarayönü", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000571"), Kod = "42-26", Ad = "Selçuklu", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000572"), Kod = "42-27", Ad = "Seydişehir", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000573"), Kod = "42-28", Ad = "Taşkent", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000574"), Kod = "42-29", Ad = "Tuzlukçu", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000575"), Kod = "42-30", Ad = "Yalıhüyük", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false }, // "ı/ü" dikkat
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000576"), Kod = "42-31", Ad = "Yunak", SehirId = konyaId, CreatedAt = createdDate, IsDeleted = false },

                // 43 — Kütahya (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000577"), Kod = "43-01", Ad = "Altıntaş", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000578"), Kod = "43-02", Ad = "Aslanapa", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000579"), Kod = "43-03", Ad = "Çavdarhisar", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000580"), Kod = "43-04", Ad = "Domaniç", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000581"), Kod = "43-05", Ad = "Dumlupınar", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000582"), Kod = "43-06", Ad = "Emet", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000583"), Kod = "43-07", Ad = "Gediz", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000584"), Kod = "43-08", Ad = "Hisarcık", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000585"), Kod = "43-09", Ad = "Merkez", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000586"), Kod = "43-10", Ad = "Pazarlar", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000587"), Kod = "43-11", Ad = "Simav", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000588"), Kod = "43-12", Ad = "Şaphane", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000589"), Kod = "43-13", Ad = "Tavşanlı", SehirId = kutahyaId, CreatedAt = createdDate, IsDeleted = false },

                // 44 — Malatya (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000590"), Kod = "44-01", Ad = "Akçadağ", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000591"), Kod = "44-02", Ad = "Arapgir", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000592"), Kod = "44-03", Ad = "Arguvan", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000593"), Kod = "44-04", Ad = "Battalgazi", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000594"), Kod = "44-05", Ad = "Darende", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000595"), Kod = "44-06", Ad = "Doğanşehir", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000596"), Kod = "44-07", Ad = "Doğanyol", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000597"), Kod = "44-08", Ad = "Hekimhan", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000598"), Kod = "44-09", Ad = "Kale", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000599"), Kod = "44-10", Ad = "Kuluncak", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000600"), Kod = "44-11", Ad = "Pütürge", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000601"), Kod = "44-12", Ad = "Yazıhan", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000602"), Kod = "44-13", Ad = "Yeşilyurt", SehirId = malatyaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe

                // 45 — Manisa (17)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000603"), Kod = "45-01", Ad = "Ahmetli", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000604"), Kod = "45-02", Ad = "Akhisar", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000605"), Kod = "45-03", Ad = "Alaşehir", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000606"), Kod = "45-04", Ad = "Demirci", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000607"), Kod = "45-05", Ad = "Gölmarmara", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000608"), Kod = "45-06", Ad = "Gördes", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000609"), Kod = "45-07", Ad = "Kırkağaç", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000610"), Kod = "45-08", Ad = "Köprübaşı", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000611"), Kod = "45-09", Ad = "Kula", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000612"), Kod = "45-10", Ad = "Salihli", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000613"), Kod = "45-11", Ad = "Sarıgöl", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000614"), Kod = "45-12", Ad = "Saruhanlı", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000615"), Kod = "45-13", Ad = "Selendi", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000616"), Kod = "45-14", Ad = "Soma", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000617"), Kod = "45-15", Ad = "Şehzadeler", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000618"), Kod = "45-16", Ad = "Turgutlu", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000619"), Kod = "45-17", Ad = "Yunusemre", SehirId = manisaId, CreatedAt = createdDate, IsDeleted = false }  // merkez ilçe
            );

            // 46–50 şehir Id'leri (SehirSeedData ile birebir olmalı)
            var kahramanmarasId = Guid.Parse("10000000-0000-0000-0000-000000000046"); // 46
            var mardinId = Guid.Parse("10000000-0000-0000-0000-000000000047"); // 47
            var muglaId = Guid.Parse("10000000-0000-0000-0000-000000000048"); // 48
            var musId = Guid.Parse("10000000-0000-0000-0000-000000000049"); // 49
            var nevsehirId = Guid.Parse("10000000-0000-0000-0000-000000000050"); // 50

            modelBuilder.Entity<Ilce>().HasData(
                // 46 — Kahramanmaraş (11)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000620"), Kod = "46-01", Ad = "Afşin", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000621"), Kod = "46-02", Ad = "Andırın", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000622"), Kod = "46-03", Ad = "Çağlayancerit", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000623"), Kod = "46-04", Ad = "Dulkadiroğlu", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000624"), Kod = "46-05", Ad = "Ekinözü", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000625"), Kod = "46-06", Ad = "Elbistan", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000626"), Kod = "46-07", Ad = "Göksun", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000627"), Kod = "46-08", Ad = "Nurhak", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000628"), Kod = "46-09", Ad = "Onikişubat", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000629"), Kod = "46-10", Ad = "Pazarcık", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000630"), Kod = "46-11", Ad = "Türkoğlu", SehirId = kahramanmarasId, CreatedAt = createdDate, IsDeleted = false },

                // 47 — Mardin (10)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000631"), Kod = "47-01", Ad = "Artuklu", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000632"), Kod = "47-02", Ad = "Dargeçit", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000633"), Kod = "47-03", Ad = "Derik", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000634"), Kod = "47-04", Ad = "Kızıltepe", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000635"), Kod = "47-05", Ad = "Mazıdağı", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000636"), Kod = "47-06", Ad = "Midyat", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000637"), Kod = "47-07", Ad = "Nusaybin", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000638"), Kod = "47-08", Ad = "Ömerli", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000639"), Kod = "47-09", Ad = "Savur", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000640"), Kod = "47-10", Ad = "Yeşilli", SehirId = mardinId, CreatedAt = createdDate, IsDeleted = false },

                // 48 — Muğla (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000641"), Kod = "48-01", Ad = "Bodrum", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000642"), Kod = "48-02", Ad = "Dalaman", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000643"), Kod = "48-03", Ad = "Datça", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000644"), Kod = "48-04", Ad = "Fethiye", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000645"), Kod = "48-05", Ad = "Kavaklıdere", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000646"), Kod = "48-06", Ad = "Köyceğiz", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000647"), Kod = "48-07", Ad = "Marmaris", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000648"), Kod = "48-08", Ad = "Menteşe", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000649"), Kod = "48-09", Ad = "Milas", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000650"), Kod = "48-10", Ad = "Ortaca", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000651"), Kod = "48-11", Ad = "Seydikemer", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000652"), Kod = "48-12", Ad = "Ula", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000653"), Kod = "48-13", Ad = "Yatağan", SehirId = muglaId, CreatedAt = createdDate, IsDeleted = false },

                // 49 — Muş (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000654"), Kod = "49-01", Ad = "Bulanık", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000655"), Kod = "49-02", Ad = "Hasköy", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000656"), Kod = "49-03", Ad = "Korkut", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000657"), Kod = "49-04", Ad = "Malazgirt", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000658"), Kod = "49-05", Ad = "Merkez", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000659"), Kod = "49-06", Ad = "Varto", SehirId = musId, CreatedAt = createdDate, IsDeleted = false },

                // 50 — Nevşehir (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000660"), Kod = "50-01", Ad = "Acıgöl", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000661"), Kod = "50-02", Ad = "Avanos", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000662"), Kod = "50-03", Ad = "Derinkuyu", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000663"), Kod = "50-04", Ad = "Gülşehir", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000664"), Kod = "50-05", Ad = "Hacıbektaş", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000665"), Kod = "50-06", Ad = "Kozaklı", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000666"), Kod = "50-07", Ad = "Merkez", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000667"), Kod = "50-08", Ad = "Ürgüp", SehirId = nevsehirId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 51–55 şehir Id'leri (SehirSeedData’daki GUID’lerle birebir olmalı)
            var nigdeId = Guid.Parse("10000000-0000-0000-0000-000000000051"); // 51
            var orduId = Guid.Parse("10000000-0000-0000-0000-000000000052"); // 52
            var rizeId = Guid.Parse("10000000-0000-0000-0000-000000000053"); // 53
            var sakaryaId = Guid.Parse("10000000-0000-0000-0000-000000000054"); // 54
            var samsunId = Guid.Parse("10000000-0000-0000-0000-000000000055"); // 55

            modelBuilder.Entity<Ilce>().HasData(
                // 51 — Niğde (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000668"), Kod = "51-01", Ad = "Altunhisar", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000669"), Kod = "51-02", Ad = "Bor", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000670"), Kod = "51-03", Ad = "Çamardı", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000671"), Kod = "51-04", Ad = "Çiftlik", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000672"), Kod = "51-05", Ad = "Merkez", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000673"), Kod = "51-06", Ad = "Ulukışla", SehirId = nigdeId, CreatedAt = createdDate, IsDeleted = false },

                // 52 — Ordu (19)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000674"), Kod = "52-01", Ad = "Akkuş", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000675"), Kod = "52-02", Ad = "Altınordu", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000676"), Kod = "52-03", Ad = "Aybastı", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000677"), Kod = "52-04", Ad = "Çamaş", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000678"), Kod = "52-05", Ad = "Çatalpınar", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000679"), Kod = "52-06", Ad = "Çaybaşı", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000680"), Kod = "52-07", Ad = "Fatsa", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000681"), Kod = "52-08", Ad = "Gölköy", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000682"), Kod = "52-09", Ad = "Gülyalı", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000683"), Kod = "52-10", Ad = "Gürgentepe", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000684"), Kod = "52-11", Ad = "İkizce", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000685"), Kod = "52-12", Ad = "Kabadüz", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000686"), Kod = "52-13", Ad = "Kabataş", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000687"), Kod = "52-14", Ad = "Korgan", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000688"), Kod = "52-15", Ad = "Kumru", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000689"), Kod = "52-16", Ad = "Mesudiye", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000690"), Kod = "52-17", Ad = "Perşembe", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000691"), Kod = "52-18", Ad = "Ulubey", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000692"), Kod = "52-19", Ad = "Ünye", SehirId = orduId, CreatedAt = createdDate, IsDeleted = false },

                // 53 — Rize (12)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000693"), Kod = "53-01", Ad = "Ardeşen", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000694"), Kod = "53-02", Ad = "Çamlıhemşin", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000695"), Kod = "53-03", Ad = "Çayeli", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000696"), Kod = "53-04", Ad = "Derepazarı", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000697"), Kod = "53-05", Ad = "Fındıklı", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000698"), Kod = "53-06", Ad = "Güneysu", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000699"), Kod = "53-07", Ad = "Hemşin", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000700"), Kod = "53-08", Ad = "İkizdere", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000701"), Kod = "53-09", Ad = "İyidere", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000702"), Kod = "53-10", Ad = "Kalkandere", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000703"), Kod = "53-11", Ad = "Merkez", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false }, // Rize Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000704"), Kod = "53-12", Ad = "Pazar", SehirId = rizeId, CreatedAt = createdDate, IsDeleted = false },

                // 54 — Sakarya (16)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000705"), Kod = "54-01", Ad = "Adapazarı", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000706"), Kod = "54-02", Ad = "Akyazı", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000707"), Kod = "54-03", Ad = "Arifiye", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000708"), Kod = "54-04", Ad = "Erenler", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000709"), Kod = "54-05", Ad = "Ferizli", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000710"), Kod = "54-06", Ad = "Geyve", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000711"), Kod = "54-07", Ad = "Hendek", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000712"), Kod = "54-08", Ad = "Karapürçek", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false }, // "ü" dikkat
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000713"), Kod = "54-09", Ad = "Karasu", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000714"), Kod = "54-10", Ad = "Kaynarca", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000715"), Kod = "54-11", Ad = "Kocaali", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000716"), Kod = "54-12", Ad = "Pamukova", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000717"), Kod = "54-13", Ad = "Sapanca", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000718"), Kod = "54-14", Ad = "Serdivan", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000719"), Kod = "54-15", Ad = "Söğütlü", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false }, // "ğ/ü"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000720"), Kod = "54-16", Ad = "Taraklı", SehirId = sakaryaId, CreatedAt = createdDate, IsDeleted = false },

                // 55 — Samsun (17)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000721"), Kod = "55-01", Ad = "Alaçam", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000722"), Kod = "55-02", Ad = "Asarcık", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000723"), Kod = "55-03", Ad = "Atakum", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000724"), Kod = "55-04", Ad = "Ayvacık", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000725"), Kod = "55-05", Ad = "Bafra", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000726"), Kod = "55-06", Ad = "Canik", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000727"), Kod = "55-07", Ad = "Çarşamba", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000728"), Kod = "55-08", Ad = "Havza", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000729"), Kod = "55-09", Ad = "İlkadım", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000730"), Kod = "55-10", Ad = "Kavak", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000731"), Kod = "55-11", Ad = "Ladik", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000732"), Kod = "55-12", Ad = "Ondokuzmayıs", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // "Ondokuzmayıs"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000733"), Kod = "55-13", Ad = "Salıpazarı", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000734"), Kod = "55-14", Ad = "Tekkeköy", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000735"), Kod = "55-15", Ad = "Terme", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000736"), Kod = "55-16", Ad = "Vezirköprü", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000737"), Kod = "55-17", Ad = "Yakakent", SehirId = samsunId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 56–60 şehir Id'leri (SehirSeedData’daki GUID’lerle birebir olmalı)
            var siirtId = Guid.Parse("10000000-0000-0000-0000-000000000056"); // 56
            var sinopId = Guid.Parse("10000000-0000-0000-0000-000000000057"); // 57
            var sivasId = Guid.Parse("10000000-0000-0000-0000-000000000058"); // 58
            var tekirdagId = Guid.Parse("10000000-0000-0000-0000-000000000059"); // 59
            var tokatId = Guid.Parse("10000000-0000-0000-0000-000000000060"); // 60

            modelBuilder.Entity<Ilce>().HasData(
                // 56 — Siirt (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000738"), Kod = "56-01", Ad = "Baykan", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000739"), Kod = "56-02", Ad = "Eruh", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000740"), Kod = "56-03", Ad = "Kurtalan", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000741"), Kod = "56-04", Ad = "Pervari", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000742"), Kod = "56-05", Ad = "Merkez", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false }, // Siirt Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000743"), Kod = "56-06", Ad = "Şirvan", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000744"), Kod = "56-07", Ad = "Tillo", SehirId = siirtId, CreatedAt = createdDate, IsDeleted = false }, // (eski: Aydınlar)

                // 57 — Sinop (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000745"), Kod = "57-01", Ad = "Ayancık", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000746"), Kod = "57-02", Ad = "Boyabat", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000747"), Kod = "57-03", Ad = "Dikmen", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000748"), Kod = "57-04", Ad = "Durağan", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false }, // "ğ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000749"), Kod = "57-05", Ad = "Erfelek", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000750"), Kod = "57-06", Ad = "Gerze", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000751"), Kod = "57-07", Ad = "Merkez", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false }, // Sinop Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000752"), Kod = "57-08", Ad = "Saraydüzü", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false }, // "ü"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000753"), Kod = "57-09", Ad = "Türkeli", SehirId = sinopId, CreatedAt = createdDate, IsDeleted = false },

                // 58 — Sivas (17)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000754"), Kod = "58-01", Ad = "Akıncılar", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000755"), Kod = "58-02", Ad = "Altınyayla", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000756"), Kod = "58-03", Ad = "Divriği", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "ğ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000757"), Kod = "58-04", Ad = "Doğanşar", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "ğ/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000758"), Kod = "58-05", Ad = "Gemerek", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000759"), Kod = "58-06", Ad = "Gölova", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000760"), Kod = "58-07", Ad = "Gürün", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "ü"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000761"), Kod = "58-08", Ad = "Hafik", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000762"), Kod = "58-09", Ad = "İmranlı", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "İ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000763"), Kod = "58-10", Ad = "Kangal", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000764"), Kod = "58-11", Ad = "Koyulhisar", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000765"), Kod = "58-12", Ad = "Merkez", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // Sivas Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000766"), Kod = "58-13", Ad = "Şarkışla", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "Ş/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000767"), Kod = "58-14", Ad = "Suşehri", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000768"), Kod = "58-15", Ad = "Ulaş", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000769"), Kod = "58-16", Ad = "Yıldızeli", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000770"), Kod = "58-17", Ad = "Zara", SehirId = sivasId, CreatedAt = createdDate, IsDeleted = false },

                // 59 — Tekirdağ (11)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000771"), Kod = "59-01", Ad = "Çerkezköy", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000772"), Kod = "59-02", Ad = "Çorlu", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000773"), Kod = "59-03", Ad = "Ergene", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false }, // yeni ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000774"), Kod = "59-04", Ad = "Hayrabolu", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000775"), Kod = "59-05", Ad = "Kapaklı", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false }, // yeni ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000776"), Kod = "59-06", Ad = "Malkara", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000777"), Kod = "59-07", Ad = "Marmaraereğlisi", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false }, // "ğ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000778"), Kod = "59-08", Ad = "Muratlı", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000779"), Kod = "59-09", Ad = "Saray", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000780"), Kod = "59-10", Ad = "Süleymanpaşa", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000781"), Kod = "59-11", Ad = "Şarköy", SehirId = tekirdagId, CreatedAt = createdDate, IsDeleted = false },

                // 60 — Tokat (12)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000782"), Kod = "60-01", Ad = "Almus", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000783"), Kod = "60-02", Ad = "Artova", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000784"), Kod = "60-03", Ad = "Başçiftlik", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000785"), Kod = "60-04", Ad = "Erbaa", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000786"), Kod = "60-05", Ad = "Merkez", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false }, // Tokat Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000787"), Kod = "60-06", Ad = "Niksar", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000788"), Kod = "60-07", Ad = "Pazar", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000789"), Kod = "60-08", Ad = "Reşadiye", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000790"), Kod = "60-09", Ad = "Sulusaray", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000791"), Kod = "60-10", Ad = "Turhal", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000792"), Kod = "60-11", Ad = "Yeşilyurt", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000793"), Kod = "60-12", Ad = "Zile", SehirId = tokatId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 61–65 şehir Id'leri
            var trabzonId = Guid.Parse("10000000-0000-0000-0000-000000000061"); // 61
            var tunceliId = Guid.Parse("10000000-0000-0000-0000-000000000062"); // 62
            var sanliurfaId = Guid.Parse("10000000-0000-0000-0000-000000000063"); // 63
            var usakId = Guid.Parse("10000000-0000-0000-0000-000000000064"); // 64
            var vanId = Guid.Parse("10000000-0000-0000-0000-000000000065"); // 65

            modelBuilder.Entity<Ilce>().HasData(
                // 61 — Trabzon (18)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000794"), Kod = "61-01", Ad = "Akçaabat", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000795"), Kod = "61-02", Ad = "Araklı", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000796"), Kod = "61-03", Ad = "Arsin", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000797"), Kod = "61-04", Ad = "Beşikdüzü", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ü"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000798"), Kod = "61-05", Ad = "Çarşıbaşı", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000799"), Kod = "61-06", Ad = "Çaykara", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000800"), Kod = "61-07", Ad = "Dernekpazarı", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000801"), Kod = "61-08", Ad = "Düzköy", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ü/ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000802"), Kod = "61-09", Ad = "Hayrat", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000803"), Kod = "61-10", Ad = "Köprübaşı", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ü/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000804"), Kod = "61-11", Ad = "Maçka", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000805"), Kod = "61-12", Ad = "Of", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000806"), Kod = "61-13", Ad = "Ortahisar", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000807"), Kod = "61-14", Ad = "Sürmene", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ü"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000808"), Kod = "61-15", Ad = "Şalpazarı", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "Ş/ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000809"), Kod = "61-16", Ad = "Tonya", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000810"), Kod = "61-17", Ad = "Vakfıkebir", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000811"), Kod = "61-18", Ad = "Yomra", SehirId = trabzonId, CreatedAt = createdDate, IsDeleted = false },

                // 62 — Tunceli (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000812"), Kod = "62-01", Ad = "Çemişgezek", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000813"), Kod = "62-02", Ad = "Hozat", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000814"), Kod = "62-03", Ad = "Mazgirt", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000815"), Kod = "62-04", Ad = "Merkez", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false }, // Tunceli Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000816"), Kod = "62-05", Ad = "Nazımiye", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000817"), Kod = "62-06", Ad = "Ovacık", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000818"), Kod = "62-07", Ad = "Pertek", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000819"), Kod = "62-08", Ad = "Pülümür", SehirId = tunceliId, CreatedAt = createdDate, IsDeleted = false }, // "ü"

                // 63 — Şanlıurfa (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000820"), Kod = "63-01", Ad = "Akçakale", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000821"), Kod = "63-02", Ad = "Birecik", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000822"), Kod = "63-03", Ad = "Bozova", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000823"), Kod = "63-04", Ad = "Ceylanpınar", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000824"), Kod = "63-05", Ad = "Eyyübiye", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000825"), Kod = "63-06", Ad = "Halfeti", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // "Halfeti"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000826"), Kod = "63-07", Ad = "Haliliye", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000827"), Kod = "63-08", Ad = "Harran", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000828"), Kod = "63-09", Ad = "Hilvan", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000829"), Kod = "63-10", Ad = "Karaköprü", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000830"), Kod = "63-11", Ad = "Siverek", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000831"), Kod = "63-12", Ad = "Suruç", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000832"), Kod = "63-13", Ad = "Viranşehir", SehirId = sanliurfaId, CreatedAt = createdDate, IsDeleted = false }, // "ş"

                // 64 — Uşak (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000833"), Kod = "64-01", Ad = "Banaz", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000834"), Kod = "64-02", Ad = "Eşme", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000835"), Kod = "64-03", Ad = "Karahallı", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000836"), Kod = "64-04", Ad = "Merkez", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false }, // Uşak Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000837"), Kod = "64-05", Ad = "Sivaslı", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000838"), Kod = "64-06", Ad = "Ulubey", SehirId = usakId, CreatedAt = createdDate, IsDeleted = false },

                // 65 — Van (13)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000839"), Kod = "65-01", Ad = "Bahçesaray", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000840"), Kod = "65-02", Ad = "Başkale", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000841"), Kod = "65-03", Ad = "Çaldıran", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000842"), Kod = "65-04", Ad = "Çatak", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000843"), Kod = "65-05", Ad = "Edremit", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000844"), Kod = "65-06", Ad = "Erciş", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000845"), Kod = "65-07", Ad = "Gevaş", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000846"), Kod = "65-08", Ad = "Gürpınar", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000847"), Kod = "65-09", Ad = "İpekyolu", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000848"), Kod = "65-10", Ad = "Muradiye", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000849"), Kod = "65-11", Ad = "Özalp", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000850"), Kod = "65-12", Ad = "Saray", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000851"), Kod = "65-13", Ad = "Tuşba", SehirId = vanId, CreatedAt = createdDate, IsDeleted = false }  // merkez ilçe
            );
            // 66–70 şehir Id'leri (SehirSeedData ile birebir olmalı)
            var yozgatId = Guid.Parse("10000000-0000-0000-0000-000000000066"); // 66
            var zonguldakId = Guid.Parse("10000000-0000-0000-0000-000000000067"); // 67
            var aksarayId = Guid.Parse("10000000-0000-0000-0000-000000000068"); // 68
            var bayburtId = Guid.Parse("10000000-0000-0000-0000-000000000069"); // 69
            var karamanId = Guid.Parse("10000000-0000-0000-0000-000000000070"); // 70

            modelBuilder.Entity<Ilce>().HasData(
                // 66 — Yozgat (14)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000852"), Kod = "66-01", Ad = "Akdağmadeni", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000853"), Kod = "66-02", Ad = "Aydıncık", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000854"), Kod = "66-03", Ad = "Boğazlıyan", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000855"), Kod = "66-04", Ad = "Çandır", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000856"), Kod = "66-05", Ad = "Çayıralan", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000857"), Kod = "66-06", Ad = "Çekerek", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000858"), Kod = "66-07", Ad = "Kadışehri", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000859"), Kod = "66-08", Ad = "Merkez", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false }, // Yozgat Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000860"), Kod = "66-09", Ad = "Saraykent", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000861"), Kod = "66-10", Ad = "Sarıkaya", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000862"), Kod = "66-11", Ad = "Sorgun", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000863"), Kod = "66-12", Ad = "Şefaatli", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000864"), Kod = "66-13", Ad = "Yerköy", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000865"), Kod = "66-14", Ad = "Yenifakılı", SehirId = yozgatId, CreatedAt = createdDate, IsDeleted = false },

                // 67 — Zonguldak (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000866"), Kod = "67-01", Ad = "Alaplı", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000867"), Kod = "67-02", Ad = "Çaycuma", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000868"), Kod = "67-03", Ad = "Devrek", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000869"), Kod = "67-04", Ad = "Gökçebey", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000870"), Kod = "67-05", Ad = "Karadeniz Ereğli", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false }, // Ereğli
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000871"), Kod = "67-06", Ad = "Kilimli", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000872"), Kod = "67-07", Ad = "Kozlu", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000873"), Kod = "67-08", Ad = "Merkez", SehirId = zonguldakId, CreatedAt = createdDate, IsDeleted = false }, // Zonguldak Merkez

                // 68 — Aksaray (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000874"), Kod = "68-01", Ad = "Ağaçören", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // "ğ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000875"), Kod = "68-02", Ad = "Eskil", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000876"), Kod = "68-03", Ad = "Gülağaç", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // "ğ/ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000877"), Kod = "68-04", Ad = "Güzelyurt", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000878"), Kod = "68-05", Ad = "Merkez", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // Aksaray Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000879"), Kod = "68-06", Ad = "Ortaköy", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000880"), Kod = "68-07", Ad = "Sarıyahşi", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // "ı/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000881"), Kod = "68-08", Ad = "Sultanhanı", SehirId = aksarayId, CreatedAt = createdDate, IsDeleted = false }, // "ı"

                // 69 — Bayburt (3)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000882"), Kod = "69-01", Ad = "Aydıntepe", SehirId = bayburtId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000883"), Kod = "69-02", Ad = "Demirözü", SehirId = bayburtId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000884"), Kod = "69-03", Ad = "Merkez", SehirId = bayburtId, CreatedAt = createdDate, IsDeleted = false }, // Bayburt Merkez

                // 70 — Karaman (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000885"), Kod = "70-01", Ad = "Ayrancı", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000886"), Kod = "70-02", Ad = "Başyayla", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000887"), Kod = "70-03", Ad = "Ermenek", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000888"), Kod = "70-04", Ad = "Kazımkarabekir", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000889"), Kod = "70-05", Ad = "Merkez", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false }, // Karaman Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000890"), Kod = "70-06", Ad = "Sarıveliler", SehirId = karamanId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 71–75 şehir Id'leri (SehirSeedData ile birebir olmalı)
            var kirikkaleId = Guid.Parse("10000000-0000-0000-0000-000000000071"); // 71
            var batmanId = Guid.Parse("10000000-0000-0000-0000-000000000072"); // 72
            var sirnakId = Guid.Parse("10000000-0000-0000-0000-000000000073"); // 73
            var bartinId = Guid.Parse("10000000-0000-0000-0000-000000000074"); // 74
            var ardahanId = Guid.Parse("10000000-0000-0000-0000-000000000075"); // 75

            modelBuilder.Entity<Ilce>().HasData(
                // 71 — Kırıkkale (9)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000891"), Kod = "71-01", Ad = "Bahşılı", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000892"), Kod = "71-02", Ad = "Balışeyh", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // "ı/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000893"), Kod = "71-03", Ad = "Çelebi", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000894"), Kod = "71-04", Ad = "Delice", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000895"), Kod = "71-05", Ad = "Karakeçili", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000896"), Kod = "71-06", Ad = "Keskin", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000897"), Kod = "71-07", Ad = "Merkez", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // Kırıkkale Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000898"), Kod = "71-08", Ad = "Sulakyurt", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000899"), Kod = "71-09", Ad = "Yahşihan", SehirId = kirikkaleId, CreatedAt = createdDate, IsDeleted = false }, // "ş"

                // 72 — Batman (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000900"), Kod = "72-01", Ad = "Beşiri", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000901"), Kod = "72-02", Ad = "Gercüş", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000902"), Kod = "72-03", Ad = "Hasankeyf", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000903"), Kod = "72-04", Ad = "Kozluk", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000904"), Kod = "72-05", Ad = "Merkez", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false }, // Batman Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000905"), Kod = "72-06", Ad = "Sason", SehirId = batmanId, CreatedAt = createdDate, IsDeleted = false },

                // 73 — Şırnak (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000906"), Kod = "73-01", Ad = "Beytüşşebap", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false }, // "Ş/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000907"), Kod = "73-02", Ad = "Cizre", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000908"), Kod = "73-03", Ad = "Güçlükonak", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000909"), Kod = "73-04", Ad = "İdil", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false }, // "İ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000910"), Kod = "73-05", Ad = "Merkez", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false }, // Şırnak Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000911"), Kod = "73-06", Ad = "Silopi", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000912"), Kod = "73-07", Ad = "Uludere", SehirId = sirnakId, CreatedAt = createdDate, IsDeleted = false },

                // 74 — Bartın (4)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000913"), Kod = "74-01", Ad = "Amasra", SehirId = bartinId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000914"), Kod = "74-02", Ad = "Kurucaşile", SehirId = bartinId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000915"), Kod = "74-03", Ad = "Merkez", SehirId = bartinId, CreatedAt = createdDate, IsDeleted = false }, // Bartın Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000916"), Kod = "74-04", Ad = "Ulus", SehirId = bartinId, CreatedAt = createdDate, IsDeleted = false },

                // 75 — Ardahan (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000917"), Kod = "75-01", Ad = "Çıldır", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000918"), Kod = "75-02", Ad = "Damal", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000919"), Kod = "75-03", Ad = "Göle", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000920"), Kod = "75-04", Ad = "Hanak", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000921"), Kod = "75-05", Ad = "Merkez", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false }, // Ardahan Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000922"), Kod = "75-06", Ad = "Posof", SehirId = ardahanId, CreatedAt = createdDate, IsDeleted = false }
            );
            // 76–81 şehir Id'leri (SehirSeedData ile birebir olmalı)
            var igdirId = Guid.Parse("10000000-0000-0000-0000-000000000076"); // 76
            var yalovaId = Guid.Parse("10000000-0000-0000-0000-000000000077"); // 77
            var karabukId = Guid.Parse("10000000-0000-0000-0000-000000000078"); // 78
            var kilisId = Guid.Parse("10000000-0000-0000-0000-000000000079"); // 79
            var osmaniyeId = Guid.Parse("10000000-0000-0000-0000-000000000080"); // 80
            var duzceId = Guid.Parse("10000000-0000-0000-0000-000000000081"); // 81

            modelBuilder.Entity<Ilce>().HasData(
                // 76 — Iğdır (4)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000923"), Kod = "76-01", Ad = "Aralık", SehirId = igdirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000924"), Kod = "76-02", Ad = "Karakoyunlu", SehirId = igdirId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000925"), Kod = "76-03", Ad = "Merkez", SehirId = igdirId, CreatedAt = createdDate, IsDeleted = false }, // Iğdır Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000926"), Kod = "76-04", Ad = "Tuzluca", SehirId = igdirId, CreatedAt = createdDate, IsDeleted = false },

                // 77 — Yalova (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000927"), Kod = "77-01", Ad = "Altınova", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000928"), Kod = "77-02", Ad = "Armutlu", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000929"), Kod = "77-03", Ad = "Çınarcık", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000930"), Kod = "77-04", Ad = "Çiftlikköy", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false }, // "Ç/ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000931"), Kod = "77-05", Ad = "Merkez", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false }, // Yalova Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000932"), Kod = "77-06", Ad = "Termal", SehirId = yalovaId, CreatedAt = createdDate, IsDeleted = false },

                // 78 — Karabük (6)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000933"), Kod = "78-01", Ad = "Eflani", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000934"), Kod = "78-02", Ad = "Eskipazar", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000935"), Kod = "78-03", Ad = "Merkez", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false }, // Karabük Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000936"), Kod = "78-04", Ad = "Ovacık", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000937"), Kod = "78-05", Ad = "Safranbolu", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000938"), Kod = "78-06", Ad = "Yenice", SehirId = karabukId, CreatedAt = createdDate, IsDeleted = false },

                // 79 — Kilis (4)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000939"), Kod = "79-01", Ad = "Elbeyli", SehirId = kilisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000940"), Kod = "79-02", Ad = "Merkez", SehirId = kilisId, CreatedAt = createdDate, IsDeleted = false }, // Kilis Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000941"), Kod = "79-03", Ad = "Musabeyli", SehirId = kilisId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000942"), Kod = "79-04", Ad = "Polateli", SehirId = kilisId, CreatedAt = createdDate, IsDeleted = false },

                // 80 — Osmaniye (7)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000943"), Kod = "80-01", Ad = "Bahçe", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000944"), Kod = "80-02", Ad = "Düziçi", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false }, // "ü/ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000945"), Kod = "80-03", Ad = "Hasanbeyli", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000946"), Kod = "80-04", Ad = "Kadirli", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000947"), Kod = "80-05", Ad = "Merkez", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false }, // Osmaniye Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000948"), Kod = "80-06", Ad = "Sumbas", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000949"), Kod = "80-07", Ad = "Toprakkale", SehirId = osmaniyeId, CreatedAt = createdDate, IsDeleted = false },

                // 81 — Düzce (8)
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000950"), Kod = "81-01", Ad = "Akçakoca", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // "ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000951"), Kod = "81-02", Ad = "Cumayeri", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000952"), Kod = "81-03", Ad = "Çilimli", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // "Ç"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000953"), Kod = "81-04", Ad = "Gölyaka", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // "ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000954"), Kod = "81-05", Ad = "Gümüşova", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000955"), Kod = "81-06", Ad = "Kaynaşlı", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // "ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000956"), Kod = "81-07", Ad = "Merkez", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }, // Düzce Merkez
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000957"), Kod = "81-08", Ad = "Yığılca", SehirId = duzceId, CreatedAt = createdDate, IsDeleted = false }  // "ğ"
            );
            // 38 — Kayseri (16)
            var kayseriId = Guid.Parse("10000000-0000-0000-0000-000000000038"); // 38

            modelBuilder.Entity<Ilce>().HasData(
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000958"), Kod = "38-01", Ad = "Akkışla", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000959"), Kod = "38-02", Ad = "Bünyan", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000960"), Kod = "38-03", Ad = "Develi", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000961"), Kod = "38-04", Ad = "Felahiye", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000962"), Kod = "38-05", Ad = "Hacılar", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000963"), Kod = "38-06", Ad = "İncesu", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // "İ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000964"), Kod = "38-07", Ad = "Kocasinan", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000965"), Kod = "38-08", Ad = "Melikgazi", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000966"), Kod = "38-09", Ad = "Özvatan", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // "Ö"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000967"), Kod = "38-10", Ad = "Pınarbaşı", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // "ı/ş"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000968"), Kod = "38-11", Ad = "Sarıoğlan", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // "ı/ğ"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000969"), Kod = "38-12", Ad = "Sarız", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000970"), Kod = "38-13", Ad = "Talas", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // merkez ilçe
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000971"), Kod = "38-14", Ad = "Tomarza", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false },
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000972"), Kod = "38-15", Ad = "Yahyalı", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }, // "ı"
                new Ilce { Id = Guid.Parse("20000000-0000-0000-0000-000000000973"), Kod = "38-16", Ad = "Yeşilhisar", SehirId = kayseriId, CreatedAt = createdDate, IsDeleted = false }  // "ş"
            );

        }
    }
}
