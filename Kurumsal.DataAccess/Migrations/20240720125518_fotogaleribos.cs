using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fotogaleribos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf");

            migrationBuilder.AlterColumn<int>(
                name: "FotoGaleriId",
                table: "Fotograf",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf");

            migrationBuilder.AlterColumn<int>(
                name: "FotoGaleriId",
                table: "Fotograf",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
