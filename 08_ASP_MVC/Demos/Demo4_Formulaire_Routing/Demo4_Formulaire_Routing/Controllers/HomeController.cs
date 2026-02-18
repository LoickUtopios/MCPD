using System.Diagnostics;
using Demo4_Formulaire_Routing.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo4_Formulaire_Routing.Controllers
{
    [Route("Accueil")]
    public class HomeController : Controller
    {

        [HttpPost("Contact")]
        public IActionResult CreerContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View("AfficherContact", contact);
            }

            return RedirectToAction("Succes");
        }

        [HttpGet("Contact")]
        public IActionResult AfficherContact()
        {
            Contact contact = new Contact();
            return View(contact);
        }

        [Route("toto")]
        public IActionResult Succes()
        {
            return View();
        }


    }
}
