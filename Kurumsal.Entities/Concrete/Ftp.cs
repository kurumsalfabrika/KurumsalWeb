using Kurumsal.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kurumsal.Entities.Concrete
{
    public class Ftp : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string FtpURL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DosyaAdresOnEki { get; set; }
    }
}
