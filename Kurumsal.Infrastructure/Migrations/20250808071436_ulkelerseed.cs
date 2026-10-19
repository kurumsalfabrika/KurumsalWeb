using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kurumsal.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ulkelerseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ulkeler",
                columns: new[] { "Id", "Ad", "CreatedAt", "CreatedByUserId", "DeletedAt", "DeletedByUserId", "Durum", "IsDeleted", "Kod", "TelefonKodu", "UpdatedAt", "UpdatedByUserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Afganistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AF", "+93", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Arnavutluk", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AL", "+355", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Cezayir", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DZ", "+213", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Amerikan Samoası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AS", "+1-684", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Andorra", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AD", "+376", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Angola", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AO", "+244", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Anguilla", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AI", "+1-264", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Antarktika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AQ", "+672", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Antigua ve Barbuda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AG", "+1-268", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Arjantin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AR", "+54", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Ermenistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AM", "+374", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Aruba", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AW", "+297", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Avustralya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AU", "+61", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Avusturya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AT", "+43", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Azerbaycan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AZ", "+994", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Bahamalar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BS", "+1-242", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Bahreyn", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BH", "+973", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Bangladeş", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BD", "+880", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Barbados", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BB", "+1-246", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Belarus", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BY", "+375", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Belçika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BE", "+32", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Belize", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BZ", "+501", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Benin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BJ", "+229", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Bermuda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BM", "+1-441", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Butan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BT", "+975", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Bolivya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BO", "+591", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Bosna-Hersek", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BA", "+387", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Botsvana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BW", "+267", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "Brezilya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BR", "+55", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "Brunei", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BN", "+673", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000031"), "Bulgaristan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BG", "+359", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000032"), "Burkina Faso", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BF", "+226", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000033"), "Burundi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "BI", "+257", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000034"), "Kamboçya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KH", "+855", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000035"), "Kamerun", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CM", "+237", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000036"), "Kanada", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CA", "+1", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000037"), "Yeşil Burun Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CV", "+238", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000038"), "Cayman Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KY", "+1-345", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000039"), "Orta Afrika Cumhuriyeti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CF", "+236", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000040"), "Çad", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "TD", "+235", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000041"), "Şili", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CL", "+56", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000042"), "Çin", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CN", "+86", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000043"), "Kolombiya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CO", "+57", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000044"), "Komorlar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KM", "+269", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000045"), "Kongo - Brazzaville", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CG", "+242", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000046"), "Kongo - Kinşasa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CD", "+243", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000047"), "Cook Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CK", "+682", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000048"), "Kosta Rika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CR", "+506", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000049"), "Hırvatistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "HR", "+385", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000050"), "Küba", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CU", "+53", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000051"), "Curaçao", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CW", "+599", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000052"), "Güney Kıbrıs Rum Kesmi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CY", "+357", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000053"), "Çekya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CZ", "+420", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000054"), "Danimarka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DK", "+45", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000055"), "Cibuti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DJ", "+253", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000056"), "Dominika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DM", "+1-767", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000057"), "Dominik Cumhuriyeti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DO", "+1-809", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000058"), "Ekvador", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "EC", "+593", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000059"), "Mısır", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "EG", "+20", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000060"), "El Salvador", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SV", "+503", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000061"), "Ekvator Ginesi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GQ", "+240", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000062"), "Eritre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ER", "+291", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000063"), "Estonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "EE", "+372", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000064"), "Esvatini", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SZ", "+268", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000065"), "Etiyopya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ET", "+251", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000066"), "Falkland Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FK", "+500", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000067"), "Faroe Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FO", "+298", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000068"), "Fiji", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FJ", "+679", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000069"), "Finlandiya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FI", "+358", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000070"), "Fransa", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FR", "+33", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000071"), "Fransız Guyanası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GF", "+594", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000072"), "Fransız Polinezyası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PF", "+689", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000073"), "Gabon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GA", "+241", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000074"), "Gambiya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GM", "+220", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000075"), "Gürcistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GE", "+995", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000076"), "Almanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "DE", "+49", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000077"), "Gana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GH", "+233", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000078"), "Cebelitarık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GI", "+350", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000079"), "Yunanistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GR", "+30", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000080"), "Grönland", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GL", "+299", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000081"), "Grenada", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GD", "+1-473", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000082"), "Guadeloupe", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GP", "+590", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000083"), "Guam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GU", "+1-671", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000084"), "Guatemala", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GT", "+502", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000085"), "Guernsey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GG", "+44-1481", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000086"), "Gine", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GN", "+224", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000087"), "Gine-Bissau", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GW", "+245", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000088"), "Guyana", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GY", "+592", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000089"), "Haiti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "HT", "+509", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000090"), "Vatikan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "VA", "+379", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000091"), "Honduras", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "HN", "+504", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000092"), "Hong Kong", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "HK", "+852", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000093"), "Macaristan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "HU", "+36", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000094"), "İzlanda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IS", "+354", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000095"), "Hindistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IN", "+91", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000096"), "Endonezya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ID", "+62", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000097"), "İran", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IR", "+98", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000098"), "Irak", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IQ", "+964", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000099"), "İrlanda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IE", "+353", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000100"), "Man Adası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IM", "+44-1624", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000101"), "İsrail", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IL", "+972", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000102"), "İtalya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "IT", "+39", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000103"), "Jamaika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "JM", "+1-876", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000104"), "Japonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "JP", "+81", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000105"), "Jersey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "JE", "+44-1534", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000106"), "Ürdün", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "JO", "+962", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000107"), "Kazakistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KZ", "+7", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000108"), "Kenya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KE", "+254", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000109"), "Kiribati", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KI", "+686", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Kuzey Kore", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KP", "+850", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000111"), "Güney Kore", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KR", "+82", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000112"), "Kuveyt", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KW", "+965", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000113"), "Kırgızistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KG", "+996", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000114"), "Laos", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LA", "+856", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000115"), "Letonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LV", "+371", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000116"), "Lübnan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LB", "+961", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000117"), "Lesotho", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LS", "+266", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000118"), "Liberya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LR", "+231", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000119"), "Libya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LY", "+218", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000120"), "Lihtenştayn", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LI", "+423", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000121"), "Litvanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LT", "+370", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000122"), "Lüksemburg", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LU", "+352", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000123"), "Makao", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MO", "+853", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000124"), "Madagaskar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MG", "+261", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000125"), "Malavi", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MW", "+265", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000126"), "Malezya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MY", "+60", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000127"), "Maldivler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MV", "+960", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000128"), "Mali", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ML", "+223", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000129"), "Malta", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MT", "+356", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000130"), "Marshall Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MH", "+692", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000131"), "Martinik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MQ", "+596", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000132"), "Moritanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MR", "+222", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000133"), "Mauritius", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MU", "+230", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000134"), "Mayotte", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "YT", "+262", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000135"), "Meksika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MX", "+52", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000136"), "Mikronezya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "FM", "+691", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000137"), "Moldova", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MD", "+373", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000138"), "Monako", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MC", "+377", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000139"), "Moğolistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MN", "+976", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000140"), "Karadağ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ME", "+382", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000141"), "Montserrat", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MS", "+1-664", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000142"), "Fas", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MA", "+212", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000143"), "Mozambik", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MZ", "+258", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000144"), "Myanmar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MM", "+95", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000145"), "Namibya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NA", "+264", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000146"), "Nauru", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NR", "+674", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000147"), "Nepal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NP", "+977", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000148"), "Hollanda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NL", "+31", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000149"), "Yeni Kaledonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NC", "+687", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000150"), "Yeni Zelanda", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NZ", "+64", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000151"), "Nikaragua", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NI", "+505", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000152"), "Nijer", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NE", "+227", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000153"), "Nijerya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NG", "+234", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000154"), "Niue", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NU", "+683", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000155"), "Norfolk Adası", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NF", "+672", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000156"), "Kuzey Mariana Adaları", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "MP", "+1-670", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000157"), "Norveç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "NO", "+47", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000158"), "Umman", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "OM", "+968", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000159"), "Pakistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PK", "+92", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000160"), "Panama", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PA", "+507", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000161"), "Papua Yeni Gine", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PG", "+675", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000162"), "Paraguay", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PY", "+595", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000163"), "Peru", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PE", "+51", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000164"), "Filipinler", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PH", "+63", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000165"), "Polonya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PL", "+48", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000166"), "Portekiz", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PT", "+351", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000167"), "Katar", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "QA", "+974", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000168"), "Romanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "RO", "+40", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000169"), "Rusya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "RU", "+7", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000170"), "Suudi Arabistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SA", "+966", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000171"), "Sırbistan", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "RS", "+381", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000172"), "Singapur", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SG", "+65", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000173"), "Güney Afrika", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ZA", "+27", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000174"), "İspanya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ES", "+34", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000175"), "Sri Lanka", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "LK", "+94", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000176"), "İsveç", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SE", "+46", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000177"), "İsviçre", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "CH", "+41", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000178"), "Suriye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "SY", "+963", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000179"), "Tayland", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "TH", "+66", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000180"), "Türkiye", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "TR", "+90", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000181"), "Ukrayna", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "UA", "+380", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000182"), "Birleşik Arap Emirlikleri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "AE", "+971", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000183"), "Birleşik Krallık", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "GB", "+44", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000184"), "Amerika Birleşik Devletleri", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "US", "+1", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000185"), "Vietnam", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "VN", "+84", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000186"), "Yemen", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "YE", "+967", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000187"), "Zambiya", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ZM", "+260", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000188"), "Zimbabve", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "ZW", "+263", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000189"), "Kuzey Kıbrıs Türk Cumhuriyeti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "KKTC", "+90 392", null, null },
                    { new Guid("00000000-0000-0000-0000-000000000190"), "Filistin Devleti", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, true, false, "PS", "+970", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000115"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000116"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000117"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000118"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000119"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000120"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000121"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000122"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000123"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000124"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000125"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000126"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000127"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000128"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000129"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000130"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000131"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000132"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000133"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000134"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000135"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000136"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000137"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000138"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000139"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000140"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000141"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000142"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000143"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000144"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000145"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000146"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000147"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000148"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000149"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000150"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000151"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000152"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000153"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000154"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000155"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000156"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000157"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000158"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000159"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000160"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000161"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000162"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000163"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000164"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000165"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000166"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000167"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000168"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000169"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000170"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000171"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000172"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000173"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000174"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000175"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000176"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000177"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000178"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000179"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000180"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000181"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000182"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000183"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000184"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000185"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000186"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000187"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000188"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000189"));

            migrationBuilder.DeleteData(
                table: "Ulkeler",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000190"));
        }
    }
}
