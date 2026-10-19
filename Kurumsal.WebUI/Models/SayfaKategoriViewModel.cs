using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SayfaKategoriViewModel
    {
        public SayfaKategori SayfaKategori { get; set; }
        public List<SayfaKategori> SayfaKategoriler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
