using System.Diagnostics;
//using Demo1_Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo1_Controllers.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
