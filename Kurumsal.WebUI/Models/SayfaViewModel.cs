using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SayfaViewModel
    {
        public Sayfa Sayfa { get; set; }
        public SayfaKategori SayfaKategori { get; set; }
        public List<Sayfa> Sayfalar { get; set; }
        public List<SayfaKategori> SayfaKategorileri { get; set; }
        public IEnumerable<SelectListItem> SayfaKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
        public List<IFormFile> Dosyalar { get; set; }
    }

}
