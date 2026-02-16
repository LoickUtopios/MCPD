using System.Diagnostics;
using Demo1_Controllers.Models;

//using Demo1_Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo1_Controllers.Controllers
{
    public class HomeController : Controller
    {

        // http:localhost:5239/Home/Index 
        public IActionResult Index()
        {
            return View();
        }

        // http:localhost:5239/Home/Privacy 
        public IActionResult Privacy()
        {
            return View();
        }

        // http:localhost:5239/Home/Texte
        public IActionResult Texte()
        {
            return Content("Voici du texte brut !"); 
        }

        // http:localhost:5239/Home/AfficherNom?nom=toto
        public IActionResult AfficherNom(string nom)
        {
            return Content("Bienvenue à " + nom); 
        }

        // http:localhost:5239/Home/AfficherId?id=2
        // http:localhost:5239/Home/AfficherId/2
        public IActionResult AfficherId(int id)
        {
            return Content("Voici votre id : " + id);
        }

        // http:localhost:5239/Home/AfficherPersonne
        public IActionResult AfficherPersonne() 
        {
            Personne p = new Personne(1, "Toto", "Tata", 20);
            return Content(p.ToString());
        }

        // http:localhost:5239/Home/AfficherPersonneJson
        public IActionResult AfficherPersonneJson()
        {
            Personne p = new Personne(1, "Toto", "Tata", 20);
            return Json(p);
        }
    }
}
