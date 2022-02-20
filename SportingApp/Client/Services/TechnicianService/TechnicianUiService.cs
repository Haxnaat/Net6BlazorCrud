using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.TechnicianService
{
    public class TechnicianUiService : ITechnicianUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public TechnicianUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Technician> Technicians { get; set; } = new List<Technician>();

        public async Task CreateTechnician(Technician model)
        {

            try
            {
                var result = await _http.PostAsJsonAsync("api/technician/createtechnician", model);
                await SetTechnicians(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task SetTechnicians(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Technician>>();
            if (response != null)
            {
                Technicians = response;
                _navigationManager.NavigateTo("technicians");
            }

        }
        public async Task DeleteTechnician(long id)
        {
            var result = await _http.DeleteAsync($"api/technician/DeleteTechnician/{id}");
            await SetTechnicians(result);
        }

        public async Task GetTechnician()
        {
            var result = await _http.GetFromJsonAsync<List<Technician>>("api/technician/gettechnicians");
            if (result != null)
                Technicians = result;
        }

        public async Task<Technician> GetTechnicianById(long Id)
        {
            var result = await _http.GetFromJsonAsync<Technician>($"api/technician/GetTechnicianById/{Id}");
            if (result != null)
                return result;
            throw new Exception("Technician not found!");
        }

        public Task UpdateTechnician(Technician model)
        {
            throw new NotImplementedException();
        }
    }
}
