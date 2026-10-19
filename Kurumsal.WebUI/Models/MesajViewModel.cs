using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class MesajViewModel
    {
        public Mesaj Mesaj { get; set; }
        public List<Mesaj> Mesajlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
