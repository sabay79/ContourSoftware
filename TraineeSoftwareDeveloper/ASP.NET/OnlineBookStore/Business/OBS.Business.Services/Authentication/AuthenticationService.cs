using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OBS.Business.Interfaces.Authentication;
using OBS.Business.Interfaces.Email;
using OBS.Business.Models.Email;
using OBS.Business.Models.Login;
using OBS.Data.Models.IdentityModels;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
namespace OBS.Business.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        private readonly IUrlHelper _urlHelper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;
        public AuthenticationService(UserManager<IdentityUser> userManager,
               RoleManager<IdentityRole> roleManager, IEmailService emailService,
               IConfiguration configuration,
               IUrlHelper urlHelper, IHttpContextAccessor httpContextAccessor,
               JwtSecurityTokenHandler jwtSecurityTokenHandler)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _configuration = configuration;
            _urlHelper = urlHelper;
            _httpContextAccessor = httpContextAccessor;
            _jwtSecurityTokenHandler = jwtSecurityTokenHandler;
        }

        public async Task<Response> Register(User registerUser, string role)
        {
            // Check if user exists
            if (await FindUser(registerUser) != null)
            {
                return new Response { Status = "Error", Message = "User Already Exists!" };
            }

            // Add user in the database
            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username
            };
            if (await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user, registerUser.Password);
                /*
                 * The Identity Framework has the following conditions for passwords:
                        Minimum length: The password must be at least 6 characters long.
                        Uppercase character: The password must contain at least one uppercase character.
                        Lowercase character: The password must contain at least one lowercase character.
                        Digit: The password must contain at least one digit.
                        Non-alphanumeric character: The password must contain at least one non-alphanumeric character, such as a special character or punctuation mark.
                    These conditions can be configured in the IdentityOptions.Password
                 */
                // SabaY, syn79.fl@gmail.com, Saba@1234

                if (!result.Succeeded)
                {
                    return new Response { Status = "Error", Message = "Failed to Create User!" };
                }

                // Assign role to a user
                await _userManager.AddToRoleAsync(user, role);

                // Add token to verify the email
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = _urlHelper; // Get Url
                var request = _httpContextAccessor.HttpContext.Request; // Get the Request object
                var confirmationLink = url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, request.Scheme);
                var message = new Message(new string[] { user.Email! }, "Email Confirmation Link", confirmationLink!);

                _emailService.SendEmail(message);
                return new Response { Status = "Success", Message = $"User Created Successfully and Email Sent to {user.Email}" };
            }
            else
            {
                return new Response { Status = "Error", Message = "Role Doesnot Exist!" };
            }
        }
        public async Task<HttpResponseMessage> LogIn(UserLoginDTO loginUser)
        {
            // Validate User
            var user = await _userManager.FindByNameAsync(loginUser.Username);
            // Check user and password
            if (user != null && await _userManager.CheckPasswordAsync(user, loginUser.Password))
            {
                // Claim List
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                // Get all roles related to user
                var userRoles = await _userManager.GetRolesAsync(user);

                // Add Roles to the list of Claims
                foreach (var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                // Generate token with claims
                var jwtToken = GetToken(authClaims);

                // Return token
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(_jwtSecurityTokenHandler.WriteToken(jwtToken), Encoding.UTF8);
                return response;
                //return Ok(new
                //{
                //    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                //    expiration = jwtToken.ValidTo
                //});

            }
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            //return Unauthorized();
        }
        private async Task<IdentityUser> FindUser(User registerUser) => await _userManager.FindByEmailAsync(registerUser.Email);
        private async Task<Response> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return new Response { Status = "Success", Message = "Email Address Verified Successfully!" };
                }
            }
            return new Response { Status = "Error", Message = "Failed to verify Email Address!" };
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));
            return token;
        }


    }
}
