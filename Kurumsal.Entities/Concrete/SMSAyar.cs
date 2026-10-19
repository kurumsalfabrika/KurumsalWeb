using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class SMSAyar : IEntity
    {
        public int Id { get; set; }
        public string PostURL { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifresi { get; set; }
        public string ApiSecret { get; set; }
        public string Baslik { get; set; }
        public bool SSL { get; set; }
        public string MesajinGelecegiNumara { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
