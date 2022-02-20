using SportingApp.Data.Domain;

namespace SportingApp.Client.Services.AuthService
{
    public interface IAuthUiService
    {

 
        User User { get; set; }
        List<Role> Roles { get; set; }

        Task Login(LoginParams model);
        Task Register(UserDto model);

        Task GetRoles();


    }
}
