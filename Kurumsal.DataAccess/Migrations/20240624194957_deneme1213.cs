using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class deneme1213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaSira = table.Column<int>(type: "int", nullable: false),
                    MarkaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marka");
        }
    }
}
