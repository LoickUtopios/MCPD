using System.Diagnostics;
using Exercice3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice3.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
