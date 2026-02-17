using Demo3_Model.Interfaces;
using Demo3_Model.Models;
using Demo3_Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo3_Model.Controllers
{
    public class PersonneController : Controller
    {
        // Le service est déclarer localement afin d'être utilisable pour chaque endpoint
        // du controlleur.
        IPersonneService PersonneService { get; set; }


        /*
         * Pour l'injection de dépendances (Dependency Injection - DI), le service est injecté via le constructeur. 
         * Nous devons fournir l'interface du service au constructeur via ses paramètres (et non pas en l'initialisant de lui-même)
         * 
          * On dépend d'une interface plutôt que d'une classe concrète, ce qui permet :
         *      - Couplage faible (pas de forte dépendance à une classe spécifique)
         *      - Plus flexible (nous pouvons utiliser plusieurs type de service)
         *      - Plus pratique pour le travail d'équipe (les méthodes sont définis à l'avance, non-bloquant)
         *      - Utile pour les tests (Nous pouvons fournir des Services Mocker ou Simulé)
         */

        public PersonneController(IPersonneService personneService) 
        {
            PersonneService = personneService;
        }


        public IActionResult AfficherPersonne()
        {
            /*
             * Le contrôleur ne contient pas de logique métier.
             * Il reçoit une requête HTTP, appelle le service,
             * puis transmet le résultat à la vue.
             */
            Personne p = PersonneService.RecupererPersonne();

            // Le modèle est envoyé à la vue pour affichage.
            return View(p);
        }
    }
}
