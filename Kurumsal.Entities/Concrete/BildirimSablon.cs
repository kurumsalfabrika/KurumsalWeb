using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class BildirimSablon : IEntity
    {
        public int Id { get; set; }
        public string SablonTuru { get; set; }

        public bool UyeyeEpostaGonder { get; set; }
        public bool UyeyeSMSGonder { get; set; }
        public bool YoneticiyeSMSGonder { get; set; }
        public bool YoneticiyeEpostaGonder { get; set; }
        public string EpostaKonuBasligiUye { get; set; }
        public string EpostaKonuBasligiYonetici { get; set; }
        public string UyeyeGidecekEposta { get; set; }
        public string YoneticiyeGidecekEposta { get; set; }
        public string Degiskenler { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
