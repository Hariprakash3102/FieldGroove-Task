using FieldGroove.Application.Contracts.Interface;
using FieldGroove.Domain.Models;
using FieldGroove.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public RegisterController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                await unitOfWork.Register.Add(model);
                await unitOfWork.Save();
                return RedirectToAction("Waiting");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Waiting()
        {
            return View();
        }
    }
}
