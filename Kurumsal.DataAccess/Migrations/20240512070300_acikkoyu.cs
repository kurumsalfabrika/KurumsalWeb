using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class acikkoyu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HeaderLogo",
                table: "SiteAyar",
                newName: "HeaderLogoKoyuRenk");

            migrationBuilder.AddColumn<string>(
                name: "HeaderLogoAcikRenk",
                table: "SiteAyar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeaderLogoAcikRenk",
                table: "SiteAyar");

            migrationBuilder.RenameColumn(
                name: "HeaderLogoKoyuRenk",
                table: "SiteAyar",
                newName: "HeaderLogo");
        }
    }
}
