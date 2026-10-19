using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OdaKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    OdaKategoriId = table.Column<int>(type: "int", nullable: true),
                    OdaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoGaleriId = table.Column<int>(type: "int", nullable: true),
                    OdaKacKisilik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdaOzellikleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdaGenislik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YatakSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GunlukUcret = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GunlukUcret1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GunlukUcret2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GunlukUcret3 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oda_FotoGaleri_FotoGaleriId",
                        column: x => x.FotoGaleriId,
                        principalTable: "FotoGaleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Oda_OdaKategori_OdaKategoriId",
                        column: x => x.OdaKategoriId,
                        principalTable: "OdaKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oda_FotoGaleriId",
                table: "Oda",
                column: "FotoGaleriId");

            migrationBuilder.CreateIndex(
                name: "IX_Oda_OdaKategoriId",
                table: "Oda",
                column: "OdaKategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oda");

            migrationBuilder.DropTable(
                name: "OdaKategori");
        }
    }
}
