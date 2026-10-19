using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class UrunViewModel
    {
        public Ftp Ftp { get; set; }
        public SiteAyar SiteAyar { get; set; }
        public Urun Urun { get; set; }
        public UrunKategori UrunKategori { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<UrunKategori> UrunKategorileri { get; set; }
        public IEnumerable<SelectListItem> UrunKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
        public IFormFile DosyaVitrin { get; set; }
        public List<Fotograf> Fotograflar { get; set; }

    }
}
