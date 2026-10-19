using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurumsal.Entities.Concrete
{
    public class PaymentGaranti
    {
        public string SecurityLevel { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public string CvvCode { get; set; }
        public double TotalAmount { get; set; }
        public string Currency { get; set; }
    }
}
