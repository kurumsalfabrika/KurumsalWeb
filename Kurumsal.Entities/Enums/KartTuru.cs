using System.ComponentModel;

namespace Kurumsal.Entities.Enums
{
    public enum KartTuru : byte
    {
        [Description("Cari Kartı")]
        Cari = 1,
        [Description("Cari Grup Kartı")]
        CariGrup = 2,
        [Description("Cari Tipi Kartı")]
        CariTipi = 3,
        [Description("Faaliyet Sektörü Kartı")]
        FaaliyetSektoru = 4,
        [Description("İl Kartı")]
        Il = 5,
        [Description("İlçe Kartı")]
        Ilce = 6,
        [Description("Temsilci Kartı")]
        Temsilci = 7,
        [Description("Filtre Kartı")]
        Filtre = 8,
        [Description("İptal Nedeni Kartı")]
        IptalNedeni = 10,
        [Description("Özel Kod Kartı")]
        OzelKod = 26,
        [Description("İrsaliye Kartı")]
        Irsaliye = 11,
        [Description("Kasa Kartı")]
        Kasa = 27,
        [Description("Banka Kartı")]
        Banka = 28,
        [Description("Banka Şube Kartı")]
        BankaSube = 29,
        [Description("Avukat Kartı")]
        Avukat = 30,
        [Description("Ödeme Türü Kartı")]
        OdemeTuru = 31,
        [Description("Banka Hesap Kartı")]
        BankaHesap = 32,
        [Description("İletişim Kartı")]
        Iletisim = 33,
        [Description("Firma Kartı")]
        Firma = 37,
        [Description("Firma Türü Kartı")]
        FirmaTuru = 38,
        [Description("Firma Dönem Kartı")]
        FirmaDonem = 39,
        [Description("Proje Durum Kartı")]
        ProjeDurum = 40,
        [Description("Proje Türü Kartı")]
        ProjeTuru = 41,
        [Description("Yapı Denetim Kartı")]
        YapiDenetim = 42,
        [Description("Elek Müh Kartı")]
        ElektrikMuhendisi = 43,
        [Description("Tetkik Kartı")]
        Tetkik = 45,
        [Description("Kişi Kartı")]
        Kisi = 46,
        [Description("Cari Tetkik Kartı")]
        CariTetkik = 47,
        [Description("Muavin Kartı")]
        Muavin = 48,
        [Description("Kablo Kesit Kartı")]
        KabloKesit = 49,
        [Description("Eş Zamanlılık Kartı")]
        Eszamanlilik = 50,
        [Description("Bıçaklı Sigorta Kartı")]
        BicakliSigorta = 51,
        [Description("Kullanici Parametre Kartı")]
        KullaniciParametre = 54,
        [Description("Okul Kartı")]
        Okul = 55,
        [Description("Tahakkuk Kartı")]
        Tahakkuk = 56,
        [Description("Solo Kartı")]
        Solo = 56,
        [Description("Makbuz Kartı")]
        Makbuz = 57,
        [Description("Kur Farkı")]
        KurFarki = 58,
        [Description("Belge Seçim Kartı")]
        BelgeSecim = 59,
        [Description("Şube Kartı")]
        Sube = 60,
        [Description("Belge Hareketleri Kartı")]
        BelgeHareketleri = 61,
        [Description("Rapor Kartı")]
        Rapor = 180,
        [Description("Rapor Tasarım Kartı")]
        RaporTasarim = 62,
        [Description("Öğrenci Kartı Raporu")]
        OgrenciKartiRaporu = 63,
        [Description("Stok Kartı")]
        Stok = 64,
        [Description("Stok Grup Kartı")]
        StokGrup = 65,
        [Description("Stok Alt Grup Kartı")]
        StokAltGrup = 66,
        [Description("Marka Kartı")]
        Marka = 67,
        [Description("Stok Birim Kartı")]
        StokBirim = 68,
        [Description("Kullanıcı Kartı")]
        Kullanici = 71,
        [Description("Fatura Kartı")]
        Fatura = 72,
        [Description("Banka Ödeme Planı Raporu")]
        BankaOdemePlaniRaporu = 73,
        [Description("MEB Kayıt Sözleşmesi Raporu")]
        MebKayitSozlesmesiRaporu = 74,
        [Description("İndirim Dilekçesi Raporu")]
        IndirimDilekcesiRaporu = 75,
        [Description("Kayıt Sözleşmesi Raporu")]
        KayitSozlesmesi = 76,
        [Description("Kredi Kartlı Ödeme Talimatı Raporu")]
        KrediKartiOdemeTalimati = 77,
        [Description("Tahsilat Makbuzu Raporu")]
        TahsilatMakbuzu = 78,
        [Description("Teslimat Makbuzu Raporu")]
        TeslimatMakbuzu = 79,
        [Description("Fatura Raporu")]
        FaturaRaporu = 80,
        [Description("Fatura Dönem İcmal Raporu")]
        FaturaDonemIcmalRaporu = 81,
        [Description("Fatura Öğrenci İcmal Raporu")]
        FaturaOgrenciIcmalRaporu = 82,
        [Description("Kurum Kartı")]
        Kurum = 83,
        [Description("Dönem Kartı")]
        Donem = 84,
        [Description("Rol Kartı")]
        Rol = 85,
        [Description("Yetki Kartı")]
        Yetki = 86,
        [Description("Emeklilik Parametre Kartı")]
        EmeklilikParametre = 91,
        [Description("Müşteri Kartı")]
        Musteri = 92,
        [Description("İş Kolu Kartı")]
        IsKolu = 93,
        [Description("Tehlike Sınıfı Kartı")]
        TehlikeSinifi = 94,
        [Description("İş Yeri Grup Kartı")]
        IsYeriGrubu = 95,
        [Description("ISG Görev Kartı")]
        ISGGorev = 96,
        [Description("Müşteri Yönetim Kartı")]
        MusteriYonetim = 97,
        [Description("Görev Detay Kartı")]
        GorevDetay = 98,
        [Description("Mimar Kartı")]
        Mimar = 99,
        [Description("Mimari Proje Kartı")]
        MimariProje = 100,
        [Description("Mahalle Kartı")]
        Mahalle = 101,
        [Description("Dosya Kartı")]
        Dosya = 102,
        [Description("Dosya Türü Kartı")]
        DosyaTurum = 103,
        [Description("Not Kartı")]
        Not = 104,
        [Description("Elektrik Kabul Kartı")]
        ElektrikKabul = 105,
        [Description("Makina Mühendisi Kartı")]
        MakinaMuhendisi = 106,
        [Description("İnşaat Mühendisi Kartı")]
        InsaatMuhendisi = 107,
        [Description("Harita Mühendisi Kartı")]
        HaritaMuhendisi = 108,
        [Description("Jeoloji Mühendisi Kartı")]
        JeolojiMuhendisi = 109,
        [Description("Jeofizik Mühendisi Kartı")]
        JeofizikMuhendisi = 110,
        [Description("Dış Yıldırımlık Kartı")]
        DisYildirimlik = 111,
        [Description("Cari Hareket Kartı")]
        CariHareket = 112,
        [Description("Şantiye Şefi Kartı")]
        SantiyeSefi = 113,
        [Description("Banka Hareket Kartı")]
        BankaHareket = 114,
        [Description("Topraklama Rapor Kartı")]
        TopraklamaRapor = 116,
        [Description("İş Durumu Kartı")]
        IsDurumu = 117,
        [Description("Şantiye Kartı")]
        Santiye = 118,
        [Description("Bağımsız Birim Kartı")]
        BagimsizBirim = 119,
        [Description("Araç Kartı")]
        Arac = 120,
        [Description("Şöför Kartı")]
        Sofor = 121,
        [Description("Lokasyon Kartı")]
        Lokasyon = 122,
        [Description("Renk Kod Kartı")]
        RenkKod = 123,
        [Description("Kargo Kartı")]
        Kargo = 124,
        [Description("Kargo Durum Kartı")]
        KargoDurum = 125,
        [Description("Döviz Kartı")]
        Doviz = 126,
        [Description("SMS Şablon Kartı")]
        SMSSablon = 127,
        [Description("Teklif Kartı")]
        Teklif = 128,
        [Description("Kargo Hareket Kartı")]
        KargoHareket = 129,
        [Description("Elektrik Proje Kartı")]
        ElektrikProje = 44,
        [Description("Elektrik Enerji Müsadesi Kartı")]
        EnerjiMusadesi = 130,
        [Description("Topraklama Ölçüm Noktası")]
        TopraklamaOlcumNoktasi = 131,
        [Description("Proje Kartı")]
        Proje = 132,
        [Description("Jenerator Muayene Kartı")]
        JeneratorMuayeneRapor = 133,
        [Description("İstenen Evrak Kartı")]
        IstenenEvrak = 134,
        [Description("Sigorta Tür Kartı")]
        SigortaTur = 135,
        [Description("Borç Alacak Kartı")]
        BorcAlacak = 136,
        [Description("Fatura Detay Kartı")]
        FaturaDetay = 137,
        [Description("Genel Parametre Kartı")]
        GenelParametre = 138,
        [Description("Sipariş Kartı")]
        Siparis = 139,
        [Description("Kasa Hareket Kartı")]
        KasaHareket = 140,
        [Description("Personel Kartı")]
        Personel = 141,
        [Description("Sürücü Kartı")]
        Surucu = 142,
        [Description("Yük Kartı")]
        Yuk = 143,
        [Description("Konteyner Kartı")]
        Konteyner = 144,
        [Description("Süreli Belge Kartı")]
        SureliBelge = 145,
        [Description("Masraf Kartı")]
        Masraf = 146,
        [Description("Avans Kartı")]
        Avans = 147,
        [Description("Masraf Detay Kartı")]
        MasrafDetay = 148,
        [Description("Yük Konteyner Kartı")]
        YukKonteyner = 149,
        [Description("Yük Eşya Kartı")]
        YukEsya = 150,
        [Description("Taşıma Kartı")]
        Tasima = 151,
        [Description("Gelir/Gider Kartı")]
        GelirGider = 152,
        [Description("Topraklama Kartı")]
        Topraklama = 153,
        [Description("Ödeme/Tahilat Kartı")]
        OdemeTahsilat = 154,
        [Description("Çek/Senet Kartı")]
        CekSenet = 155,
        [Description("Bağlantı Görüş Kartı")]
        BaglantiGorus = 156,
        [Description("Rekortmen Proje Kartı")]
        RekortmenProje = 157,
        [Description("Jeneratör Rapor Kartı")]
        JeneratorRapor = 158,
        [Description("Ölçüm Cihazı Bilgileri ve Belgeler Kartı")]
        OlcumCihaziBelgeler = 159,
        [Description("İç Tesisat Kontrol Kartı")]
        IcTesisatKontrol = 160,
        [Description("Toprak Özgül Direnci Ölçüm Rapor Kartı")]
        ToprakOzgulDirenciOlcumRaporu = 161,
        [Description("Topraklama Tesisatı Periyodik Kontrol Raporu Kartı")]
        TopraklamaTesisatiPeriyodikKontrolRaporu = 162,
        [Description("Doğalgaz Topraklama Raporu Kartı")]
        DogalGazTopraklamaRaporu = 163,
        [Description("Yükleme Cetveli Detay Kartı")]
        YuklemeCetveliDetay = 164,
        [Description("Tablo Yükleme Cetveli Detay Kartı")]
        TabloYuklemeCetveliDetay = 165,
        [Description("Tablo Yükleme Cetveli Kartı")]
        TabloYuklemeCetveli = 166,
        [Description("Yükleme Cetveli Kartı")]
        YuklemeCetveli = 167,
        [Description("Elektrik İç Tesisleri Denetim Kartı")]
        ElektrikIcTesisleriDenetim = 168,
        [Description("Teknik Servis Kartı")]
        TeknikServis = 169,
        [Description("Ölçüm Noktası Kartı")]
        OlcumNoktasi = 170,
        [Description("Kabul İşlemleri Kartı")]
        KabulIslemleri = 171,
        [Description("Daire Kartı")]
        Daireler = 172
    }
}
