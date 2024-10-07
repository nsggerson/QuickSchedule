using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickSchedule.Server.InterfaceService;
using QuickSchedule.Shared.Models;


namespace QuickSchedule.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(ILoginService _loginService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            await Task.Delay(100);
            // Simulando a obtenção de usuários (substitua por sua lógica real)
            var users = new List<UserSy>
            {
                new UserSy { Id = 1, Name = "Alice" },
                new UserSy { Id = 2, Name = "Bob" }
            };

            return Ok(users); // Retorna os usuários como JSON
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(InputLoginRequest inputLoginRequest)
        {            
                var result = await _loginService.LoginAsync(email:inputLoginRequest.Login, password: inputLoginRequest.Password);
                return Ok(); // Retorna os usuários como JSON            
        }
    }
}
