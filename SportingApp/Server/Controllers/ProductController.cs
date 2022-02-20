using Microsoft.AspNetCore.Mvc;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService  _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet(Name ="getproducts")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(long id)
        {
            var product = await _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound("Sorry, no Customer here. :/");
            }
            return Ok(product);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProductByCustomerId(long id)
        {
            var product = await _productService.GetProductsCustomerWise(id);
            if (product == null)
            {
                return NotFound("Sorry, no Customer here. :/");
            }
            return Ok(product);
        }
        [HttpPost(Name ="createproduct")]
        public async Task<ActionResult<List<Product>>> CreateProduct([FromBody] Product model)
        {
            var products = await _productService.SaveProduct(model.Id,model.Code, model.Name, model.Price, model.ReleaseDate);
            return Ok(products);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteProduct(int id)
        {

            var products = await _productService.DeleteProduct(id);
            return Ok(products);
        }

    }
}

