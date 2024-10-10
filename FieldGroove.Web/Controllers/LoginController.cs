using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            // Check if the model is valid (i.e., required fields are filled)
          if(model.Email == null)
            {
                return Json(new { success = false, message = "UserName is Required" });
            }

            // Fetch the user by email
            var user = await unitOfWork.Register.GetByEmail(model.Email);

            // Check if the user exists
            if (user == null)
            {
                return Json(new { success = false, message = "Email not found. Please register first." });
            }

            if(model.Password == null)
            {
                return Json(new { success = false, message = "Enter the Password, Password is Required" });
            }

            // Check if the password matches
            if (user.Password != model.Password)
            {
                return Json(new { success = false, message = "Incorrect password. Please try again." });
            }

            // If everything is valid, return success
            return Json(new { success = true, message = "Login is Successful" });
        }
    }
}
