using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApplication.Data.Models
{
    public class TransactionDto
    {
        [Key]
        [Required]
        public int TransactionId { get; set; }
        [Required]

        public int FundId { get; set; }
        [Required]

        public int UserId { get; set; }
        [Required]

        public int Amount { get; set; }
    }
}
