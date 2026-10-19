using Kurumsal.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete.Base
{
    public class BaseEntity : IEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public virtual string Kod { get; set; }
        [Column(Order = 2)]
        public virtual long? FirmaId { get; set; }
        [Column(Order = 3), StringLength(200)]
        public string ListeKodu { get; set; }
        [Column(Order = 4), StringLength(200)]
        public string TabloKodu { get; set; }
        [Column(Order = 5), StringLength(200)]
        public string TabloAdi { get; set; }
        [Column(Order = 6), StringLength(500)]
        public string Sinternal { get; set; }
        public long? Longternal { get; set; }
        [Column(Order = 7)]
        public int? Internal { get; set; }
        [Column(Order = 8), StringLength(500)]
        public string BenzersizKod { get; set; }
        [Column(Order = 9)]
        public virtual long? KaydedenKullaniciId { get; set; }
        [Column(Order = 10, TypeName = "date")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now.Date;
        [Column(Order = 11)]
        public virtual long? DuzenleyenKullaniciId { get; set; }
        [Column(Order = 12, TypeName = "date")]
        public DateTime? DuzenlemeTarihi { get; set; }
        [Column(Order = 13)]
        public virtual string BelgeNo { get; set; }
        public long? SubeId { get; set; }
    }
}
