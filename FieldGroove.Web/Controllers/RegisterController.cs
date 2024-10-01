using FieldGroove.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.Web.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
          return View(model);
        }
    }
}
