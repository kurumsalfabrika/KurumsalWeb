using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SSSKategoriViewModel
    {
        public SSSKategori SSSKategori { get; set; }
        public List<SSSKategori> SSSKategoriler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
