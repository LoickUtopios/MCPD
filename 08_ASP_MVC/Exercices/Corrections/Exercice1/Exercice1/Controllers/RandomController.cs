using Microsoft.AspNetCore.Mvc;

namespace Exercice1.Controllers
{
    public class RandomController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();
            ViewData["random"] = random.Next(1, 101);
            return View();
        }
    }
}
