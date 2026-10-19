using Kurumsal.Core.Entities;
using System;

namespace Kurumsal.Entities.Concrete
{
    public class SosyalMedyaAyar : IEntity
    {
        public int Id { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string Youtube { get; set; }

        public DateTime Ekleme { get; set; } = DateTime.Now;
    } 
}
