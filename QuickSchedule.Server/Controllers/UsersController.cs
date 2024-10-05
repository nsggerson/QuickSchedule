using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickSchedule.Shared.Models;


namespace QuickSchedule.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
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
    }
}
