using Kurumsal.Entities.Concrete;

namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class RezervasyonViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Oda Oda { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Slider> Sliderlar { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        public List<Oda> Odalar { get; set; }
        public Rezervasyon Rezervasyon { get; set; }
        public PaymentModel PaymentModel { get; set; }
        public PaymentGaranti PaymentViewModel { get; set; }

        public string ErrorMessage { get; set; }


        public string KrediKartAdSoyad { get; set; }
        public string ClientId { get; set; }
        public string Amount { get; set; }
        public string OkUrl { get; set; }
        public string FailUrl { get; set; }
        public string TranType { get; set; }
        public string? Instalment { get; set; }
        public string Rnd { get; set; }
        public string CallbackUrl { get; set; }
        public string Currency { get; set; }
        public string Pan { get; set; }
        public string Ecom_Payment_Card_ExpDate_Month { get; set; }
        public string Ecom_Payment_Card_ExpDate_Year { get; set; }
        public string Cvv2 { get; set; }
        public string CardType { get; set; }
        public string Lang { get; set; }
        public string HashAlgorithm { get; set; }
        public string StoreType { get; set; }


        public decimal GunlukUcret { get; set; }

    }
}
