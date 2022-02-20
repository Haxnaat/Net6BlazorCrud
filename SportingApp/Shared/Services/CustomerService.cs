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
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context;
        }
       public async Task<List<Customer>> SaveCustomer(long Id,string Email,string FirstName,string LastName,string Phone,int CountryId,string City,string Address,string PostCode,string State)
        {
            if (Id>0)
            {
                 _context.Customers.Update(
                new Customer
                {
                  Id = Id,
                  Email = Email,
                  FirstName = FirstName,
                  LastName = LastName,
                  Phone = Phone,
                  CountryId = CountryId,
                  City = City,
                  Address = Address,
                  PostalCode = PostCode,
                  State = State
                });
            }
            else
            {
               await _context.Customers.AddAsync(
               new Customer
               {
                   Email = Email,
                   FirstName = FirstName,
                   LastName = LastName,
                   Phone = Phone,
                   CountryId = CountryId,
                   City = City,
                   Address = Address,
                   PostalCode = PostCode,
                   State = State
               });

            }
           await  _context.SaveChangesAsync();
           var returnData =  await _context.Customers.ToListAsync();
           if(returnData!=null)
                return returnData;
            return null;

        }

       public async Task<List<Customer>> DeleteCustomer(long Id)
       {
            var customerObj = await _context.Customers.FirstOrDefaultAsync(x=>x.Id == Id);
            var incidentObj = await _context.Incidents.Where(x => x.CustomerId == Id).ToListAsync();
            if(incidentObj !=null && incidentObj.Count() > 0)
            {
                _context.Incidents.RemoveRange(incidentObj);
                await _context.SaveChangesAsync();
            }
            if (customerObj != null)
            {
                _context.Customers.Remove(customerObj);
                await _context.SaveChangesAsync();

            }

            return await _context.Customers.ToListAsync();
       }
       public async Task<List<Customer>> GetCustomers()
       {
            return await _context.Customers.Where(x => x.Email != null).ToListAsync();

       }
       public async Task<Customer> GetCustomerById(long Id)
       {
            var result =  await _context.Customers.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
                return result;
            else
               return null;

       }
        public async Task<List<Country>> GetCountries()
        {
            return await _context.Countries.Where(x => x.Name != null).ToListAsync();

        }


    }
}
