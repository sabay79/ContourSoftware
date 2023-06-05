using JWTWebAPIDotNet7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTWebAPIDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public ActionResult<User> Register(UserDTO request)
        {
            // Nuget Package: BCrypt.Net-Next
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            user.Username = request.Username;
            user.PasswordHash = passwordHash;

            return Ok(user);
        }

        [HttpPost("login")]
        public ActionResult<User> Login(UserDTO request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("User Not Found");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Wrong Password");
            }

            string token = CreateToken(user);

            return Ok(token);

            // Check username in token at jwt.io
        }

        // Create a JWT manually in Web API with .NET 7
        private string CreateToken(User user)
        {
            // Set username as a claim to token
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            // Get key from AppSettings.json
            var key = new SymmetricSecurityKey(Encoding.UTF8
                    .GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

            
            // Alternate, if key is not stored in AppSetting.json
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AaBbCDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"));

            // Credentials are needed with the key and then signatures 
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            // Write token with help of JwtSecurityTokenHandler
            var JWT = new JwtSecurityTokenHandler().WriteToken(token);

            return JWT;
        }
    }
}
