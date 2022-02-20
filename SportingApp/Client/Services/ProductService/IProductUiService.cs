using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.ProductService
{
    public interface IProductUiService
    {
        List<Product> Products { get; set; }


        Task GetProducts();
        Task<Product> GetProductById(long Id);
        Task CreateProducts(Product model);
        Task GetProductsCustomerWise(long Id);
        Task DeleteProducts(long id);
    }
}
