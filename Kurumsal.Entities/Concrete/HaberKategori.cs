using Kurumsal.Core.Entities;
using System;
using System.Collections.Generic;

namespace Kurumsal.Entities.Concrete
{
    public class HaberKategori : IEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; } = 0;
        public string KategoriAdi { get; set; }
        public string OneCikanGorsel { get; set; }
        public string SEOUrl { get; set; }
        public string SEOAciklama { get; set; }
        public string SEOKelimeler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;

        public IEnumerable<Haber> Haberler { get; set; }
    }
    public class Cart:IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; } // Kullanıcı ID'si
        public decimal ToplamTutar { get; set; }
        public decimal KdvTutari { get; set; }
        public decimal GenelToplam { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }

    public class CartItem:IEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; } // Ürün ID'si
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Ürün fiyatı
        public int KdvOrani { get; set; } = 20;
        public decimal Miktar { get; set; }
        public decimal KdvTutari { get; set; }
        public decimal SatirToplami { get; set; }
        public Cart Cart { get; set; }
    }

}
