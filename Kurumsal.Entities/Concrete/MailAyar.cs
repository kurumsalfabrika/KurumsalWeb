using Kurumsal.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete
{
    public class MailAyar : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string SMTPServer { get; set; }
        public string SMTPPort{ get; set; }
        public bool SSL { get; set; }
        public string SMTPEposta { get; set; }
        public string SMTPEpostaSifre { get; set; }
        public string MesajinGelecegiEposta { get; set; }
        public bool Durum { get; set; }
        public DateTime Ekleme { get; set; } = DateTime.Now;
    }
}
