using ASPNET_Core_2_1.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace ASPNET_Core_2_1.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }

}
