using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class SosyalMedyaAdresViewModel
    {
        public SosyalMedyaAdres SosyalMedyaAdres { get; set; }
        public List<SosyalMedyaAdres> SosyalMedyaAdresler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
