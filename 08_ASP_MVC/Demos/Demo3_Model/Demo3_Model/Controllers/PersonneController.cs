using Demo3_Model.Interfaces;
using Demo3_Model.Models;
using Demo3_Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo3_Model.Controllers
{
    public class PersonneController : Controller
    {
        IPersonneService PersonneService { get; set; }
        public PersonneController(IPersonneService personneService) 
        {
            PersonneService = personneService;
        }
        public IActionResult AfficherPersonne()
        {
            Personne p = PersonneService.RecupererPersonne(); 
            return View(p);
        }
    }
}
