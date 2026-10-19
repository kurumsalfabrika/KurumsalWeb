using Kurumsal.Entities.Concrete;

namespace SodemCantaComTr.Models
{
    public class ReferansViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Referans Referans { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Referans> Referanslar { get; set; }
    }
}
