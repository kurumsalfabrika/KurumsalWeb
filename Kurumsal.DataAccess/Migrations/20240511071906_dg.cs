using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdaKacKisilik",
                table: "Oda");

            migrationBuilder.DropColumn(
                name: "OdaOzellikleri",
                table: "Oda");

            migrationBuilder.AddColumn<int>(
                name: "MaxCocuk",
                table: "Oda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxYetiskin",
                table: "Oda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCocuk",
                table: "Oda");

            migrationBuilder.DropColumn(
                name: "MaxYetiskin",
                table: "Oda");

            migrationBuilder.AddColumn<string>(
                name: "OdaKacKisilik",
                table: "Oda",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdaOzellikleri",
                table: "Oda",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
