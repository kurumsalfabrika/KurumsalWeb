using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class rezervasyon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervasyon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdaId = table.Column<int>(type: "int", nullable: false),
                    GirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamGun = table.Column<int>(type: "int", nullable: false),
                    GunlukUcret = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ToplamTutar = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TCKimlikNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdemeKayitId = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KayitIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrediKartAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrediKartNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrediKartAy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrediKartYil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrediKartCvv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyon", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervasyon");
        }
    }
}
