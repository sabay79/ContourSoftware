using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Data.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CardOwnerName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; } = string.Empty;
    }
}