namespace Kurumsal.DumanSafir.WebUI.Models
{
    public class PaymentViewModel
    {
        public string SecurityLevel { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public string CvvCode { get; set; }
        public double TotalAmount { get; set; }
        public string FormData { get; set; }
        public string ErrorMessage { get; set; }
        public string SystemErrorMessage { get; set; }
        public string Currency { get; set; }
    }
}
