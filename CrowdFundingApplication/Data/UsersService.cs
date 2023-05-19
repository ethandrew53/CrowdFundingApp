using CrowdFundingApplication.Data.Models;

namespace CrowdFundingApplication.Data
{
    public class UsersService
    {
        private static readonly List<UserDto> Users = new List<UserDto>
        {
            new UserDto {UserId = 1, UserName = "user1", Password = "password" },
            new UserDto {UserId = 2, UserName = "user2", Password = "password" },
            new UserDto {UserId = 3, UserName = "user3", Password = "password" },
            new UserDto {UserId = 4, UserName = "user4", Password = "password" }
        };
        public bool DoesUserExist(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetUserId(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return user.UserId;
                }
            }
            return 0;
        }

        //TODO this will need to get users previous investment data to check if they have donated to a specific funding before
        public bool HasUserFunded(int fundId, int userId)
        {
            //TODO Get donation history by fundId. If user.UserId is found within return true else return false
            //In future would select * from database.Transactions where FundingId = fundId && UserId = userId to see if any matching
            //transactions are found, would allow scalabilty of allowing multiple transactions but retaining a monetary limit
            //foreach (var trans in TransactionList)
            //{
            //    if (trans.FundId == fundId && trans.UserId == userId)
            //    {
            //        return false;
            //    }
            //}
            return false;
            //return true;
        }
    }
}