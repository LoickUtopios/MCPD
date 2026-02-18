using System.Diagnostics;
using Demo5_AccesBDD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo5_AccesBDD.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}
