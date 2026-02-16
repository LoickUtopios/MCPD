using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Demo2_View.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vue()
        {
            return View();
        }

        public IActionResult VueAvecNom(string? nom)
        {
            ViewBag.Nom = nom;
            return View();
        }
    }
}
