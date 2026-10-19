namespace Kurumsal.WebUI.Models
{
    public class OdemeViewModel
    {
        public string Clientid { get; set; }
        public decimal amount { get; set; } = 9.95m;
        public string Oid { get; set; }
        public string OkUrl { get; set; }
        public string FailUrl { get; set; }
        public string Islemtipi { get; set; }
        public string Taksit { get; set; }
        public string Rnd { get; set; }
        public string Hash { get; set; }
        public string Storetype { get; set; } = "3d_pay_hosting";
        public int Refreshtime { get; set; } = 10;
        public string Lang { get; set; } = "tr";
        public string Firmaadi { get; set; } = "Kurumsal Fabrika Reklam Yazılım San. ve Tic. Ltg. Şti.";
        public string Fismi { get; set; } = "is";
        public string FaturaFirma { get; set; } = "AG Plan Proje Müh San Tic. Ltd. Şti.";
        public string Fadres { get; set; } = "Hunat Mah. Yenisu Sok.";
        public string Fadres2 { get; set; } = "-";
        public string Fil { get; set; } = "Kayseri";
        public string Filce { get; set; } = "Kocasinan";
        public string Fpostakodu { get; set; } = "38020";
        public string Tel { get; set; } = "0.352 222 6 111";
        public string Fulkekod { get; set; } = "tr";
        public string NakliyeFirma { get; set; } = "-";
        public string Tismi { get; set; } = "-";
        public string Tadres { get; set; } = "-";
        public string Tadres2 { get; set; } = "-";
        public string Til { get; set; } = "-";
        public string Tilce { get; set; } = "-";
        public string Tpostakodu { get; set; } = "-";
        public string Tulkekod { get; set; } = "tr";
        public string Itemnumber1 { get; set; } = "a5";
        public string Productcode1 { get; set; } = "a5";
        public decimal Qty1 { get; set; } = 1;
        public string Desc1 { get; set; } = "Oda Kiralama";
        public string Id1 { get; set; } = "a5";
        public decimal Price1 { get; set; } = 6.25m;
        public decimal Total1 { get; set; } = 7.50m;
        public string Storekey { get; set; } 
        public string Hashstr { get; set; } 

    }
}
