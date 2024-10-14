using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FieldGroove.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IConfiguration configuration;

        public LoginController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            this.unitOfWork = unitOfWork;
            this.configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        { 
          if(model.Email == null)
            {
                return Json(new { success = false, message = "UserName is Required" });
            }
 
            var user = await unitOfWork.Register.GetByEmail(model.Email);
 
            if (user == null)
            {
                return Json(new { success = false, message = "Email not found. Please register first." });
            }

            if(model.Password == null)
            {
                return Json(new { success = false, message = "Enter the Password, Password is Required" });
            }
             
            if (user.Password != model.Password)
            {
                return Json(new { success = false, message = "Incorrect password. Please try again." });
            }

            var token = GenerateJwtToken(user);
 
            return Json(new { success = true, message = token });
        }

        private string GenerateJwtToken(RegisterModel model)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("UserName", model.Email!)
            };

            var token = new JwtSecurityToken(
               issuer: configuration["Jwt:Issuer"],
               audience: configuration["Jwt:Audience"],
               claims: claims,
               expires: DateTime.Now.AddMinutes(30),
               signingCredentials: credentials
           );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
