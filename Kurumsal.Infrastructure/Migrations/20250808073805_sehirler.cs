using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class sehirler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlkeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Ulkeler_UlkeId",
                        column: x => x.UlkeId,
                        principalTable: "Ulkeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilce_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "Ad", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "Durum", "IsDeleted", "Kod", "TelefonKodu", "UlkeId", "UpdatedAt", "UpdatedByUserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Adana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "01", "322", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Adıyaman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "02", "416", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Afyonkarahisar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "03", "272", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Ağrı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "04", "472", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Amasya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "05", "358", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Ankara", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "06", "312", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Antalya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "07", "242", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Artvin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "08", "466", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Aydın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "09", "256", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Balıkesir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "10", "266", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Bilecik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "11", "228", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Bingöl", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "12", "426", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Bitlis", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "13", "434", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Bolu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "14", "374", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Burdur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "15", "248", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Bursa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "16", "224", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Çanakkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "17", "286", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Çankırı", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "18", "376", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Çorum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "19", "364", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Denizli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "20", "258", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Diyarbakır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "21", "412", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Edirne", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "22", "284", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Elazığ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "23", "424", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Erzincan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "24", "446", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Erzurum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "25", "442", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Eskişehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "26", "222", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Gaziantep", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "27", "342", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "Giresun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "28", "454", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Gümüşhane", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "29", "456", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Hakkâri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "30", "438", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Hatay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "31", "326", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Isparta", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "32", "246", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000033"), "Mersin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "33", "324", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000034"), "İstanbul", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "34", "212;216", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000035"), "İzmir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "35", "232", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000036"), "Kars", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "36", "474", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000037"), "Kastamonu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "37", "366", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000038"), "Kayseri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "38", "352", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000039"), "Kırklareli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "39", "288", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000040"), "Kırşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "40", "386", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000041"), "Kocaeli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "41", "262", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000042"), "Konya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "42", "332", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000043"), "Kütahya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "43", "274", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000044"), "Malatya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "44", "422", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000045"), "Manisa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "45", "236", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000046"), "Kahramanmaraş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "46", "344", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000047"), "Mardin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "47", "482", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000048"), "Muğla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "48", "252", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000049"), "Muş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "49", "436", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000050"), "Nevşehir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "50", "384", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000051"), "Niğde", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "51", "388", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000052"), "Ordu", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "52", "452", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000053"), "Rize", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "53", "464", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000054"), "Sakarya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "54", "264", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000055"), "Samsun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "55", "362", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000056"), "Siirt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "56", "484", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000057"), "Sinop", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "57", "368", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000058"), "Sivas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "58", "346", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000059"), "Tekirdağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "59", "282", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000060"), "Tokat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "60", "356", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000061"), "Trabzon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "61", "462", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000062"), "Tunceli", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "62", "428", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000063"), "Şanlıurfa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "63", "414", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000064"), "Uşak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "64", "276", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000065"), "Van", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "65", "432", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000066"), "Yozgat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "66", "354", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000067"), "Zonguldak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "67", "372", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000068"), "Aksaray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "68", "382", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000069"), "Bayburt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "69", "458", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000070"), "Karaman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "70", "338", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000071"), "Kırıkkale", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "71", "318", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000072"), "Batman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "72", "488", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000073"), "Şırnak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "73", "486", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000074"), "Bartın", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "74", "378", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000075"), "Ardahan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "75", "478", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000076"), "Iğdır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "76", "476", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000077"), "Yalova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "77", "226", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000078"), "Karabük", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "78", "370", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000079"), "Kilis", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "79", "348", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000080"), "Osmaniye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "80", "328", new Guid("00000000-0000-0000-0000-000000000180"), null, null },
                    { new Guid("10000000-0000-0000-0000-000000000081"), "Düzce", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "81", "380", new Guid("00000000-0000-0000-0000-000000000180"), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_SehirId",
                table: "Ilce",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_UlkeId",
                table: "Sehirler",
                column: "UlkeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
