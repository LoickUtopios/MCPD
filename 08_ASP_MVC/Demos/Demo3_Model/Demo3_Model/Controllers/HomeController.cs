using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Demo3_Model.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
