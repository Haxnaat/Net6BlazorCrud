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
    public class TechnicianService : ITechnicianService
    {
        private readonly DataContext _context;

        public TechnicianService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Technician>> DeleteTechnician(long Id)
        {
            var technicianObj = await _context.Technicians.FirstOrDefaultAsync(x => x.Id == Id);
            var incidentObj = await _context.Incidents.Where(x => x.TechnicianId == Id).ToListAsync();
            if (incidentObj != null && incidentObj.Count() > 0)
            {
                _context.Incidents.RemoveRange(incidentObj);
                await _context.SaveChangesAsync();
            }
            if (technicianObj != null)
            {
                _context.Technicians.Remove(technicianObj);
                await _context.SaveChangesAsync();
            }

            return await _context.Technicians.ToListAsync();
        }

        public async Task<Technician> GetTechnicianById(long Id)
        {
            var result = await _context.Technicians.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
                return result;
            else
                return null;
        }

        public async Task<List<Technician>> GetTechnicians()
        {
            return await _context.Technicians.Where(x => x.Email != null).ToListAsync();
        }

        public async Task<List<Technician>> SaveTechnician(long Id, string Email, string FirstName, string LastName, string Phone)
        {
            if (Id > 0)
            {
                _context.Technicians.Update(
               new Technician
               {
                   Id = Id,
                   Email = Email,
                   FirstName = FirstName,
                   LastName = LastName,
                   Phone = Phone,
               });
            }
            else
            {
                await _context.Technicians.AddAsync(
                new Technician
                {
                    Email = Email,
                    FirstName = FirstName,
                    LastName = LastName,
                    Phone = Phone,
                   
                });

            }
            await _context.SaveChangesAsync();
            var returnData = await _context.Technicians.ToListAsync();
            if (returnData != null)
                return returnData;
            return null;
        }
    }
}
