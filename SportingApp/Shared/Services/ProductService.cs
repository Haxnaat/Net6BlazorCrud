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
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
       
        public async Task<List<Product>> DeleteProduct(long Id)
        {
            var prodObj = await _context.Products.FirstOrDefaultAsync(x => x.Id == Id);
            var incidentObj = await _context.Incidents.Where(x => x.ProductId == Id).ToListAsync();
            if (incidentObj != null && incidentObj.Count() > 0)
            {
                _context.Incidents.RemoveRange(incidentObj);
                await _context.SaveChangesAsync();
            }
            if (prodObj != null)
            {
                _context.Products.Remove(prodObj);
                await _context.SaveChangesAsync();
            }

            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Where(x => x.Name != null).ToListAsync();

        }

        public async Task<Product> GetProductById(long Id)
        {
            var result = await _context.Products.Where(x => x.Id == Id).FirstOrDefaultAsync();
            if (result != null)
                return result;
            else
                return null;
        }
        public async Task<List<Product>> GetProductsCustomerWise(long Id)
        {
            var productIds = await _context.Registrations.Where(x => x.CustomerId == Id).ToListAsync();
            return await _context.Products.Where(x => productIds.Select(y => y.ProductId).Contains(x.Id)).ToListAsync();
        }
       
        public async Task<List<Product>> SaveProduct(long Id, string Code, string Name, double Price, DateTime ReleaseDate)
        {
            if (Id > 0)
            {
                _context.Products.Update(
               new Product
               {
                   Id = Id,
                   Code = Code,
                   Name = Name,
                   Price = Price,
                   ReleaseDate = ReleaseDate,
               });
            }
            else
            {
                await _context.Products.AddAsync(
                new Product
                {
                    Id = Id,
                    Code =Code,
                    Name = Name,
                    Price = Price,
                    ReleaseDate = ReleaseDate,
                });

            }
            await _context.SaveChangesAsync();
            var returnData = await _context.Products.ToListAsync();
            if (returnData != null)
                return returnData;
            return null;
        }
    }
}
