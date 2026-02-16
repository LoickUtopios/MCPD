using Exercice2.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exercice2.Controllers
{
    public class DogController : Controller
    {
        private List<Dog> dogs { get; set; } = new List<Dog>(); 

        public DogController() 
        {
            dogs.Add(new Dog(1, "Idéfix", "Fox Terrier", 5));
            dogs.Add(new Dog(2, "Rex", "Berger Allemand", 3));
            dogs.Add(new Dog(3, "Max", "Husky", 2));
            dogs.Add(new Dog(4, "Jormungant", "Bulldog", 4));
        }


        public IActionResult Display(int id)
        {
            Dog? dogSearched = dogs.SingleOrDefault(d => d.Id == id);

            if (dogSearched == null)
                return RedirectToAction("DisplayAll");

            ViewBag.Dog = dogSearched;
            ViewData["Dog"] = dogSearched;
            return View();
        }

        public IActionResult DisplayAll()
        {
            string allDogs = ""; 

            foreach (Dog dog in dogs)
            {
                allDogs += dog + ", "; 
            }
            ViewData["allDogs"] = allDogs;
            return View();
        }

        public IActionResult Greeting(string? name)
        {

            string message = name == null ? "Bienvenue à vous !!" : "Bienvenue " + name;

            ViewData["message"] = message;
            return View();
        }
    }
}
