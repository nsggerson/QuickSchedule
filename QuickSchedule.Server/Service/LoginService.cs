using Microsoft.EntityFrameworkCore;
using QuickSchedule.Server.Context;
using QuickSchedule.Server.InterfaceService;
using QuickSchedule.Shared.Models;

namespace QuickSchedule.Server.Service
{
    public class LoginService(AppDbContext _dbContext) : ILoginService
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public LoginService(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}

        public async Task<ApplicationUser> LoginAsync(string email, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(p => p.Login == email);

            return user;
        }

        public async Task LogoutAsync()
        {
            // Limpa a sessão ou tokens, conforme a lógica de logout
            //_httpContextAccessor.HttpContext.Session.Remove("User");
        }

        public async Task<bool> IsUserLoggedInAsync()
        {
            // Verifica se o usuário está logado verificando a sessão
            // return _httpContextAccessor.HttpContext.Session.GetString("User") != null;
            return true;
        }

       
    }
}
