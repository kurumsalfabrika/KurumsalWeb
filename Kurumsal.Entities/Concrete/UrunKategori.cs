using Kurumsal.Core.Entities;
using System;
using System.Collections.Generic;

namespace Kurumsal.Entities.Concrete
{
	public class UrunKategori : IEntity
	{
		public int Id { get; set; }
		public int? UstKategoriId { get; set; } // Optional foreign key to prevent issues
		public int Sira { get; set; } = 0;
		public string KategoriAdi { get; set; }
		public string KategoriAciklama { get; set; }
		public string OneCikanGorsel { get; set; }
		public string SEOUrl { get; set; }
		public string SEOAciklama { get; set; }
		public string SEOKelimeler { get; set; }
		public bool Durum { get; set; }
		public bool AnasayfadaGoster { get; set; }
		public DateTime Ekleme { get; set; } = DateTime.Now;
		public IEnumerable<Urun> Urunler { get; set; }
		public UrunKategori UstKategori { get; set; }
		public ICollection<UrunKategori> AltKategoriler { get; set; } // Added for hierarchical relationship
	}
}
