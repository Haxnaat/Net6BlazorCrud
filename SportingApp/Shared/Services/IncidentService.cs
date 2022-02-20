using Microsoft.EntityFrameworkCore;
using SportingApp.Data;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Services
{
    public class IncidentService : IIncidentService
    {

        private readonly DataContext _context;
        public IncidentService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Incident>> DeleteIncident(long Id)
        {
            var incident = await _context.Incidents.FirstOrDefaultAsync(x => x.Id == Id);
            if (incident != null)
            {
                _context.Incidents.Remove(incident);
                await _context.SaveChangesAsync();

            }

            return await _context.Incidents.ToListAsync();
        }

        public async Task<Incident> GetIncidentById(long Id)
        {
            var result = await _context.Incidents
                .Include(x=>x.Customer)
                .Include(x=>x.Product)
                .Include(x=>x.Technician)
                .Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
                return result;
            else
                return null;
        }

        public async Task<List<Incident>> GetIncidents()
        {
            return await _context.Incidents
                 .Include(x => x.Customer)
                 .Include(x => x.Product)
                 .Include(x => x.Technician).Where(x => x.Title != null).ToListAsync();

        }

        public async Task<List<Incident>> SaveIncident(long Id, string Title, string Description, DateTime DateOpen, DateTime? DateClosed, long CustomerId, long ProductId, long TechnicianId)
        {
            if (Id > 0)
            {
                _context.Incidents.Update(
               new Incident
               {
                   Id = Id,
                   Title = Title,
                   Description  = Description,
                   DateOpened   = DateOpen,
                   DateClosed   = DateClosed,
                   CustomerId   = CustomerId,
                   ProductId    = ProductId,
                   TechnicianId = TechnicianId
               });
            }
            else
            {
                await _context.Incidents.AddAsync(
                new Incident
                {
                    Id = Id,
                    Title = Title,
                    Description = Description,
                    DateOpened = DateOpen,
                    DateClosed = DateClosed,
                    CustomerId = CustomerId,
                    ProductId = ProductId,
                    TechnicianId = TechnicianId
                });

            }
            await _context.SaveChangesAsync();
            var returnData = await _context.Incidents.ToListAsync();
            if (returnData != null)
                return returnData;
            return null;
        }
    }
}
