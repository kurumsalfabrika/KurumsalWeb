using Kurumsal.Entities.Concrete;

namespace kirilmazlar_com_tr.Models
{
    public class MarkaViewModel
    {
        public Marka Marka { get; set; }
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public List<Marka> Markalar { get; set; }
   }

  
}
