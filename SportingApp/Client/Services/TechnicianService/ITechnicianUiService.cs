using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.TechnicianService
{
    public interface ITechnicianUiService
    {
        List<Technician> Technicians { get; set; }
        

        Task GetTechnician();
        Task<Technician> GetTechnicianById(long Id);
        Task CreateTechnician(Technician model);
        Task UpdateTechnician(Technician model);
        Task DeleteTechnician(long id);

    }
}
