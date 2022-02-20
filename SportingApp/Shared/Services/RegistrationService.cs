using Microsoft.EntityFrameworkCore;
using SportingApp.Data;
using SportingApp.Data.Domain;
using SportingApp.Shared.Interfaces;

namespace SportingApp.Shared.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly DataContext _context;
        public RegistrationService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Registration>> DeleteRegistration(long Id)
        {
            var regObj = await _context.Registrations.FirstOrDefaultAsync(x => x.Id == Id);
            
            if (regObj != null)
            {
                _context.Registrations.Remove(regObj);
                await _context.SaveChangesAsync();
            }

            return await _context.Registrations.ToListAsync();
        }

        public async Task<Registration> GetRegistrationById(long Id)
        {
            var result = await _context.Registrations.Include(x => x.Customer).Include(x => x.Product).Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
                return result;
            else
                return null;
        }

        public async Task<List<Registration>> GetRegistrations()
        {
            return await _context.Registrations.Include(x=>x.Customer).Include(x=>x.Product).ToListAsync();

        }

        public async Task<List<Registration>> SaveRegistration(long Id, long CustomerId, long ProductId)
        {
            if (Id > 0)
            {
                _context.Registrations.Update(
               new Registration
               {
                   Id = Id,
                   CustomerId=CustomerId,
                   ProductId=ProductId
               });
            }
            else
            {
                _context.Registrations.Update(
              new Registration
              {
                  Id = Id,
                  CustomerId = CustomerId,
                  ProductId = ProductId
              });

            }
            await _context.SaveChangesAsync();
            var returnData = await _context.Registrations.ToListAsync();
            if (returnData != null)
                return returnData;
            return null;
        }
    }
}
