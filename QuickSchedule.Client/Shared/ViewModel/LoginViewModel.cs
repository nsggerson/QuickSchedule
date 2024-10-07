
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using QuickSchedule.Shared.Models;

namespace QuickSchedule.Client.Shared.ViewModel
{
    public class LoginViewModel(HttpClient _httpClient)
    {

        public async Task<bool> AuthenticateUserAsync(InputLoginRequest userAccess)
        {
            // Lógica para autenticar o usuário usando HttpClient
            var response = await _httpClient.PostAsJsonAsync("api/users/login", userAccess);
            return false;
        }
    }
}
