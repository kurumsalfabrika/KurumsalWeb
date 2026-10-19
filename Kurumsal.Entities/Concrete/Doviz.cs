using Kurumsal.Entities.Concrete.Base;
using Kurumsal.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete
{
    public class Doviz : BaseEntityDurum
    {
        public override string Kod { get; set; }
        public string DovizAdi { get; set; }
        [Column(TypeName = "money")]
        public decimal DovizAlis { get; set; } = 0;
        [Column(TypeName = "money")]
        public decimal DovizSatis { get; set; } = 0;
        [StringLength(500)]
        public string Aciklama { get; set; }
        public KartTuru KartTuru { get; set; } = KartTuru.Doviz;
    }
    
}
