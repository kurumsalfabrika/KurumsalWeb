using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class HaberKategoriViewModel
    {
        public HaberKategori HaberKategori { get; set; }
        public List<HaberKategori> HaberKategoriler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
