using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class subesssad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube");

            migrationBuilder.AlterColumn<int>(
                name: "FotoGaleriId",
                table: "Sube",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube");

            migrationBuilder.AlterColumn<int>(
                name: "FotoGaleriId",
                table: "Sube",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
