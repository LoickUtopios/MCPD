using Exercice5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice5.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult DisplayForm()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult TreatForm(Product product) 
        {
            if (!ModelState.IsValid)
            {
                return View("DisplayForm", product);
            }
            return RedirectToAction("DisplayResult");
        }

        [HttpGet]
        public IActionResult DisplayResult()
        {
            return View();
        }
    }
}
