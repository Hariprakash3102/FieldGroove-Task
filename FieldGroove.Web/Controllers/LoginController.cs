using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
