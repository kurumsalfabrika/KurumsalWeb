using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cssalani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterCSSAlani",
                table: "SiteAyar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeaderCSSAlani",
                table: "SiteAyar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterCSSAlani",
                table: "SiteAyar");

            migrationBuilder.DropColumn(
                name: "HeaderCSSAlani",
                table: "SiteAyar");
        }
    }
}
