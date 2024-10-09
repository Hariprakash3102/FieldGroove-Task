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
            if (ModelState.IsValid)
            {
                var Detail = await unitOfWork.Register.GetByEmail(model.Email);
            }
            return View();
        }
    }
}
