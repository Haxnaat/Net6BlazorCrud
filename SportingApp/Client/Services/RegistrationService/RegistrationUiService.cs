using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.RegistrationService
{
    public class RegistrationUiService : IRegistrationUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public RegistrationUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Registration> Registrations { get; set; } = new List<Registration>();

        public async Task CreateRegistration(Registration model)
        {
            try
            {
                var result = await _http.PostAsJsonAsync("api/registration/CreateRegistration", model);
                await SetRegistrations(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task SetRegistrations(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Registration>>();
            if (response != null)
            {
                Registrations = response;
                _navigationManager.NavigateTo("registrations");
            }

        }
        public async Task DeleteRegistration(long id)
        {

            var result = await _http.DeleteAsync($"api/registration/DeleteRegistration/{id}");
            await SetRegistrations(result);
        }

        public async Task<Registration> GetRegistrationById(long Id)
        {
            var result = await _http.GetFromJsonAsync<Registration>($"api/registration/GetRegistrationById/{Id}");
            if (result != null)
                return result;
            throw new Exception("Registration not found!");
        }

        public async Task GetRegistrations()
        {
            var result = await _http.GetFromJsonAsync<List<Registration>>("api/registration/GetRegistrations");
            if (result != null)
                Registrations = result;
        }
    }
}
