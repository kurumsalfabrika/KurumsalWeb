using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tenantdoviz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dovizler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sembol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SatisKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProgramKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Dovizler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tenantler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaUnvani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SahisSirketiMi = table.Column<bool>(type: "bit", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DovizId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DovizId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSitesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlkeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SehirId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IlceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FaturaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SicilNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisansBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LisansBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LisansTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisansAktifMi = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Tenantler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tenantler_Dovizler_DovizId1",
                        column: x => x.DovizId1,
                        principalTable: "Dovizler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tenantler_Ilceler_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilceler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tenantler_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tenantler_Ulkeler_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkeler",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Dovizler",
                columns: new[] { "Id", "Ad", "AktifMi", "AlisKuru", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "Durum", "IsDeleted", "Kod", "ProgramKuru", "SatisKuru", "Sembol", "TenantId", "Ulke", "UpdatedAt", "UpdatedByUserId" },
                values: new object[] { new Guid("30000000-0000-0000-0000-000000000001"), "Türk Lirası", true, 1.0m, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "TRY", 1.0m, 1.0m, "₺", new Guid("00000000-0000-0000-0000-000000000101"), "Türkiye", null, null });

            migrationBuilder.InsertData(
                table: "Tenantler",
                columns: new[] { "Id", "Ad", "BankaAdi", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "DovizId", "DovizId1", "Durum", "Eposta", "Faks", "FaturaAdresi", "FaturaUnvani", "Gsm", "IBAN", "IlceId", "IsDeleted", "Kod", "LisansAktifMi", "LisansBaslangicTarihi", "LisansBitisTarihi", "LisansTuru", "LogoUrl", "MersisNo", "SahisSirketiMi", "SehirId", "SicilNo", "SirketAdi", "Soyad", "TCKimlikNo", "Telefon", "UlkeId", "UpdatedAt", "UpdatedByUserId", "VergiDairesi", "VergiNo", "WebSitesi" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000101"), null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, true, null, null, null, "System Tenant", null, null, null, false, "TEN001", true, null, null, null, null, null, false, null, null, "System Tenant", null, null, null, null, null, null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TenantId",
                table: "AspNetUsers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenantler_DovizId1",
                table: "Tenantler",
                column: "DovizId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tenantler_IlceId",
                table: "Tenantler",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenantler_SehirId",
                table: "Tenantler",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenantler_UlkeId",
                table: "Tenantler",
                column: "UlkeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers",
                column: "TenantId",
                principalTable: "Tenantler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tenantler");

            migrationBuilder.DropTable(
                name: "Dovizler");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TenantId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AspNetUsers");
        }
    }
}
