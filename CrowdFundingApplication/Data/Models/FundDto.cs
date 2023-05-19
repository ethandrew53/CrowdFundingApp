using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApplication.Data.Models
{
    public class FundDto
    {
        [Key]
        [Required]
        public int FundId { get; set; }
        [Required]

        public int UserId { get; set; }
        [Required]

        public string Name { get; set; }
        public string Description { get; set; }
        [Required]

        public int InvestmentAmount { get; set; }
        [Required]

        public int InvestmentRequired { get; set; }
        public bool InvestmentComplete => InvestmentAmount == InvestmentRequired;

        //TO ADD
        //Interest rate
    }
}
