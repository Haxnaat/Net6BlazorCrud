using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService  _customerService;
       
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
           
        }

        [HttpGet(Name = "getcustomers")]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            var customers = await _customerService.GetCustomers();
            return Ok(customers);
        }

        [HttpGet( "{id}")]
        public async Task<ActionResult<Customer>> GetCustomersById(long id)
        {
            var customer =  await _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound("Sorry, no Customer here. :/");
            }
            return Ok(customer);
        }

        [HttpPost(Name = "createcustomer")]
        public async Task<ActionResult<List<Customer>>> CreateCustomer([FromBody] Customer model )
        {
            var customers = await _customerService.SaveCustomer(model.Id,model.Email,model.FirstName,model.LastName,model.Phone,model.CountryId,model.City,model.Address,model.PostalCode,model.State);
            return Ok(customers);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)
        {

            var customers = await _customerService.DeleteCustomer(id);
            return Ok(customers);
        }
        [HttpGet]
        public async Task<ActionResult<List<Country>>> GetCountry()
        {
            var country = await _customerService.GetCountries();
            return Ok(country);
        }
    }
}
