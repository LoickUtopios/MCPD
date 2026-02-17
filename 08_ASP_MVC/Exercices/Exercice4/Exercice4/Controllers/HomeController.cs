using System.Diagnostics;
using Exercice4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice4.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

    }
}
