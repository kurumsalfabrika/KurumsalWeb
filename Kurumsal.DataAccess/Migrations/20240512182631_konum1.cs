using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class konum1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KisaHakkindaYazisi",
                table: "SiteAyar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteAdi",
                table: "SiteAyar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KisaHakkindaYazisi",
                table: "SiteAyar");

            migrationBuilder.DropColumn(
                name: "SiteAdi",
                table: "SiteAyar");
        }
    }
}
