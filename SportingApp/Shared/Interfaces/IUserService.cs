using SportingApp.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportingApp.Shared.Interfaces
{
    public  interface IUserService
    {
        Task<User?> SaveUser( string Email, string FirstName, string LastName, string Password,int RoleId);
        Task<List<User>> DeleteUser(long Id);
        Task<List<User>> GetUser();
        Task<User> GetUserById(long Id);
        Task<User> Login(string email,string password);
        Task<List<Role>> GetRoles();
    }
}
