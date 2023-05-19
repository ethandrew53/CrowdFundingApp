using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApplication.Data.Models
{
    public class UserDto
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
        //TO ADD
        //Personal details - potential foreign key
        //Card details - foreign key
    }
}
