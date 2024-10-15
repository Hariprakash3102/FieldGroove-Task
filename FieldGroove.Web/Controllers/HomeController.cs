using FieldGroove.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FieldGroove.Web.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Leads()
        {
            return View();
        }

        public IActionResult CreateLead()
        {
            return View();
        }
    }
}


