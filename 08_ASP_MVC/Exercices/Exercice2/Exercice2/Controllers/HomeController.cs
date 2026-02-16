using System.Diagnostics;
using Exercice2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
