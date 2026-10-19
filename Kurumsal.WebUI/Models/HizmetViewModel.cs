using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class HizmetViewModel
    {
        public Hizmet Hizmet { get; set; }
        public List<Hizmet> Hizmetler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
