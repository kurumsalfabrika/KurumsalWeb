using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sliderdosyalar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DorduncuSatir",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OneCikanGorsel1",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OneCikanGorsel2",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DorduncuSatir",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "OneCikanGorsel1",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "OneCikanGorsel2",
                table: "Slider");
        }
    }
}
