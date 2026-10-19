using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class hizmet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HizmetAdi",
                table: "Hizmet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HizmetKisaAciklama",
                table: "Hizmet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icerik",
                table: "Hizmet",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HizmetAdi",
                table: "Hizmet");

            migrationBuilder.DropColumn(
                name: "HizmetKisaAciklama",
                table: "Hizmet");

            migrationBuilder.DropColumn(
                name: "Icerik",
                table: "Hizmet");
        }
    }
}
