using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Exercice1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
