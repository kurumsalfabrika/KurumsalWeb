using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kurumsal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcilirMesaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirKereGoster = table.Column<bool>(type: "bit", nullable: false),
                    ZamanAyarli = table.Column<bool>(type: "bit", nullable: false),
                    BaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YeniSekmedeAcilsin = table.Column<bool>(type: "bit", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcilirMesaj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatsappKod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleAnalyticsKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebmasterToolsDogrumaKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimHaritaEmbedKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanliDestekKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleRcapthaKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankaHesap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    HesapAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubeKoduSubeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HesapNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankaLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankaHesap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Belge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Dosya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnaSayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ekip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorevi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilGorseli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetayGoster = table.Column<bool>(type: "bit", nullable: false),
                    KisaOzgecmis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FotoGaleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    GaleriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotoGaleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fotograf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    FotografAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoGaleriId = table.Column<int>(type: "int", nullable: false),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ftp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FtpURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DosyaAdresOnEki = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ftp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenelAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailHeaderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favicon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenelRenk1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenelRenk2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenelRenk3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParaBirimi = table.Column<int>(type: "int", nullable: true),
                    YonetimLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopyrightMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenelAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HaberKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaberKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hizmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IletisimAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    FirmaUnvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiparisEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varsayilan = table.Column<bool>(type: "bit", nullable: false),
                    XKoordinat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YKoordinat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Katalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatalogKategoriId = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosya = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katalog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KatalogKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KatalogKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SMTPServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMTPPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSL = table.Column<bool>(type: "bit", nullable: false),
                    SMTPEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMTPEpostaSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajinGelecegiEposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaMenuId = table.Column<int>(type: "int", nullable: false),
                    MenuYeriId = table.Column<int>(type: "int", nullable: false),
                    MenuSira = table.Column<int>(type: "int", nullable: false),
                    MenuAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtomatikListelemeId = table.Column<int>(type: "int", nullable: false),
                    OtomatikListelemeLimiti = table.Column<int>(type: "int", nullable: false),
                    MenuIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BagliSayfaId = table.Column<int>(type: "int", nullable: false),
                    BaglantiAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YeniPenceredeAc = table.Column<bool>(type: "bit", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    GonderenIpAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OkunmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesaj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DovizId = table.Column<int>(type: "int", nullable: false),
                    PeriyodId = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    SatinAlLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ozellikler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotoGaleriId = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGozuksun = table.Column<bool>(type: "bit", nullable: false),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjeKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    DetaySayfasiGoster = table.Column<bool>(type: "bit", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rehber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sayfa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaglantiSayfasiId = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGozuksun = table.Column<bool>(type: "bit", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayfa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HeaderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderLogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderLogoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolderLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolderLogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolderLogoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterLogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterLogoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SliderBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YeniSekmedeAc = table.Column<bool>(type: "bit", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButonYazisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SMSAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSifresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiSecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSL = table.Column<bool>(type: "bit", nullable: false),
                    MesajinGelecegiNumara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyaAdres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ikon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sira = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YeniSekmedeAcilsin = table.Column<bool>(type: "bit", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyaAdres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyaAyar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyaAyar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSSKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSSKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sube",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SubeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sube", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UstKategori = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunKategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGaleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    GaleriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGaleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    HaberKategoriId = table.Column<int>(type: "int", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    AnaSayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haber_HaberKategori_HaberKategoriId",
                        column: x => x.HaberKategoriId,
                        principalTable: "HaberKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "SSS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SSSKategoriId = table.Column<int>(type: "int", nullable: true),
                    SoruAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSS_SSSKategori_SSSKategoriId",
                        column: x => x.SSSKategoriId,
                        principalTable: "SSSKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IndirimliFiyat = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    StokDurumId = table.Column<int>(type: "int", nullable: false),
                    UrunKategoriId = table.Column<int>(type: "int", nullable: true),
                    OneCikanGorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FotografGaleriId = table.Column<int>(type: "int", nullable: false),
                    TeknikDokuman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KatalogId = table.Column<int>(type: "int", nullable: false),
                    Katalog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    YeniUrun = table.Column<bool>(type: "bit", nullable: false),
                    AnasayfadaGoster = table.Column<bool>(type: "bit", nullable: false),
                    SpotMetin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ekleme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SEOAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOKelimeler = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urun_UrunKategori_UrunKategoriId",
                        column: x => x.UrunKategoriId,
                        principalTable: "UrunKategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Haber_HaberKategoriId",
                table: "Haber",
                column: "HaberKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_SSS_SSSKategoriId",
                table: "SSS",
                column: "SSSKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_UrunKategoriId",
                table: "Urun",
                column: "UrunKategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcilirMesaj");

            migrationBuilder.DropTable(
                name: "ApiAyar");

            migrationBuilder.DropTable(
                name: "BankaHesap");

            migrationBuilder.DropTable(
                name: "Belge");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Ekip");

            migrationBuilder.DropTable(
                name: "FotoGaleri");

            migrationBuilder.DropTable(
                name: "Fotograf");

            migrationBuilder.DropTable(
                name: "Ftp");

            migrationBuilder.DropTable(
                name: "GenelAyar");

            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "Hizmet");

            migrationBuilder.DropTable(
                name: "IletisimAyar");

            migrationBuilder.DropTable(
                name: "Katalog");

            migrationBuilder.DropTable(
                name: "KatalogKategori");

            migrationBuilder.DropTable(
                name: "MailAyar");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Mesaj");

            migrationBuilder.DropTable(
                name: "Paket");

            migrationBuilder.DropTable(
                name: "Proje");

            migrationBuilder.DropTable(
                name: "ProjeKategori");

            migrationBuilder.DropTable(
                name: "Referans");

            migrationBuilder.DropTable(
                name: "Rehber");

            migrationBuilder.DropTable(
                name: "Sayfa");

            migrationBuilder.DropTable(
                name: "SiteAyar");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "SMSAyar");

            migrationBuilder.DropTable(
                name: "SosyalMedyaAdres");

            migrationBuilder.DropTable(
                name: "SosyalMedyaAyar");

            migrationBuilder.DropTable(
                name: "SSS");

            migrationBuilder.DropTable(
                name: "Sube");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "VideoGaleri");

            migrationBuilder.DropTable(
                name: "HaberKategori");

            migrationBuilder.DropTable(
                name: "SSSKategori");

            migrationBuilder.DropTable(
                name: "UrunKategori");
        }
    }
}
