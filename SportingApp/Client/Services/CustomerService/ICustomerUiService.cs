using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.CustomerService
{
    public interface ICustomerUiService
    {
        List<Customer> Customer { get; set; }
        List<Country> Countries { get; set; }
      
        Task GetCustomers();
        Task<Customer> GetCustomerById(long Id);
        Task CreateCustomer(Customer model);
        Task UpdateCustomer(Customer model);
        Task DeleteCustomer(long id);

        Task  GetCountries();


    }
}
