using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class rezervasyondsfdaasa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Cvv2",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Ecom_Payment_Card_ExpDate_Month",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Ecom_Payment_Card_ExpDate_Year",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "FailUrl",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "KrediKartAdSoyad",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "OkUrl",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Pan",
                table: "Rezervasyon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cvv2",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ecom_Payment_Card_ExpDate_Month",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ecom_Payment_Card_ExpDate_Year",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FailUrl",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KrediKartAdSoyad",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OkUrl",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pan",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
