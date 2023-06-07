﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces.Email;
using OBS.Business.Models.Email;
using OBS.Data.Models.IdentityModels;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        public AuthenticationController(UserManager<IdentityUser> userManager,
               RoleManager<IdentityRole> roleManager, IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
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
            if (await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response
                        {
                            Status = "Error",
                            Message = "Failed to Create User!"
                        });
                }
                // Assign role to a user
                await _userManager.AddToRoleAsync(user, role);

                // Add token to verify the email
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, Request.Scheme);
                var message = new Message(new string[] { user.Email! }, "Email Confirmation Link", confirmationLink!);

                _emailService.SendEmail(message);

                return StatusCode(StatusCodes.Status200OK,
                    new Response
                    {
                        Status = "Success",
                        Message = $"User Created Successfully and Email Sent to {user.Email}"
                    });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response
                    {
                        Status = "Error",
                        Message = "Role Doesnot Exist!"
                    });
            }
        }

        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status200OK,
                        new Response
                        {
                            Status = "Success",
                            Message = "Email Address Verified Successfully!"
                        });
                }
            }
            return StatusCode(StatusCodes.Status500InternalServerError,
                new Response
                {
                    Status = "Error",
                    Message = "Failed to verify Email Address!"
                });
        }

        //[HttpGet]
        //public IActionResult TestEmail()
        //{
        //    try
        //    {
        //        var message = new Message(
        //                    new List<string> { "saba79.bda@gmail.com" },
        //                    "Test",
        //                    "This is Test Email...\n" +
        //                    "https://www.youtube.com/watch?v=Oif6-76-Bfk&list=PLX4n-znUpc2b19AoYa4BMuhGuRnZItJK_&index=7");
        //        _emailService.SendEmail(message);

        //        return StatusCode(StatusCodes.Status200OK,
        //            new Response
        //            {
        //                Status = "Success",
        //                Message = "Email Sent Successfully!"
        //            });
        //    }
        //    catch
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            new Response
        //            {
        //                Status = "Error",
        //                Message = "Failed to send Email!"
        //            });
        //    }
        //}
    }
}
