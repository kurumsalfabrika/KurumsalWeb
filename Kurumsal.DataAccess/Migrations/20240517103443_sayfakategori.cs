using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sayfakategori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BaglantiSayfasiId",
                table: "Sayfa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SayfaKategoriId",
                table: "Sayfa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpotMetin",
                table: "Sayfa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SayfaKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UstKategori = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SayfaKategori", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sayfa_SayfaKategoriId",
                table: "Sayfa",
                column: "SayfaKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sayfa_SayfaKategori_SayfaKategoriId",
                table: "Sayfa",
                column: "SayfaKategoriId",
                principalTable: "SayfaKategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sayfa_SayfaKategori_SayfaKategoriId",
                table: "Sayfa");

            migrationBuilder.DropTable(
                name: "SayfaKategori");

            migrationBuilder.DropIndex(
                name: "IX_Sayfa_SayfaKategoriId",
                table: "Sayfa");

            migrationBuilder.DropColumn(
                name: "SayfaKategoriId",
                table: "Sayfa");

            migrationBuilder.DropColumn(
                name: "SpotMetin",
                table: "Sayfa");

            migrationBuilder.AlterColumn<int>(
                name: "BaglantiSayfasiId",
                table: "Sayfa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
