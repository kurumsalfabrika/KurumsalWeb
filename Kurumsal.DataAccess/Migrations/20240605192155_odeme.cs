using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class odeme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KrediKartYil",
                table: "Rezervasyon",
                newName: "TranType");

            migrationBuilder.RenameColumn(
                name: "KrediKartNumarasi",
                table: "Rezervasyon",
                newName: "StoreType");

            migrationBuilder.RenameColumn(
                name: "KrediKartCvv",
                table: "Rezervasyon",
                newName: "Rnd");

            migrationBuilder.RenameColumn(
                name: "KrediKartAy",
                table: "Rezervasyon",
                newName: "Pan");

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CallbackUrl",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
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
                name: "HashAlgorithm",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instalment",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OkUrl",
                table: "Rezervasyon",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "CallbackUrl",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Currency",
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
                name: "HashAlgorithm",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Instalment",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "Rezervasyon");

            migrationBuilder.DropColumn(
                name: "OkUrl",
                table: "Rezervasyon");

            migrationBuilder.RenameColumn(
                name: "TranType",
                table: "Rezervasyon",
                newName: "KrediKartYil");

            migrationBuilder.RenameColumn(
                name: "StoreType",
                table: "Rezervasyon",
                newName: "KrediKartNumarasi");

            migrationBuilder.RenameColumn(
                name: "Rnd",
                table: "Rezervasyon",
                newName: "KrediKartCvv");

            migrationBuilder.RenameColumn(
                name: "Pan",
                table: "Rezervasyon",
                newName: "KrediKartAy");
        }
    }
}
