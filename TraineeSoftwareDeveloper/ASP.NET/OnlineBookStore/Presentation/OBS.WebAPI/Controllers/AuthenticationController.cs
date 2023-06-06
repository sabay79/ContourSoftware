using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OBS.Data.Models.IdentityModels;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityUser> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<IdentityUser> userManager,
               RoleManager<IdentityUser> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] User registerUser, string role)
        {
            // Check if user exists
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new Response
                    {
                        Status = "Error",
                        Message = "User Already Exists!"
                    });
            }

            // Add user in the database
            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username
            };

            var result = await _userManager.CreateAsync(user, registerUser.Password);
            return result.Succeeded
                ? StatusCode(StatusCodes.Status201Created,
                    new Response { Status = "Success", Message = "User Created Successfully!" })
                : (IActionResult)StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", Message = "Failed to Create User!" });
        }
    }
}
