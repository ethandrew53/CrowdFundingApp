using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApplication.Helpers
{
    public class CurrentUser
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
