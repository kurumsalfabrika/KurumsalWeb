using Kurumsal.Entities.Concrete;

namespace carita_com_tr.Models
{
    public class HaberViewModel
    {
        public IletisimAyar IletisimAyar { get; set; }
        public Slider Slider { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public List<Haber> Haberler { get; set; }
        public Haber Haber { get; set; }
        public List<Menu> Menuler { get; set; }

    }
}
