using QuickSchedule.Shared.Models;

namespace QuickSchedule.Server.InterfaceService
{
    public interface ILoginService
    {
        Task<ApplicationUser> LoginAsync(string email, string password);
        Task LogoutAsync();
        Task<bool> IsUserLoggedInAsync();
    }
}
