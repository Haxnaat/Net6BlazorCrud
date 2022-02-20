using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.AuthService
{
    public class AuthUiService : IAuthUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public AuthUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

     
        public User User { get; set; } = new User();
        public List<Role> Roles { get; set; } = new List<Role>();


        public async Task Login(LoginParams model)
        {
            try
            {
                var result = await _http.PostAsJsonAsync("api/auth/Login", model);
                await SetUser(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task SetUser(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<User>();
            if (response != null)
            {
                 User = response;
              //  _navigationManager.NavigateTo("products");
            }

        }
        public async Task Register(UserDto model)
        {
            try
            {
                var result = await _http.PostAsJsonAsync("api/auth/Register", model);
                _navigationManager.NavigateTo("login");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task GetRoles()
        {
                var result = await _http.GetFromJsonAsync<List<Role>>("api/auth/GetRoles");
                if (result != null)
                    Roles = result;
        }

    }
}
