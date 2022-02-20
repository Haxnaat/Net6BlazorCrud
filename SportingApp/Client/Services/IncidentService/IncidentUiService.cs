using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.IncidentService
{
    public class IncidentUiService : IIncidentUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public IncidentUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Technician> Technicians { get; set; } = new List<Technician>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Incident> Incidents { get; set; } = new List<Incident>();

        public async Task CreateIncident(Incident model)
        {

            try
            {
                var result = await _http.PostAsJsonAsync("api/incident/createincident", model);
                await SetIncidents(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task DeleteIncident(long id)
        {
            var result = await _http.DeleteAsync($"api/indicent/DeleteIncident/{id}");
            await SetIncidents(result);
        }

        public async Task<Incident> GetIncidentById(long Id)
        {
            var result = await _http.GetFromJsonAsync<Incident>($"api/incident/GetIncidentById/{Id}");
            if (result != null)
                return result;
            throw new Exception("Incident not found!");
        }

        public async Task GetIncidents()
        {
                var result = await _http.GetFromJsonAsync<List<Incident>>("api/incident/getincidents");
                if (result != null)
                    Incidents = result;
        }

        public Task UpdateIncident(Incident model)
        {
            throw new NotImplementedException();
        }

        private async Task SetIncidents(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Incident>>();
            if (response != null)
            {
                Incidents = response;
                _navigationManager.NavigateTo("incidents");
            }

        }
    }
}
