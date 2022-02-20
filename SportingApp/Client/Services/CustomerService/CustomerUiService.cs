using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.CustomerService
{
    public class CustomerUiService : ICustomerUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public CustomerUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Customer>  Customer { get; set; } = new List<Customer>();
        public List<Country>  Countries { get; set; } = new List<Country>();
        
        public async Task CreateCustomer(Customer model)
        {
            try
            {
               // _http.DefaultRequestHeaders.Add("Auth", "MyCustomHeader");
                var result = await _http.PostAsJsonAsync("api/customer/createcustomer", model);
                await SetCustomers(result);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        private async Task SetCustomers(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Customer>>();
            if (response != null)
            {
                Customer = response;
                _navigationManager.NavigateTo("customers");
            }
               
        }
        public async Task<Customer> GetCustomerById(long Id)
        {
            var result = await _http.GetFromJsonAsync<Customer>($"api/customer/GetCustomersById/{Id}");
            if (result != null)
                return result;
            throw new Exception("Customer not found!");
        }

        public async Task GetCustomers()
        {
            try
            {
                var result = await _http.GetFromJsonAsync<List<Customer>>("api/customer/getcustomers");
                if (result != null)
                    Customer = result;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public async Task GetCountries()
        {
            var result = await _http.GetFromJsonAsync<List<Country>>("api/customer/GetCountry");
            if (result != null)
                Countries = result;
        }

        public Task UpdateCustomer(Customer model)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteCustomer(long id)
        {
            var result = await _http.DeleteAsync($"api/customer/DeleteCustomer/{id}");
            await SetCustomers(result);
        }

    }
}
