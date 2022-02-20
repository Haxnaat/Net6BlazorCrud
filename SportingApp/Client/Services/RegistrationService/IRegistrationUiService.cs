using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.RegistrationService
{
    public interface IRegistrationUiService
    {
        List<Registration> Registrations { get; set; }


        Task GetRegistrations();
        Task<Registration> GetRegistrationById(long Id);
        Task CreateRegistration(Registration model);
        
        Task DeleteRegistration(long id);
    }
}
