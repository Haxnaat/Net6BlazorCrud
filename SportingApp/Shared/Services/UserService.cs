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
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public Task<List<User>> DeleteUser(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> SaveUser(string Email, string FirstName, string LastName,string Password, int RoleId)
        {
            _context.Users.AddAsync(
                new User {
                    Email = Email,
                    FirstName = FirstName,
                    LastName = LastName,
                    Password = Password,
                    RoleId = RoleId }
            );
            _context.SaveChanges();
            var userData = _context.Users.Include(x => x.Role).Where(x => x.Email == Email).FirstOrDefaultAsync();
            if (userData != null)
                return userData;
            return null;
        }
        public async Task<User> Login(string email,string password)
        {
            var loginData = await _context.Users.Include(x=>x.Role).Where(x => x.Email == email && x.Password==password).FirstOrDefaultAsync();
            if (loginData != null)
                return loginData;
            return null;
        }
        public async Task<List<Role>> GetRoles()
        {
            var rolesData = await _context.Roles.ToListAsync();
            if (rolesData != null)
                return rolesData;
            return null;
        }


    }
}

