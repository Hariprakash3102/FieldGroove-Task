using Microsoft.AspNetCore.Mvc;

namespace FieldGroove.Web.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult RegisterAdd()
        {
            return View();
        }
    }
}
