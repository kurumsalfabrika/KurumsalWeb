using Kurumsal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kurumsal.Entities.Concrete
{
    public class ApiAyar : IEntity
    {
        public int Id { get; set; }
        public string WhatsappKod { get; set; }
        public string GoogleAnalyticsKodu { get; set; }
        public string WebmasterToolsDogrumaKodu { get; set; }
        public string IletisimHaritaEmbedKodu { get; set; }
        public string CanliDestekKodu { get; set; }
        public string GoogleRcapthaKodu { get; set; }

        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
