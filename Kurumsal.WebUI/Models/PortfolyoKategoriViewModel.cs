using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class PortfolyoKategoriViewModel
    {
        public PortfolyoKategori PortfolyoKategori { get; set; }
        public List<PortfolyoKategori> PortfolyoKategoriler { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
