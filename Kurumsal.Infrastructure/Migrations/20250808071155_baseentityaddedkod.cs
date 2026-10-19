using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class baseentityaddedkod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kod",
                table: "Ulkeler",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kod",
                table: "Ulkeler");
        }
    }
}
