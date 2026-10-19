using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class subess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FotoGaleriId",
                table: "Sube",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sube_FotoGaleriId",
                table: "Sube",
                column: "FotoGaleriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sube_FotoGaleri_FotoGaleriId",
                table: "Sube");

            migrationBuilder.DropIndex(
                name: "IX_Sube_FotoGaleriId",
                table: "Sube");

            migrationBuilder.DropColumn(
                name: "FotoGaleriId",
                table: "Sube");
        }
    }
}
