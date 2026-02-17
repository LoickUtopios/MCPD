using Microsoft.AspNetCore.Mvc;

namespace Exercice3.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
            string prenom = "toto";
            int age = 15; 
            List<string> hobbies = new List<string>() {"Jeux vidéo", "Cinéma", "Randonnée" };

            ViewData["prenom"] = prenom;
            ViewData["age"] = age;
            ViewData["hobbies"] = hobbies;
            return View();
        }
    }
}
