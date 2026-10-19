using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class YorumViewModel
    {
        public Yorum Yorum { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
