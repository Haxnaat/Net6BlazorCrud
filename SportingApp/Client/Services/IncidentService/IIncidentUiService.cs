using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.IncidentService
{
    public interface IIncidentUiService
    {
        List<Technician> Technicians { get; set; }
        List<Product> Products { get; set; }
        List<Customer> Customers { get; set; }
        List<Incident> Incidents { get; set; }


        Task GetIncidents();
        Task<Incident> GetIncidentById(long Id);
        Task CreateIncident(Incident model);
        Task UpdateIncident(Incident model);
        Task DeleteIncident(long id);
    }
}
