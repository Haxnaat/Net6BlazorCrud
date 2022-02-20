using SportingApp.Data.Domain;

namespace SportingApp.Shared.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> SaveCustomer(long Id, string Email, string FirstName, string LastName, string Phone, int CountryId, string City, string Address, string PostCode, string State);
        Task<List<Customer>> DeleteCustomer(long Id);
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(long Id);
        Task<List<Country>> GetCountries();
    }
}
