using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Interfaces
{
    public interface IRegistrationService
    {
        Task<List<Registration>> SaveRegistration(long Id,long CustomerId,long ProductId);
        Task<List<Registration>> DeleteRegistration(long Id);
        Task<List<Registration>> GetRegistrations();
        Task<Registration> GetRegistrationById(long Id);
    }
}
