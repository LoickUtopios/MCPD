using System.Diagnostics;
using Exercice5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
