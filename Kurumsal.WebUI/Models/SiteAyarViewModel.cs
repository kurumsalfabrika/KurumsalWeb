using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SiteAyarViewModel
    {
        public SiteAyar SiteAyar { get; set; }
        public List<SiteAyar> SiteAyarlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
        public IFormFile Dosya1 { get; set; }
        public IFormFile Dosya2 { get; set; }
        public IFormFile Dosya3 { get; set; }
        public IFormFile Dosya4 { get; set; }
        public IFormFile Dosya5 { get; set; }
    }
}
