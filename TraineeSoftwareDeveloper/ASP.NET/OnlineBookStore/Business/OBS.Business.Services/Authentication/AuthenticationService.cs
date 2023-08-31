using OBS.Business.Interfaces.Authentication;
using OBS.Business.Models.Login;
using OBS.Data.Models.IdentityModels;

namespace OBS.Business.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<HttpResponseMessage> LogIn(UserLoginDTO loginUser)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Register(User registerUser, string role)
        {
            throw new NotImplementedException();
        }
    }
}
