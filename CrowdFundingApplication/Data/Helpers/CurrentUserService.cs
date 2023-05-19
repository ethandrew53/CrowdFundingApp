using System.ComponentModel.DataAnnotations;

namespace CrowdFundingApplication.Data.Models
{
    public class CurrentUserService
    {
        public CurrentUser CurrentUser { get; set; }
        public void SetCurrentUser(int id, string username. string password)
        {
            CurrentUser = new CurrentUser
            {
                UserId = id,
                UserName = username,
                Password = password,
            }
        }
    }
}

