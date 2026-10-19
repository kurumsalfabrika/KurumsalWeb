using Kurumsal.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kurumsal.WebUI.Models
{
    public class PortfolyoViewModel
    {
        public Portfolyo Portfolyo { get; set; }
        public PortfolyoKategori PortfolyoKategori { get; set; }
        public List<Portfolyo> Portfolyolar { get; set; }
        public List<PortfolyoKategori> PortfolyoKategorileri { get; set; }
        public IEnumerable<SelectListItem> PortfolyoKategoriList { get; set; }
        [JsonIgnore]
        public IFormFile Dosya { get; set; }
    }
}
