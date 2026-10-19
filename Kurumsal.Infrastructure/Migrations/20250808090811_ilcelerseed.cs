using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ilcelerseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ilceler",
                columns: new[] { "Id", "Ad", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "Durum", "IsDeleted", "Kod", "SehirId", "UpdatedAt", "UpdatedByUserId" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), "Aladağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-01", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "Ceyhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-02", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "Çukurova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-03", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), "Feke", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-04", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000005"), "İmamoğlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-05", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000006"), "Karaisalı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-06", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000007"), "Karataş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-07", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000008"), "Kozan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-08", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000009"), "Pozantı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-09", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000010"), "Saimbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-10", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000011"), "Sarıçam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-11", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000012"), "Seyhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-12", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000013"), "Tufanbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-13", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000014"), "Yüreğir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-14", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000015"), "Yumurtalık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01-15", new Guid("10000000-0000-0000-0000-000000000001"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000016"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-01", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000017"), "Besni", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-02", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000018"), "Çelikhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-03", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000019"), "Gerger", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-04", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000020"), "Gölbaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-05", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000021"), "Kahta", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-06", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000022"), "Samsat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-07", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000023"), "Sincik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-08", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000024"), "Tut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02-09", new Guid("10000000-0000-0000-0000-000000000002"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000025"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-01", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000026"), "Başmakçı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-02", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000027"), "Bayat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-03", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000028"), "Bolvadin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-04", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000029"), "Çay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-05", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000030"), "Çobanlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-06", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000031"), "Dazkırı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-07", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000032"), "Dinar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-08", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000033"), "Emirdağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-09", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000034"), "Evciler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-10", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000035"), "Hocalar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-11", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000036"), "İhsaniye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-12", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000037"), "İscehisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-13", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000038"), "Kızılören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-14", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000039"), "Sandıklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-15", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000040"), "Sinanpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-16", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000041"), "Sultandağı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-17", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000042"), "Şuhut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03-18", new Guid("10000000-0000-0000-0000-000000000003"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000043"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-01", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000044"), "Diyadin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-02", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000045"), "Doğubayazıt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-03", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000046"), "Eleşkirt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-04", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000047"), "Hamur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-05", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000048"), "Patnos", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-06", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000049"), "Taşlıçay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-07", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000050"), "Tutak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04-08", new Guid("10000000-0000-0000-0000-000000000004"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000051"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-01", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000052"), "Göynücek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-02", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000053"), "Gümüşhacıköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-03", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000054"), "Hamamözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-04", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000055"), "Merzifon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-05", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000056"), "Suluova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-06", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000057"), "Taşova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05-07", new Guid("10000000-0000-0000-0000-000000000005"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000058"), "Altındağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-01", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000059"), "Akyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-02", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000060"), "Ayaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-03", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000061"), "Bala", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-04", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000062"), "Beypazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-05", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000063"), "Çamlıdere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-06", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000064"), "Çankaya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-07", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000065"), "Çubuk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-08", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000066"), "Elmadağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-09", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000067"), "Etimesgut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-10", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000068"), "Evren", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-11", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000069"), "Gölbaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-12", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000070"), "Güdül", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-13", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000071"), "Haymana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-14", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000072"), "Kahramankazan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-15", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000073"), "Kalecik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-16", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000074"), "Keçiören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-17", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000075"), "Kızılcahamam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-18", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000076"), "Mamak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-19", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000077"), "Nallıhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-20", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000078"), "Polatlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-21", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000079"), "Pursaklar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-22", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000080"), "Sincan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-23", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000081"), "Şereflikoçhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-24", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000082"), "Yenimahalle", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06-25", new Guid("10000000-0000-0000-0000-000000000006"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000083"), "Akseki", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-01", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000084"), "Aksu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-02", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000085"), "Alanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-03", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000086"), "Demre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-04", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000087"), "Döşemealtı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-05", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000088"), "Elmalı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-06", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000089"), "Finike", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-07", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000090"), "Gazipaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-08", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000091"), "Gündoğmuş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-09", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000092"), "İbradı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-10", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000093"), "Kaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-11", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000094"), "Kemer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-12", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000095"), "Kepez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-13", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000096"), "Konyaaltı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-14", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000097"), "Korkuteli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-15", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000098"), "Kumluca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-16", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000099"), "Manavgat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-17", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000100"), "Muratpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-18", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000101"), "Serik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07-19", new Guid("10000000-0000-0000-0000-000000000007"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000102"), "Ardanuç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-01", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000103"), "Arhavi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-02", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000104"), "Borçka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-03", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000105"), "Hopa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-04", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000106"), "Kemalpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-05", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000107"), "Murgul", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-06", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000108"), "Şavşat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-07", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000109"), "Yusufeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-08", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000110"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08-09", new Guid("10000000-0000-0000-0000-000000000008"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000111"), "Bozdoğan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-01", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000112"), "Buharkent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-02", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000113"), "Çine", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-03", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000114"), "Didim", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-04", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000115"), "Efeler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-05", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000116"), "Germencik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-06", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000117"), "İncirliova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-07", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000118"), "Karacasu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-08", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000119"), "Karpuzlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-09", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000120"), "Koçarlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-10", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000121"), "Köşk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-11", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000122"), "Kuşadası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-12", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000123"), "Kuyucak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-13", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000124"), "Nazilli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-14", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000125"), "Söke", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-15", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000126"), "Sultanhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-16", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000127"), "Yenipazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09-17", new Guid("10000000-0000-0000-0000-000000000009"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000128"), "Altıeylül", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-01", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000129"), "Ayvalık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-02", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000130"), "Balya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-03", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000131"), "Bandırma", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-04", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000132"), "Bigadiç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-05", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000133"), "Burhaniye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-06", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000134"), "Dursunbey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-07", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000135"), "Edremit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-08", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000136"), "Erdek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-09", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000137"), "Gömeç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-10", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000138"), "Gönen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-11", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000139"), "Havran", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-12", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000140"), "İvrindi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-13", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000141"), "Karesi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-14", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000142"), "Kepsut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-15", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000143"), "Manyas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-16", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000144"), "Marmara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-17", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000145"), "Savaştepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-18", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000146"), "Sındırgı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-19", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000147"), "Susurluk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10-20", new Guid("10000000-0000-0000-0000-000000000010"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000148"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-01", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000149"), "Bozüyük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-02", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000150"), "Gölpazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-03", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000151"), "İnhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-04", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000152"), "Osmaneli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-05", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000153"), "Pazaryeri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-06", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000154"), "Söğüt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-07", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000155"), "Yenipazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11-08", new Guid("10000000-0000-0000-0000-000000000011"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000156"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-01", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000157"), "Adaklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-02", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000158"), "Genç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-03", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000159"), "Karlıova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-04", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000160"), "Kiğı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-05", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000161"), "Solhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-06", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000162"), "Yayladere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-07", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000163"), "Yedisu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12-08", new Guid("10000000-0000-0000-0000-000000000012"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000164"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-01", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000165"), "Adilcevaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-02", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000166"), "Ahlat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-03", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000167"), "Güroymak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-04", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000168"), "Hizan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-05", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000169"), "Mutki", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-06", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000170"), "Tatvan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13-07", new Guid("10000000-0000-0000-0000-000000000013"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000171"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-01", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000172"), "Dörtdivan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-02", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000173"), "Gerede", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-03", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000174"), "Göynük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-04", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000175"), "Kıbrıscık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-05", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000176"), "Mengen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-06", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000177"), "Mudurnu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-07", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000178"), "Seben", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-08", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000179"), "Yeniçağa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14-09", new Guid("10000000-0000-0000-0000-000000000014"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000180"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-01", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000181"), "Ağlasun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-02", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000182"), "Altınyayla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-03", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000183"), "Bucak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-04", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000184"), "Çavdır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-05", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000185"), "Çeltikçi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-06", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000186"), "Gölhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-07", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000187"), "Karamanlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-08", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000188"), "Kemer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-09", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000189"), "Tefenni", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-10", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000190"), "Yeşilova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15-11", new Guid("10000000-0000-0000-0000-000000000015"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000191"), "Büyükorhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-01", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000192"), "Gemlik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-02", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000193"), "Gürsu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-03", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000194"), "Harmancık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-04", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000195"), "İnegöl", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-05", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000196"), "İznik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-06", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000197"), "Karacabey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-07", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000198"), "Keles", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-08", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000199"), "Kestel", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-09", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000200"), "Mudanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-10", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000201"), "Mustafakemalpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-11", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000202"), "Nilüfer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-12", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000203"), "Orhaneli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-13", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000204"), "Orhangazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-14", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000205"), "Osmangazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-15", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000206"), "Yenişehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-16", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000207"), "Yıldırım", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16-17", new Guid("10000000-0000-0000-0000-000000000016"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000208"), "Ayvacık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-01", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000209"), "Bayramiç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-02", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000210"), "Biga", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-03", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000211"), "Bozcaada", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-04", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000212"), "Çan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-05", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000213"), "Eceabat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-06", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000214"), "Ezine", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-07", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000215"), "Gelibolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-08", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000216"), "Gökçeada", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-09", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000217"), "Lapseki", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-10", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000218"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-11", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000219"), "Yenice", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17-12", new Guid("10000000-0000-0000-0000-000000000017"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000220"), "Atkaracalar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-01", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000221"), "Bayramören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-02", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000222"), "Çerkeş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-03", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000223"), "Eldivan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-04", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000224"), "Ilgaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-05", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000225"), "Kızılırmak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-06", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000226"), "Korgun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-07", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000227"), "Kurşunlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-08", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000228"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-09", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000229"), "Orta", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-10", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000230"), "Şabanözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-11", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000231"), "Yapraklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18-12", new Guid("10000000-0000-0000-0000-000000000018"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000232"), "Alaca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-01", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000233"), "Bayat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-02", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000234"), "Boğazkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-03", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000235"), "Dodurga", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-04", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000236"), "İskilip", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-05", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000237"), "Kargı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-06", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000238"), "Laçin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-07", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000239"), "Mecitözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-08", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000240"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-09", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000241"), "Oğuzlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-10", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000242"), "Ortaköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-11", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000243"), "Osmancık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-12", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000244"), "Sungurlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-13", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000245"), "Uğurludağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19-14", new Guid("10000000-0000-0000-0000-000000000019"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000246"), "Acıpayam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-01", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000247"), "Babadağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-02", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000248"), "Baklan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-03", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000249"), "Bekilli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-04", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000250"), "Beyağaç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-05", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000251"), "Bozkurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-06", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000252"), "Buldan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-07", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000253"), "Çal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-08", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000254"), "Çameli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-09", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000255"), "Çardak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-10", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000256"), "Çivril", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-11", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000257"), "Güney", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-12", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000258"), "Honaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-13", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000259"), "Kale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-14", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000260"), "Merkezefendi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-15", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000261"), "Pamukkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-16", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000262"), "Sarayköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-17", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000263"), "Serinhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-18", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000264"), "Tavas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20-19", new Guid("10000000-0000-0000-0000-000000000020"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000265"), "Bağlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-01", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000266"), "Bismil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-02", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000267"), "Çermik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-03", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000268"), "Çınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-04", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000269"), "Çüngüş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-05", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000270"), "Dicle", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-06", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000271"), "Eğil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-07", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000272"), "Ergani", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-08", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000273"), "Hani", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-09", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000274"), "Hazro", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-10", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000275"), "Kayapınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-11", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000276"), "Kocaköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-12", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000277"), "Kulp", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-13", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000278"), "Lice", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-14", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000279"), "Silvan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-15", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000280"), "Sur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-16", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000281"), "Yenişehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21-17", new Guid("10000000-0000-0000-0000-000000000021"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000282"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-01", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000283"), "Enez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-02", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000284"), "Havsa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-03", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000285"), "İpsala", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-04", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000286"), "Keşan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-05", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000287"), "Lalapaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-06", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000288"), "Meriç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-07", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000289"), "Süloğlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-08", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000290"), "Uzunköprü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22-09", new Guid("10000000-0000-0000-0000-000000000022"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000291"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-01", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000292"), "Ağın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-02", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000293"), "Alacakaya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-03", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000294"), "Arıcak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-04", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000295"), "Baskil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-05", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000296"), "Karakoçan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-06", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000297"), "Keban", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-07", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000298"), "Kovancılar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-08", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000299"), "Maden", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-09", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000300"), "Palu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-10", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000301"), "Sivrice", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23-11", new Guid("10000000-0000-0000-0000-000000000023"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000302"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-01", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000303"), "Çayırlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-02", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000304"), "İliç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-03", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000305"), "Kemah", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-04", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000306"), "Kemaliye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-05", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000307"), "Otlukbeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-06", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000308"), "Refahiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-07", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000309"), "Tercan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-08", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000310"), "Üzümlü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24-09", new Guid("10000000-0000-0000-0000-000000000024"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000311"), "Aşkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-01", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000312"), "Aziziye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-02", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000313"), "Çat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-03", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000314"), "Hınıs", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-04", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000315"), "Horasan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-05", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000316"), "İspir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-06", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000317"), "Karaçoban", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-07", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000318"), "Karayazı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-08", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000319"), "Köprüköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-09", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000320"), "Narman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-10", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000321"), "Oltu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-11", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000322"), "Olur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-12", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000323"), "Palandöken", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-13", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000324"), "Pasinler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-14", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000325"), "Pazaryolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-15", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000326"), "Şenkaya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-16", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000327"), "Tekman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-17", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000328"), "Tortum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-18", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000329"), "Uzundere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-19", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000330"), "Yakutiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25-20", new Guid("10000000-0000-0000-0000-000000000025"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000331"), "Alpu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-01", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000332"), "Beylikova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-02", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000333"), "Çifteler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-03", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000334"), "Günyüzü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-04", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000335"), "Han", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-05", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000336"), "İnönü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-06", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000337"), "Mahmudiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-07", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000338"), "Mihalgazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-08", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000339"), "Mihalıççık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-09", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000340"), "Odunpazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-10", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000341"), "Sarıcakaya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-11", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000342"), "Seyitgazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-12", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000343"), "Sivrihisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-13", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000344"), "Tepebaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26-14", new Guid("10000000-0000-0000-0000-000000000026"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000345"), "Araban", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-01", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000346"), "İslahiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-02", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000347"), "Karkamış", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-03", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000348"), "Nizip", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-04", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000349"), "Nurdağı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-05", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000350"), "Oğuzeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-06", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000351"), "Şahinbey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-07", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000352"), "Şehitkamil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-08", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000353"), "Yavuzeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27-09", new Guid("10000000-0000-0000-0000-000000000027"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000354"), "Alucra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-01", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000355"), "Bulancak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-02", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000356"), "Çamoluk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-03", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000357"), "Çanakçı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-04", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000358"), "Dereli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-05", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000359"), "Doğankent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-06", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000360"), "Espiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-07", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000361"), "Eynesil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-08", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000362"), "Görele", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-09", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000363"), "Güce", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-10", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000364"), "Keşap", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-11", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000365"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-12", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000366"), "Piraziz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-13", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000367"), "Şebinkarahisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-14", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000368"), "Tirebolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-15", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000369"), "Yağlıdere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28-16", new Guid("10000000-0000-0000-0000-000000000028"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000370"), "Kelkit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-01", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000371"), "Köse", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-02", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000372"), "Kürtün", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-03", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000373"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-04", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000374"), "Şiran", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-05", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000375"), "Torul", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29-06", new Guid("10000000-0000-0000-0000-000000000029"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000376"), "Çukurca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30-01", new Guid("10000000-0000-0000-0000-000000000030"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000377"), "Derecik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30-02", new Guid("10000000-0000-0000-0000-000000000030"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000378"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30-03", new Guid("10000000-0000-0000-0000-000000000030"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000379"), "Şemdinli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30-04", new Guid("10000000-0000-0000-0000-000000000030"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000380"), "Yüksekova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30-05", new Guid("10000000-0000-0000-0000-000000000030"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000381"), "Altınözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-01", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000382"), "Antakya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-02", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000383"), "Arsuz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-03", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000384"), "Belen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-04", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000385"), "Defne", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-05", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000386"), "Dörtyol", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-06", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000387"), "Erzin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-07", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000388"), "Hassa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-08", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000389"), "İskenderun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-09", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000390"), "Kırıkhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-10", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000391"), "Kumlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-11", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000392"), "Payas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-12", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000393"), "Reyhanlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-13", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000394"), "Samandağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-14", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000395"), "Yayladağı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31-15", new Guid("10000000-0000-0000-0000-000000000031"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000396"), "Aksu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-01", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000397"), "Atabey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-02", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000398"), "Eğirdir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-03", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000399"), "Gelendost", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-04", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000400"), "Gönen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-05", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000401"), "Keçiborlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-06", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000402"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-07", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000403"), "Senirkent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-08", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000404"), "Sütçüler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-09", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000405"), "Şarkikaraağaç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-10", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000406"), "Uluborlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-11", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000407"), "Yalvaç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-12", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000408"), "Yenişarbademli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32-13", new Guid("10000000-0000-0000-0000-000000000032"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000409"), "Akdeniz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-01", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000410"), "Anamur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-02", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000411"), "Aydıncık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-03", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000412"), "Bozyazı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-04", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000413"), "Çamlıyayla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-05", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000414"), "Erdemli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-06", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000415"), "Gülnar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-07", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000416"), "Mezitli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-08", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000417"), "Mut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-09", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000418"), "Silifke", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-10", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000419"), "Tarsus", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-11", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000420"), "Toroslar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-12", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000421"), "Yenişehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33-13", new Guid("10000000-0000-0000-0000-000000000033"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000422"), "Adalar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-01", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000423"), "Arnavutköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-02", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000424"), "Ataşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-03", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000425"), "Avcılar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-04", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000426"), "Bağcılar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-05", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000427"), "Bahçelievler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-06", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000428"), "Bakırköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-07", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000429"), "Başakşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-08", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000430"), "Bayrampaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-09", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000431"), "Beşiktaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-10", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000432"), "Beykoz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-11", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000433"), "Beylikdüzü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-12", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000434"), "Beyoğlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-13", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000435"), "Büyükçekmece", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-14", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000436"), "Çatalca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-15", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000437"), "Çekmeköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-16", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000438"), "Esenler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-17", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000439"), "Esenyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-18", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000440"), "Eyüpsultan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-19", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000441"), "Fatih", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-20", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000442"), "Gaziosmanpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-21", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000443"), "Güngören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-22", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000444"), "Kadıköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-23", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000445"), "Kağıthane", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-24", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000446"), "Kartal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-25", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000447"), "Küçükçekmece", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-26", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000448"), "Maltepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-27", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000449"), "Pendik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-28", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000450"), "Sancaktepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-29", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000451"), "Sarıyer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-30", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000452"), "Silivri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-31", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000453"), "Şile", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-32", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000454"), "Şişli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-33", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000455"), "Sultanbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-34", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000456"), "Sultangazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-35", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000457"), "Tuzla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-36", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000458"), "Ümraniye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-37", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000459"), "Üsküdar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-38", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000460"), "Zeytinburnu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34-39", new Guid("10000000-0000-0000-0000-000000000034"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000461"), "Aliağa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-01", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000462"), "Balçova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-02", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000463"), "Bayındır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-03", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000464"), "Bayraklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-04", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000465"), "Bergama", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-05", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000466"), "Beydağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-06", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000467"), "Bornova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-07", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000468"), "Buca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-08", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000469"), "Çeşme", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-09", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000470"), "Çiğli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-10", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000471"), "Dikili", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-11", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000472"), "Foça", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-12", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000473"), "Gaziemir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-13", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000474"), "Güzelbahçe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-14", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000475"), "Karabağlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-15", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000476"), "Karaburun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-16", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000477"), "Karşıyaka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-17", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000478"), "Kemalpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-18", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000479"), "Kınık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-19", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000480"), "Kiraz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-20", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000481"), "Konak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-21", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000482"), "Menderes", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-22", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000483"), "Menemen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-23", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000484"), "Narlıdere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-24", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000485"), "Ödemiş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-25", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000486"), "Seferihisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-26", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000487"), "Selçuk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-27", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000488"), "Tire", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-28", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000489"), "Torbalı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-29", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000490"), "Urla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35-30", new Guid("10000000-0000-0000-0000-000000000035"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000491"), "Akyaka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-01", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000492"), "Arpaçay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-02", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000493"), "Digor", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-03", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000494"), "Kağızman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-04", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000495"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-05", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000496"), "Sarıkamış", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-06", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000497"), "Selim", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-07", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000498"), "Susuz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36-08", new Guid("10000000-0000-0000-0000-000000000036"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000499"), "Abana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-01", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000500"), "Ağlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-02", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000501"), "Araç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-03", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000502"), "Azdavay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-04", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000503"), "Bozkurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-05", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000504"), "Cide", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-06", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000505"), "Çatalzeytin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-07", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000506"), "Daday", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-08", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000507"), "Devrekani", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-09", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000508"), "Doğanyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-10", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000509"), "Hanönü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-11", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000510"), "İhsangazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-12", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000511"), "İnebolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-13", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000512"), "Küre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-14", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000513"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-15", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000514"), "Pınarbaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-16", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000515"), "Seydiler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-17", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000516"), "Şenpazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-18", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000517"), "Taşköprü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-19", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000518"), "Tosya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37-20", new Guid("10000000-0000-0000-0000-000000000037"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000519"), "Babaeski", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-01", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000520"), "Demirköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-02", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000521"), "Kofçaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-03", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000522"), "Lüleburgaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-04", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000523"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-05", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000524"), "Pehlivanköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-06", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000525"), "Pınarhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-07", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000526"), "Vize", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39-08", new Guid("10000000-0000-0000-0000-000000000039"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000527"), "Akçakent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-01", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000528"), "Akpınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-02", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000529"), "Boztepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-03", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000530"), "Çiçekdağı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-04", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000531"), "Kaman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-05", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000532"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-06", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000533"), "Mucur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40-07", new Guid("10000000-0000-0000-0000-000000000040"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000534"), "Başiskele", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-01", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000535"), "Çayırova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-02", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000536"), "Darıca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-03", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000537"), "Derince", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-04", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000538"), "Dilovası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-05", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000539"), "Gebze", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-06", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000540"), "Gölcük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-07", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000541"), "İzmit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-08", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000542"), "Kandıra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-09", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000543"), "Karamürsel", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-10", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000544"), "Kartepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-11", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000545"), "Körfez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41-12", new Guid("10000000-0000-0000-0000-000000000041"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000546"), "Ahırlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-01", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000547"), "Akören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-02", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000548"), "Akşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-03", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000549"), "Altınekin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-04", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000550"), "Beyşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-05", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000551"), "Bozkır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-06", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000552"), "Cihanbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-07", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000553"), "Çeltik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-08", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000554"), "Çumra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-09", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000555"), "Derbent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-10", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000556"), "Derebucak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-11", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000557"), "Doğanhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-12", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000558"), "Emirgazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-13", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000559"), "Ereğli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-14", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000560"), "Güneysınır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-15", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000561"), "Hadim", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-16", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000562"), "Halkapınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-17", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000563"), "Hüyük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-18", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000564"), "Ilgın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-19", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000565"), "Kadınhanı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-20", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000566"), "Karapınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-21", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000567"), "Karatay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-22", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000568"), "Kulu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-23", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000569"), "Meram", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-24", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000570"), "Sarayönü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-25", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000571"), "Selçuklu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-26", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000572"), "Seydişehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-27", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000573"), "Taşkent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-28", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000574"), "Tuzlukçu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-29", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000575"), "Yalıhüyük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-30", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000576"), "Yunak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42-31", new Guid("10000000-0000-0000-0000-000000000042"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000577"), "Altıntaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-01", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000578"), "Aslanapa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-02", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000579"), "Çavdarhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-03", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000580"), "Domaniç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-04", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000581"), "Dumlupınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-05", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000582"), "Emet", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-06", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000583"), "Gediz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-07", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000584"), "Hisarcık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-08", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000585"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-09", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000586"), "Pazarlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-10", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000587"), "Simav", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-11", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000588"), "Şaphane", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-12", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000589"), "Tavşanlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43-13", new Guid("10000000-0000-0000-0000-000000000043"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000590"), "Akçadağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-01", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000591"), "Arapgir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-02", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000592"), "Arguvan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-03", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000593"), "Battalgazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-04", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000594"), "Darende", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-05", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000595"), "Doğanşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-06", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000596"), "Doğanyol", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-07", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000597"), "Hekimhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-08", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000598"), "Kale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-09", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000599"), "Kuluncak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-10", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000600"), "Pütürge", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-11", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000601"), "Yazıhan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-12", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000602"), "Yeşilyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44-13", new Guid("10000000-0000-0000-0000-000000000044"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000603"), "Ahmetli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-01", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000604"), "Akhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-02", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000605"), "Alaşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-03", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000606"), "Demirci", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-04", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000607"), "Gölmarmara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-05", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000608"), "Gördes", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-06", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000609"), "Kırkağaç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-07", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000610"), "Köprübaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-08", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000611"), "Kula", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-09", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000612"), "Salihli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-10", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000613"), "Sarıgöl", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-11", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000614"), "Saruhanlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-12", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000615"), "Selendi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-13", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000616"), "Soma", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-14", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000617"), "Şehzadeler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-15", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000618"), "Turgutlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-16", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000619"), "Yunusemre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45-17", new Guid("10000000-0000-0000-0000-000000000045"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000620"), "Afşin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-01", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000621"), "Andırın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-02", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000622"), "Çağlayancerit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-03", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000623"), "Dulkadiroğlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-04", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000624"), "Ekinözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-05", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000625"), "Elbistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-06", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000626"), "Göksun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-07", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000627"), "Nurhak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-08", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000628"), "Onikişubat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-09", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000629"), "Pazarcık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-10", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000630"), "Türkoğlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46-11", new Guid("10000000-0000-0000-0000-000000000046"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000631"), "Artuklu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-01", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000632"), "Dargeçit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-02", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000633"), "Derik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-03", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000634"), "Kızıltepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-04", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000635"), "Mazıdağı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-05", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000636"), "Midyat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-06", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000637"), "Nusaybin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-07", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000638"), "Ömerli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-08", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000639"), "Savur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-09", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000640"), "Yeşilli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47-10", new Guid("10000000-0000-0000-0000-000000000047"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000641"), "Bodrum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-01", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000642"), "Dalaman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-02", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000643"), "Datça", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-03", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000644"), "Fethiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-04", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000645"), "Kavaklıdere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-05", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000646"), "Köyceğiz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-06", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000647"), "Marmaris", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-07", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000648"), "Menteşe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-08", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000649"), "Milas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-09", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000650"), "Ortaca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-10", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000651"), "Seydikemer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-11", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000652"), "Ula", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-12", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000653"), "Yatağan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48-13", new Guid("10000000-0000-0000-0000-000000000048"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000654"), "Bulanık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-01", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000655"), "Hasköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-02", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000656"), "Korkut", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-03", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000657"), "Malazgirt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-04", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000658"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-05", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000659"), "Varto", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49-06", new Guid("10000000-0000-0000-0000-000000000049"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000660"), "Acıgöl", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-01", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000661"), "Avanos", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-02", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000662"), "Derinkuyu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-03", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000663"), "Gülşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-04", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000664"), "Hacıbektaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-05", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000665"), "Kozaklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-06", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000666"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-07", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000667"), "Ürgüp", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50-08", new Guid("10000000-0000-0000-0000-000000000050"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000668"), "Altunhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-01", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000669"), "Bor", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-02", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000670"), "Çamardı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-03", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000671"), "Çiftlik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-04", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000672"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-05", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000673"), "Ulukışla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51-06", new Guid("10000000-0000-0000-0000-000000000051"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000674"), "Akkuş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-01", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000675"), "Altınordu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-02", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000676"), "Aybastı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-03", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000677"), "Çamaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-04", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000678"), "Çatalpınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-05", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000679"), "Çaybaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-06", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000680"), "Fatsa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-07", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000681"), "Gölköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-08", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000682"), "Gülyalı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-09", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000683"), "Gürgentepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-10", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000684"), "İkizce", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-11", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000685"), "Kabadüz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-12", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000686"), "Kabataş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-13", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000687"), "Korgan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-14", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000688"), "Kumru", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-15", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000689"), "Mesudiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-16", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000690"), "Perşembe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-17", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000691"), "Ulubey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-18", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000692"), "Ünye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52-19", new Guid("10000000-0000-0000-0000-000000000052"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000693"), "Ardeşen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-01", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000694"), "Çamlıhemşin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-02", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000695"), "Çayeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-03", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000696"), "Derepazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-04", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000697"), "Fındıklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-05", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000698"), "Güneysu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-06", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000699"), "Hemşin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-07", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000700"), "İkizdere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-08", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000701"), "İyidere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-09", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000702"), "Kalkandere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-10", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000703"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-11", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000704"), "Pazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53-12", new Guid("10000000-0000-0000-0000-000000000053"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000705"), "Adapazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-01", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000706"), "Akyazı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-02", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000707"), "Arifiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-03", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000708"), "Erenler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-04", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000709"), "Ferizli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-05", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000710"), "Geyve", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-06", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000711"), "Hendek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-07", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000712"), "Karapürçek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-08", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000713"), "Karasu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-09", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000714"), "Kaynarca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-10", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000715"), "Kocaali", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-11", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000716"), "Pamukova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-12", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000717"), "Sapanca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-13", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000718"), "Serdivan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-14", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000719"), "Söğütlü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-15", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000720"), "Taraklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54-16", new Guid("10000000-0000-0000-0000-000000000054"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000721"), "Alaçam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-01", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000722"), "Asarcık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-02", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000723"), "Atakum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-03", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000724"), "Ayvacık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-04", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000725"), "Bafra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-05", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000726"), "Canik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-06", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000727"), "Çarşamba", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-07", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000728"), "Havza", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-08", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000729"), "İlkadım", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-09", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000730"), "Kavak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-10", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000731"), "Ladik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-11", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000732"), "Ondokuzmayıs", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-12", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000733"), "Salıpazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-13", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000734"), "Tekkeköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-14", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000735"), "Terme", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-15", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000736"), "Vezirköprü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-16", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000737"), "Yakakent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55-17", new Guid("10000000-0000-0000-0000-000000000055"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000738"), "Baykan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-01", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000739"), "Eruh", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-02", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000740"), "Kurtalan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-03", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000741"), "Pervari", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-04", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000742"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-05", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000743"), "Şirvan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-06", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000744"), "Tillo", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56-07", new Guid("10000000-0000-0000-0000-000000000056"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000745"), "Ayancık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-01", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000746"), "Boyabat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-02", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000747"), "Dikmen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-03", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000748"), "Durağan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-04", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000749"), "Erfelek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-05", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000750"), "Gerze", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-06", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000751"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-07", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000752"), "Saraydüzü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-08", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000753"), "Türkeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57-09", new Guid("10000000-0000-0000-0000-000000000057"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000754"), "Akıncılar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-01", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000755"), "Altınyayla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-02", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000756"), "Divriği", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-03", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000757"), "Doğanşar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-04", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000758"), "Gemerek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-05", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000759"), "Gölova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-06", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000760"), "Gürün", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-07", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000761"), "Hafik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-08", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000762"), "İmranlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-09", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000763"), "Kangal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-10", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000764"), "Koyulhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-11", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000765"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-12", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000766"), "Şarkışla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-13", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000767"), "Suşehri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-14", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000768"), "Ulaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-15", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000769"), "Yıldızeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-16", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000770"), "Zara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58-17", new Guid("10000000-0000-0000-0000-000000000058"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000771"), "Çerkezköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-01", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000772"), "Çorlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-02", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000773"), "Ergene", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-03", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000774"), "Hayrabolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-04", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000775"), "Kapaklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-05", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000776"), "Malkara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-06", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000777"), "Marmaraereğlisi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-07", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000778"), "Muratlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-08", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000779"), "Saray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-09", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000780"), "Süleymanpaşa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-10", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000781"), "Şarköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59-11", new Guid("10000000-0000-0000-0000-000000000059"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000782"), "Almus", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-01", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000783"), "Artova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-02", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000784"), "Başçiftlik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-03", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000785"), "Erbaa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-04", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000786"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-05", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000787"), "Niksar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-06", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000788"), "Pazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-07", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000789"), "Reşadiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-08", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000790"), "Sulusaray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-09", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000791"), "Turhal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-10", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000792"), "Yeşilyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-11", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000793"), "Zile", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60-12", new Guid("10000000-0000-0000-0000-000000000060"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000794"), "Akçaabat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-01", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000795"), "Araklı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-02", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000796"), "Arsin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-03", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000797"), "Beşikdüzü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-04", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000798"), "Çarşıbaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-05", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000799"), "Çaykara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-06", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000800"), "Dernekpazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-07", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000801"), "Düzköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-08", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000802"), "Hayrat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-09", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000803"), "Köprübaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-10", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000804"), "Maçka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-11", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000805"), "Of", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-12", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000806"), "Ortahisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-13", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000807"), "Sürmene", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-14", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000808"), "Şalpazarı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-15", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000809"), "Tonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-16", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000810"), "Vakfıkebir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-17", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000811"), "Yomra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61-18", new Guid("10000000-0000-0000-0000-000000000061"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000812"), "Çemişgezek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-01", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000813"), "Hozat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-02", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000814"), "Mazgirt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-03", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000815"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-04", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000816"), "Nazımiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-05", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000817"), "Ovacık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-06", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000818"), "Pertek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-07", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000819"), "Pülümür", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62-08", new Guid("10000000-0000-0000-0000-000000000062"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000820"), "Akçakale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-01", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000821"), "Birecik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-02", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000822"), "Bozova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-03", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000823"), "Ceylanpınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-04", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000824"), "Eyyübiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-05", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000825"), "Halfeti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-06", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000826"), "Haliliye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-07", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000827"), "Harran", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-08", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000828"), "Hilvan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-09", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000829"), "Karaköprü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-10", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000830"), "Siverek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-11", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000831"), "Suruç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-12", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000832"), "Viranşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63-13", new Guid("10000000-0000-0000-0000-000000000063"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000833"), "Banaz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-01", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000834"), "Eşme", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-02", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000835"), "Karahallı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-03", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000836"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-04", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000837"), "Sivaslı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-05", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000838"), "Ulubey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64-06", new Guid("10000000-0000-0000-0000-000000000064"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000839"), "Bahçesaray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-01", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000840"), "Başkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-02", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000841"), "Çaldıran", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-03", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000842"), "Çatak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-04", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000843"), "Edremit", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-05", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000844"), "Erciş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-06", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000845"), "Gevaş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-07", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000846"), "Gürpınar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-08", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000847"), "İpekyolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-09", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000848"), "Muradiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-10", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000849"), "Özalp", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-11", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000850"), "Saray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-12", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000851"), "Tuşba", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65-13", new Guid("10000000-0000-0000-0000-000000000065"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000852"), "Akdağmadeni", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-01", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000853"), "Aydıncık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-02", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000854"), "Boğazlıyan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-03", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000855"), "Çandır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-04", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000856"), "Çayıralan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-05", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000857"), "Çekerek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-06", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000858"), "Kadışehri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-07", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000859"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-08", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000860"), "Saraykent", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-09", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000861"), "Sarıkaya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-10", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000862"), "Sorgun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-11", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000863"), "Şefaatli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-12", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000864"), "Yerköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-13", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000865"), "Yenifakılı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66-14", new Guid("10000000-0000-0000-0000-000000000066"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000866"), "Alaplı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-01", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000867"), "Çaycuma", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-02", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000868"), "Devrek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-03", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000869"), "Gökçebey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-04", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000870"), "Karadeniz Ereğli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-05", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000871"), "Kilimli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-06", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000872"), "Kozlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-07", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000873"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67-08", new Guid("10000000-0000-0000-0000-000000000067"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000874"), "Ağaçören", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-01", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000875"), "Eskil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-02", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000876"), "Gülağaç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-03", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000877"), "Güzelyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-04", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000878"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-05", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000879"), "Ortaköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-06", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000880"), "Sarıyahşi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-07", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000881"), "Sultanhanı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68-08", new Guid("10000000-0000-0000-0000-000000000068"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000882"), "Aydıntepe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "69-01", new Guid("10000000-0000-0000-0000-000000000069"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000883"), "Demirözü", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "69-02", new Guid("10000000-0000-0000-0000-000000000069"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000884"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "69-03", new Guid("10000000-0000-0000-0000-000000000069"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000885"), "Ayrancı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-01", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000886"), "Başyayla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-02", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000887"), "Ermenek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-03", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000888"), "Kazımkarabekir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-04", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000889"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-05", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000890"), "Sarıveliler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70-06", new Guid("10000000-0000-0000-0000-000000000070"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000891"), "Bahşılı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-01", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000892"), "Balışeyh", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-02", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000893"), "Çelebi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-03", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000894"), "Delice", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-04", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000895"), "Karakeçili", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-05", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000896"), "Keskin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-06", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000897"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-07", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000898"), "Sulakyurt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-08", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000899"), "Yahşihan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71-09", new Guid("10000000-0000-0000-0000-000000000071"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000900"), "Beşiri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-01", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000901"), "Gercüş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-02", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000902"), "Hasankeyf", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-03", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000903"), "Kozluk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-04", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000904"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-05", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000905"), "Sason", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72-06", new Guid("10000000-0000-0000-0000-000000000072"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000906"), "Beytüşşebap", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-01", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000907"), "Cizre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-02", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000908"), "Güçlükonak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-03", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000909"), "İdil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-04", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000910"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-05", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000911"), "Silopi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-06", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000912"), "Uludere", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73-07", new Guid("10000000-0000-0000-0000-000000000073"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000913"), "Amasra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "74-01", new Guid("10000000-0000-0000-0000-000000000074"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000914"), "Kurucaşile", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "74-02", new Guid("10000000-0000-0000-0000-000000000074"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000915"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "74-03", new Guid("10000000-0000-0000-0000-000000000074"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000916"), "Ulus", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "74-04", new Guid("10000000-0000-0000-0000-000000000074"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000917"), "Çıldır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-01", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000918"), "Damal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-02", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000919"), "Göle", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-03", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000920"), "Hanak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-04", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000921"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-05", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000922"), "Posof", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75-06", new Guid("10000000-0000-0000-0000-000000000075"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000923"), "Aralık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "76-01", new Guid("10000000-0000-0000-0000-000000000076"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000924"), "Karakoyunlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "76-02", new Guid("10000000-0000-0000-0000-000000000076"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000925"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "76-03", new Guid("10000000-0000-0000-0000-000000000076"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000926"), "Tuzluca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "76-04", new Guid("10000000-0000-0000-0000-000000000076"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000927"), "Altınova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-01", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000928"), "Armutlu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-02", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000929"), "Çınarcık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-03", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000930"), "Çiftlikköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-04", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000931"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-05", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000932"), "Termal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77-06", new Guid("10000000-0000-0000-0000-000000000077"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000933"), "Eflani", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-01", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000934"), "Eskipazar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-02", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000935"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-03", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000936"), "Ovacık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-04", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000937"), "Safranbolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-05", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000938"), "Yenice", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78-06", new Guid("10000000-0000-0000-0000-000000000078"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000939"), "Elbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "79-01", new Guid("10000000-0000-0000-0000-000000000079"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000940"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "79-02", new Guid("10000000-0000-0000-0000-000000000079"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000941"), "Musabeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "79-03", new Guid("10000000-0000-0000-0000-000000000079"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000942"), "Polateli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "79-04", new Guid("10000000-0000-0000-0000-000000000079"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000943"), "Bahçe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-01", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000944"), "Düziçi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-02", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000945"), "Hasanbeyli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-03", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000946"), "Kadirli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-04", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000947"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-05", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000948"), "Sumbas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-06", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000949"), "Toprakkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80-07", new Guid("10000000-0000-0000-0000-000000000080"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000950"), "Akçakoca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-01", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000951"), "Cumayeri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-02", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000952"), "Çilimli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-03", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000953"), "Gölyaka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-04", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000954"), "Gümüşova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-05", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000955"), "Kaynaşlı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-06", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000956"), "Merkez", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-07", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000957"), "Yığılca", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81-08", new Guid("10000000-0000-0000-0000-000000000081"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000958"), "Akkışla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-01", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000959"), "Bünyan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-02", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000960"), "Develi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-03", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000961"), "Felahiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-04", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000962"), "Hacılar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-05", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000963"), "İncesu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-06", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000964"), "Kocasinan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-07", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000965"), "Melikgazi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-08", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000966"), "Özvatan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-09", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000967"), "Pınarbaşı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-10", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000968"), "Sarıoğlan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-11", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000969"), "Sarız", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-12", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000970"), "Talas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-13", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000971"), "Tomarza", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-14", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000972"), "Yahyalı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-15", new Guid("10000000-0000-0000-0000-000000000038"), null, null },
                    { new Guid("20000000-0000-0000-0000-000000000973"), "Yeşilhisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38-16", new Guid("10000000-0000-0000-0000-000000000038"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000107"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000108"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000111"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000112"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000113"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000114"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000115"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000116"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000117"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000118"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000119"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000120"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000121"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000122"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000123"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000124"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000125"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000126"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000127"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000128"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000129"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000130"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000131"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000132"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000133"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000134"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000135"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000136"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000137"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000138"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000139"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000140"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000141"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000142"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000143"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000144"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000145"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000146"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000147"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000148"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000149"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000150"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000151"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000152"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000153"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000154"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000155"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000156"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000157"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000158"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000159"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000160"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000161"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000162"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000163"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000164"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000165"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000166"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000167"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000168"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000169"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000170"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000171"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000172"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000173"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000174"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000175"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000176"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000177"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000178"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000179"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000180"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000181"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000182"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000183"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000184"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000185"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000186"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000187"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000188"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000189"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000190"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000191"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000192"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000193"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000194"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000195"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000196"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000197"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000198"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000199"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000200"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000201"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000202"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000203"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000204"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000205"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000206"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000207"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000208"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000209"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000210"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000211"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000212"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000213"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000214"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000215"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000216"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000217"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000218"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000219"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000220"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000221"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000222"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000223"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000224"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000225"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000226"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000227"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000228"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000229"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000230"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000231"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000232"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000233"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000234"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000235"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000236"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000237"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000238"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000239"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000240"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000241"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000242"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000243"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000244"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000245"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000246"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000247"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000248"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000249"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000250"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000251"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000252"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000253"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000254"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000255"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000256"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000257"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000258"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000259"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000260"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000261"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000262"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000263"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000264"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000265"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000266"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000267"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000268"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000269"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000270"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000271"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000272"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000273"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000274"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000275"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000276"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000277"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000278"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000279"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000280"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000281"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000282"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000283"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000284"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000285"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000286"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000287"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000288"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000289"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000290"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000291"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000292"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000293"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000294"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000295"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000296"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000297"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000298"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000299"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000300"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000301"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000302"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000303"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000304"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000305"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000306"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000307"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000308"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000309"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000310"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000311"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000312"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000313"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000314"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000315"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000316"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000317"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000318"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000319"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000320"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000321"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000322"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000323"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000324"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000325"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000326"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000327"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000328"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000329"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000330"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000331"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000332"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000333"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000334"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000335"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000336"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000337"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000338"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000339"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000340"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000341"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000342"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000343"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000344"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000345"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000346"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000347"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000348"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000349"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000350"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000351"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000352"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000353"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000354"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000355"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000356"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000357"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000358"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000359"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000360"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000361"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000362"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000363"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000364"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000365"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000366"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000367"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000368"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000369"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000370"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000371"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000372"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000373"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000374"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000375"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000376"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000377"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000378"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000379"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000380"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000381"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000382"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000383"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000384"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000385"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000386"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000387"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000388"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000389"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000390"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000391"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000392"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000393"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000394"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000395"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000396"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000397"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000398"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000399"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000400"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000401"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000402"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000403"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000404"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000405"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000406"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000407"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000408"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000409"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000410"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000411"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000412"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000413"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000414"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000415"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000416"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000417"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000418"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000419"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000420"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000421"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000422"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000423"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000424"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000425"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000426"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000427"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000428"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000429"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000430"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000431"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000432"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000433"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000434"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000435"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000436"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000437"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000438"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000439"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000440"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000441"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000442"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000443"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000444"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000445"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000446"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000447"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000448"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000449"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000450"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000451"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000452"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000453"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000454"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000455"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000456"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000457"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000458"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000459"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000460"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000461"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000462"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000463"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000464"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000465"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000466"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000467"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000468"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000469"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000470"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000471"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000472"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000473"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000474"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000475"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000476"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000477"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000478"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000479"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000480"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000481"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000482"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000483"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000484"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000485"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000486"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000487"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000488"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000489"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000490"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000491"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000492"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000493"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000494"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000495"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000496"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000497"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000498"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000499"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000500"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000501"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000502"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000503"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000504"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000505"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000506"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000507"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000508"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000509"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000510"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000511"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000512"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000513"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000514"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000515"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000516"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000517"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000518"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000519"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000520"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000521"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000522"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000523"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000524"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000525"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000526"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000527"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000528"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000529"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000530"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000531"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000532"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000533"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000534"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000535"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000536"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000537"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000538"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000539"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000540"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000541"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000542"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000543"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000544"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000545"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000546"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000547"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000548"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000549"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000550"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000551"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000552"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000553"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000554"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000555"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000556"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000557"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000558"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000559"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000560"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000561"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000562"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000563"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000564"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000565"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000566"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000567"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000568"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000569"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000570"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000571"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000572"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000573"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000574"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000575"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000576"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000577"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000578"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000579"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000580"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000581"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000582"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000583"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000584"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000585"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000586"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000587"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000588"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000589"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000590"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000591"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000592"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000593"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000594"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000595"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000596"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000597"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000598"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000599"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000600"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000601"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000602"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000603"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000604"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000605"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000606"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000607"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000608"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000609"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000610"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000611"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000612"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000613"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000614"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000615"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000616"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000617"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000618"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000619"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000620"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000621"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000622"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000623"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000624"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000625"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000626"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000627"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000628"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000629"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000630"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000631"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000632"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000633"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000634"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000635"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000636"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000637"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000638"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000639"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000640"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000641"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000642"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000643"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000644"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000645"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000646"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000647"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000648"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000649"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000650"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000651"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000652"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000653"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000654"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000655"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000656"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000657"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000658"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000659"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000660"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000661"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000662"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000663"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000664"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000665"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000666"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000667"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000668"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000669"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000670"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000671"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000672"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000673"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000674"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000675"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000676"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000677"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000678"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000679"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000680"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000681"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000682"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000683"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000684"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000685"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000686"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000687"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000688"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000689"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000690"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000691"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000692"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000693"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000694"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000695"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000696"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000697"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000698"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000699"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000700"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000701"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000702"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000703"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000704"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000705"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000706"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000707"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000708"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000709"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000710"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000711"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000712"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000713"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000714"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000715"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000716"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000717"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000718"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000719"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000720"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000721"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000722"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000723"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000724"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000725"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000726"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000727"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000728"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000729"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000730"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000731"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000732"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000733"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000734"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000735"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000736"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000737"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000738"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000739"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000740"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000741"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000742"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000743"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000744"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000745"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000746"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000747"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000748"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000749"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000750"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000751"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000752"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000753"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000754"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000755"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000756"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000757"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000758"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000759"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000760"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000761"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000762"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000763"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000764"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000765"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000766"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000767"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000768"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000769"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000770"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000771"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000772"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000773"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000774"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000775"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000776"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000777"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000778"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000779"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000780"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000781"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000782"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000783"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000784"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000785"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000786"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000787"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000788"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000789"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000790"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000791"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000792"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000793"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000794"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000795"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000796"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000797"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000798"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000799"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000800"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000801"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000802"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000803"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000804"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000805"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000806"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000807"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000808"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000809"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000810"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000811"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000812"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000813"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000814"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000815"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000816"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000817"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000818"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000819"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000820"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000821"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000822"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000823"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000824"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000825"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000826"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000827"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000828"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000829"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000830"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000831"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000832"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000833"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000834"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000835"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000836"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000837"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000838"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000839"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000840"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000841"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000842"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000843"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000844"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000845"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000846"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000847"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000848"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000849"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000850"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000851"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000852"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000853"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000854"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000855"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000856"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000857"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000858"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000859"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000860"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000861"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000862"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000863"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000864"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000865"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000866"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000867"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000868"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000869"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000870"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000871"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000872"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000873"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000874"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000875"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000876"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000877"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000878"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000879"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000880"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000881"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000882"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000883"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000884"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000885"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000886"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000887"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000888"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000889"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000890"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000891"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000892"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000893"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000894"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000895"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000896"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000897"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000898"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000899"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000900"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000901"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000902"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000903"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000904"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000905"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000906"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000907"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000908"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000909"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000910"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000911"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000912"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000913"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000914"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000915"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000916"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000917"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000918"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000919"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000920"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000921"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000922"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000923"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000924"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000925"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000926"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000927"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000928"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000929"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000930"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000931"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000932"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000933"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000934"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000935"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000936"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000937"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000938"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000939"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000940"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000941"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000942"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000943"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000944"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000945"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000946"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000947"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000948"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000949"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000950"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000951"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000952"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000953"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000954"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000955"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000956"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000957"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000958"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000959"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000960"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000961"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000962"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000963"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000964"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000965"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000966"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000967"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000968"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000969"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000970"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000971"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000972"));

            migrationBuilder.DeleteData(
                table: "Ilceler",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000973"));
        }
    }
}
