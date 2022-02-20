using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Interfaces
{
    public interface IIncidentService
    {
        Task<List<Incident>> SaveIncident(long Id, string Title, string Description, DateTime DateOpen, DateTime? DateClosed,long CustomerId,long ProductId,long TechnicianId);
        Task<List<Incident>> DeleteIncident(long Id);
        Task<List<Incident>> GetIncidents();
        Task<Incident> GetIncidentById(long Id);
    }
}
