using OBS.Business.Models.Login;
using OBS.Data.Models.IdentityModels;

namespace OBS.Business.Interfaces.Authentication
{
    public interface IAuthenticationService
    {
        Task<Response> Register(User registerUser, string role);
        Task<HttpResponseMessage> LogIn(UserLoginDTO loginUser);
    }
}
