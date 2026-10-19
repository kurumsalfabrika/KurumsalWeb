using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class insaatproje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsaatProje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    ProjeDurumu = table.Column<byte>(type: "tinyint", nullable: false),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjeAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisGorselId = table.Column<int>(type: "int", nullable: true),
                    IcGorselId = table.Column<int>(type: "int", nullable: true),
                    KrokiGorselId = table.Column<int>(type: "int", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnaSayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsaatProje", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsaatProje");
        }
    }
}
