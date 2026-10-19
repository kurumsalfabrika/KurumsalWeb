using Kurumsal.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete
{
    public class FiyatAl : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public string SecilenResim { get; set; }
        public string SecilenOlcu { get; set; }
        public string OlusanDosya { get; set; }

    } 
}
