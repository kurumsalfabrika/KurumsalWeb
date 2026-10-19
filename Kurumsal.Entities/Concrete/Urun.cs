using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
	public class Urun : IEntity
	{
		public int Id { get; set; }
		public int Sira { get; set; } = 0;
		public string Baslik { get; set; }
        public string StokKodu { get; set; }
        public string UrunKodu { get; set; }
		public decimal Fiyat { get; set; } = 0;
		public decimal IndirimliFiyat { get; set; } = 0;
		public int StokDurumId { get; set; }
		public int? UrunKategoriId { get; set; } // Optional foreign key
		public UrunKategori UrunKategori { get; set; }
        public string OneCikanGorsel { get; set; }

		//Vitrin 
        public string AnaSayfaVitrinResmi { get; set; }
		public bool VitrindeGoster { get; set; } = false;
        public string VitrinUrunBaslik { get; set; }
        public string VitrinUrunAciklama { get; set; }

        //Vitrin Bitiş
        public int FotografGaleriId { get; set; }
		public string TeknikDokuman { get; set; }
		public int KatalogId { get; set; }
		public string Katalog { get; set; }
		public bool Durum { get; set; }
		public bool YeniUrun { get; set; }
		public bool AnasayfadaGoster { get; set; }
		public string SpotMetin { get; set; }
		public string Icerik { get; set; }
		public DateTime Ekleme { get; set; } = DateTime.Now;
		public string SEOAciklama { get; set; }
		public string SEOKelimeler { get; set; }
	}
}
