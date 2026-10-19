using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class AcilirMesajViewModel
    {
        public AcilirMesaj AcilirMesaj { get; set; }
        public List<AcilirMesaj> AcilirMesajlar { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
