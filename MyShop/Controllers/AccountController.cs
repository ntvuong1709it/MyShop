using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyShop.Data.Entities;
using MyShop.Service.Interfaces;
using MyShop.Service.Models;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace MyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ICustomerService _customerService;

        public AccountController(IConfiguration config, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
                                 ICustomerService customerService)
        {
            _config = config;
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            var user = new AppUser { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var customer = new Customer
                {
                    IdentityId = user.Id
                };
                _customerService.AddCustomer(customer, User.Identity.Name);
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await AuthenticateAsync(model);

                if (result.Succeeded) 
                    return Ok(new { access_token = GenerateJwtToken() });
                if (result.IsLockedOut)
                    return Forbid();
                else
                    return BadRequest("Invalid login attempt");
            }
            return BadRequest(ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList());
        }

        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        public async Task<IActionResult> CreateToken(LoginModel model)
        {
            var authenResult = await AuthenticateAsync(model);
            if (authenResult.Succeeded)
            {
                return Ok(new { access_token = GenerateJwtToken() });
            }
            return BadRequest();
        }

        private async Task<SignInResult> AuthenticateAsync(LoginModel model)
        {
            return await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,
                lockoutOnFailure: false);
        }

        private string GenerateJwtToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"], expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}