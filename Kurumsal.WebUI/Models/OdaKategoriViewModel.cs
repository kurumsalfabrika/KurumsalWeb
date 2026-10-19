using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class OdaKategoriViewModel
    {
        public OdaKategori OdaKategori { get; set; }
        public List<OdaKategori> OdaKategoriler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
