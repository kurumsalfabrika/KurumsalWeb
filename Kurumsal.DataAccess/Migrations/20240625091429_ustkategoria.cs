using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ustkategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UstKategori",
                table: "UrunKategori");

            migrationBuilder.AddColumn<int>(
                name: "UstKategoriId",
                table: "UrunKategori",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UrunKategori_UstKategoriId",
                table: "UrunKategori",
                column: "UstKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_UrunKategori_UrunKategori_UstKategoriId",
                table: "UrunKategori",
                column: "UstKategoriId",
                principalTable: "UrunKategori",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrunKategori_UrunKategori_UstKategoriId",
                table: "UrunKategori");

            migrationBuilder.DropIndex(
                name: "IX_UrunKategori_UstKategoriId",
                table: "UrunKategori");

            migrationBuilder.DropColumn(
                name: "UstKategoriId",
                table: "UrunKategori");

            migrationBuilder.AddColumn<int>(
                name: "UstKategori",
                table: "UrunKategori",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
