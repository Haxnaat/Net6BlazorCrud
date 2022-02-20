using Microsoft.AspNetCore.Components;
using SportingApp.Data.Domain;
using System.Net.Http.Json;

namespace SportingApp.Client.Services.ProductService
{
    public class ProductUiService : IProductUiService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public ProductUiService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task CreateProducts(Product model)
        {
            try
            {
                var result = await _http.PostAsJsonAsync("api/product/createproduct", model);
                await SetProducts(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async Task SetProducts(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Product>>();
            if (response != null)
            {
                Products = response;
                _navigationManager.NavigateTo("products");
            }

        }
        public async Task DeleteProducts(long id)
        {
            var result = await _http.DeleteAsync($"api/product/DeleteProduct/{id}");
            await SetProducts(result);
        }

        public async Task<Product> GetProductById(long Id)
        {
            var result = await _http.GetFromJsonAsync<Product>($"api/product/GetProductById/{Id}");
            if (result != null)
                return result;
            throw new Exception("Product not found!");
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Product>>("api/product/getproducts");
            if (result != null)
                Products = result;
        }

        public async Task GetProductsCustomerWise(long Id)
        {
            var result = await _http.GetFromJsonAsync<List<Product>>($"api/product/GetProductByCustomerId/{Id}");
            if (result != null)
                Products = result;
            else
            {
                Products = new List<Product>();
                throw new Exception("Product not found!");
            }
        }
    }
}
