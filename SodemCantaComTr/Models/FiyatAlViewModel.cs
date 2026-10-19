using Kurumsal.Entities.Concrete;

namespace SodemCantaComTr.Models
{
    public class FiyatAlViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public FiyatAl FiyatAl { get; set; }
        public Teklif Teklif { get; set; }
    }
}
