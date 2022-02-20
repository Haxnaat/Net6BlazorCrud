using Microsoft.EntityFrameworkCore;
using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Code = "CD211", Name = "TestProductOne", Price = 22.2, ReleaseDate = DateTime.UtcNow },
                new Product { Id = 2, Code = "XTY211", Name = "TestProductTwo", Price = 32.63, ReleaseDate = DateTime.UtcNow }

            );
            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    Id = 1,
                    Email = "tech@tech.com",
                    FirstName = "TestTech",
                    LastName = "One",
                    Phone = "3315681100"

                },
                new Technician
                {
                    Id = 2,
                    Email = "techtwo@tech.com",
                    FirstName = "TestTech",
                    LastName = "Two",
                    Phone = "3125337157"

                }
            );
            modelBuilder.Entity<Country>().HasData(
               new Country
               {
                   Id = 1,
                   Name="Pakistan"
               },
               new Country
               {
                   Id = 2,
                   Name = "England"

               }
           );
            modelBuilder.Entity<Customer>().HasData(
              new Customer
              {
                  Id = 1,
                  Email = "cust@cust.com",
                  FirstName = "Cust",
                  LastName = "One",
                  Phone = "3315681100",
                  CountryId=1,
                  City="Rawalpindi",
                  Address="ABC HouseSTREET",
                  PostalCode="45544",
                   State="Punjab"
              },
              new Customer
              {
                  Id = 2,
                  Email = "custtwo@cust.com",
                  FirstName = "Cust",
                  LastName = "two",
                  Phone = "3325233100",
                  CountryId = 1,
                  City = "london",
                  Address = "ABC 34 street ",
                  PostalCode = "ABDE42",
                  State = "Wembley"
              }
          );
            modelBuilder.Entity<Incident>().HasData(
              new Incident
              {
                  Id = 1,
                  CustomerId=1,
                  ProductId=1,
                  TechnicianId=1,
                  Title="TestIncidentOne",
                  Description="This is test incident one",
                  DateOpened=DateTime.UtcNow,
                  DateClosed=null

              },
              new Incident
              {
                  Id = 2,
                  CustomerId = 2,
                  ProductId = 2,
                  TechnicianId = 2,
                  Title = "TestIncidentTwo",
                  Description = "This is test incident two",
                  DateOpened = DateTime.UtcNow,
                  DateClosed = null

              }
          );
            modelBuilder.Entity<User>().HasData(
                
                          new User
                          {
                              Id = 1,
                              Email="abc@abc.com",
                              FirstName="TestUser",
                              LastName = "ABC",
                              Password= "abcdef",
                              RoleId=1
                          }
                         
                      );
            modelBuilder.Entity<Permission>().HasData(
                          new Permission
                          {
                              Id = 1,
                              PermissionName="ManageProducts"
                          },
                           new Permission
                           {
                               Id = 2,
                               PermissionName = "ManageCustomers"
                           }, new Permission
                           {
                               Id = 3,
                               PermissionName = "ManageTechnician"
                           }, new Permission
                           {
                               Id = 4,
                               PermissionName = "ManageIncident"
                           }
                      );
            modelBuilder.Entity<Role>().HasData(
                          new Role
                          {
                              Id = 1,
                              RoleName = "Admin"
                          },
                           new Role
                           {
                               Id = 2,
                               RoleName = "Technician"
                           }
                      );
            modelBuilder.Entity<RolePermissionMapping>().HasData(
                         new RolePermissionMapping
                         {
                             Id = 1,
                             RoleId = 1,
                             PermissionId=1,

                          },
                          new RolePermissionMapping
                          {
                              Id = 2,
                              RoleId = 1,
                              PermissionId = 2,

                          },
                           new RolePermissionMapping
                           {
                               Id =3,
                               RoleId = 1,
                               PermissionId = 3,

                           },
                            new RolePermissionMapping
                            {
                                Id = 4,
                                RoleId = 1,
                                PermissionId = 4,

                            },
                             new RolePermissionMapping
                             {
                                 Id = 5,
                                 RoleId = 2,
                                 PermissionId = 4,

                             }
                     );
            modelBuilder.Entity<Registration>().HasData(
                         new Registration
                         {
                             Id = 1,
                             CustomerId=1,
                             ProductId=1
                         },
                          new Registration
                          {
                              Id = 2,
                              CustomerId = 2,
                              ProductId = 2
                          }
                     );
        }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermissionMapping> RolePermissionMapping { get; set; }


    }
 
    
}
