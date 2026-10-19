using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tenantdovizaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<Guid>(
                name: "TenantId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Departman",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IlceId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IseBaslamaTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IstenAyrilmaTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostaKodu",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilFotoUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SehirId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SicilNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UlkeId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unvan",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "AspNetRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers",
                column: "TenantId",
                principalTable: "Tenantler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Departman",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Iban",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IseBaslamaTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IstenAyrilmaTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostaKodu",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilFotoUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SehirId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SicilNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UlkeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Unvan",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<Guid>(
                name: "TenantId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tenantler_TenantId",
                table: "AspNetUsers",
                column: "TenantId",
                principalTable: "Tenantler",
                principalColumn: "Id");
        }
    }
}
