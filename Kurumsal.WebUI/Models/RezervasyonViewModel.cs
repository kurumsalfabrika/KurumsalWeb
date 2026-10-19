using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class RezervasyonViewModel
    {
        public Rezervasyon Rezervasyon { get; set; }
        public List<Rezervasyon> Rezervasyonlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
