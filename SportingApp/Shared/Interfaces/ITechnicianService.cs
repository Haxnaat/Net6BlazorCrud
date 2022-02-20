using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Interfaces
{
    public interface ITechnicianService
    {
        Task<List<Technician>> SaveTechnician(long Id, string Email, string FirstName, string LastName, string Phone);
        Task<List<Technician>> DeleteTechnician(long Id);
        Task<List<Technician>> GetTechnicians();
        Task<Technician> GetTechnicianById(long Id);
    }
}
