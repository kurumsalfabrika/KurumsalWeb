namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class PaymentModel
    {
        public RezervasyonViewModel RezervasyonViewModel { get; set; }
        public string ClientId { get; set; }
        public string Amount { get; set; }
        public string Oid { get; set; }
        public string OkUrl { get; set; }
        public string FailUrl { get; set; }
        public string Rnd { get; set; }
        public string Taksit { get; set; } = "";
        public string IslemTipi { get; set; } = "Auth";
        public string StoreKey { get; set; }
        public string Hash { get; set; }
        public string StoreType { get; set; } = "3d_pay";
        public int RefreshTime { get; set; } = 10;
        public string Lang { get; set; } = "tr";
        public string Currency { get; set; } = "949";
        public string FirmaAdi { get; set; }
        public string Fismi { get; set; }
        public string FaturaFirma { get; set; }
        public string Fadres { get; set; }
        public string Fadres2 { get; set; }
        public string Fil { get; set; }
        public string Filce { get; set; }
        public string Fpostakodu { get; set; }
        public string Tel { get; set; }
        public string Fulkekod { get; set; }
        public string NakliyeFirma { get; set; }
        public string Tismi { get; set; }
        public string Tadres { get; set; }
        public string Tadres2 { get; set; }
        public string Til { get; set; }
        public string Tilce { get; set; }
        public string Tpostakodu { get; set; }
        public string Tulkekod { get; set; }
        public string ItemNumber1 { get; set; }
        public string ProductCode1 { get; set; }
        public string Qty1 { get; set; }
        public string Desc1 { get; set; }
        public string Id1 { get; set; }
        public string Price1 { get; set; }
        public string Total1 { get; set; }

        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string Ecom_Payment_Card_ExpDate_Month { get; set; }
        public string Ecom_Payment_Card_ExpDate_Year { get; set; }
        public string CVV { get; set; }

    }

}
