using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class gunlukucret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GunlukUcretDovizAdi",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GunlukUcretDovizKodu",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GunlukUcretDovizAdi",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "GunlukUcretDovizKodu",
                table: "Rezervasyon");
        }
    }
}
