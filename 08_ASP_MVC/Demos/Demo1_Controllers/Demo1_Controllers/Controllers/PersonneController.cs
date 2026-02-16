using Demo1_Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Demo1_Controllers.Controllers
{
    public class PersonneController : Controller
    {
        public List<Personne> Personnes {  get; set; }

        public PersonneController() 
        { 
            Personnes = new List<Personne>();
            Personnes.Add(new Personne(1, "Toto", "Tata", 20)); 
            Personnes.Add(new Personne(2, "Titi", "Tutu", 30)); 
            Personnes.Add(new Personne(3, "Marco", "Polo", 40));
        }

        // http:localhost:5239/Personne/AfficherPersonne/1
        // http:localhost:5239/Personne/AfficherPersonne?id=1
        public IActionResult AfficherPersonne(int id)
        {
            return Json(Personnes.Where(p => p.Id == id).Single()); 
        }

        // http:localhost:5239/Personne/AfficherPersonneHtml/1
        public IActionResult AfficherPersonneHtml(int id)
        {
            Personne p = Personnes.Where(p => p.Id == id).Single();

            ViewData["nom"] = p.Nom;
            ViewData["prenom"] = p.Prenom;

            ViewBag.Personne = p;

            return View(); 
        }
    }
}
