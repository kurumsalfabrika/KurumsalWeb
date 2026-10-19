using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fotogaleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_FotoGaleriId",
                table: "Fotograf",
                column: "FotoGaleriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf",
                column: "FotoGaleriId",
                principalTable: "FotoGaleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fotograf_FotoGaleri_FotoGaleriId",
                table: "Fotograf");

            migrationBuilder.DropIndex(
                name: "IX_Fotograf_FotoGaleriId",
                table: "Fotograf");
        }
    }
}
