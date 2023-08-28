namespace Payment.Business.Models
{
    public class PaymentDetailModel
    {
        public int PaymentDetailID { get; set; }
        public string CardOwnerName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string ExpirationDate { get; set; } = string.Empty;
        public string SecurityCode { get; set; } = string.Empty;
    }
}
