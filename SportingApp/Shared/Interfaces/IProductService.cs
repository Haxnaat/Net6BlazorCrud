using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> SaveProduct(long Id, string Code, string Name, double Price, DateTime ReleaseDate);
        Task<List<Product>> DeleteProduct(long Id);
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductsCustomerWise(long Id);
        Task<Product> GetProductById(long Id);
    }
}
