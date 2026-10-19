using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class ReferansViewModel
    {
        public Referans Referans { get; set; }
        public List<Referans> Referanslar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
