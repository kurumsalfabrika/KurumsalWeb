using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sektor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sektorler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sektorler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sektorler",
                columns: new[] { "Id", "Aciklama", "Ad", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "Durum", "IsDeleted", "Kod", "UpdatedAt", "UpdatedByUserId" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), null, "SMMM Hizmetleri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK001", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), null, "Muhasebe / Finans", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK002", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), null, "Tarım / Ziraat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK003", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), null, "Apartman / Site Yönetimi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK004", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000005"), null, "Mimarlık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK005", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000006"), null, "Otomotiv", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK006", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000007"), null, "Reklam / Tasarım / Medya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK007", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000008"), null, "Eğitim / Danışmanlık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK008", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000009"), null, "Enerji", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK009", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000010"), null, "E-Ticaret", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK010", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000011"), null, "Gıda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK011", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000012"), null, "Sağlık Hizmetleri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK012", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000013"), null, "Sigorta / Ekspertiz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK013", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000014"), null, "Hukuk Hizmetleri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK014", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000015"), null, "Lojistik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK015", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000016"), null, "Basın / Yayın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK016", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000017"), null, "Mikro İşletme / Esnaf", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK017", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000018"), null, "Üretim", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK018", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000019"), null, "Halkla İlişkiler & Organizasyon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK019", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000020"), null, "İnşaat / Yapı / Gayrimenkul", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK020", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000021"), null, "Perakende", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK021", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000022"), null, "Yazılım / Teknoloji", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK022", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000023"), null, "Telekomünikasyon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK023", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000024"), null, "Tekstil", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK024", null, null },
                    { new Guid("20000000-0000-0000-0000-000000000025"), null, "Turizm", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SEK025", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sektorler");
        }
    }
}
