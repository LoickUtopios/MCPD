using Demo3_Model.Interfaces;
using Demo3_Model.Models;

namespace Demo3_Model.Services
{
    /*
     * PersonneService implémente l’interface IPersonneService.
     * 
     * Un service contient la logique métier de l’application.
     * Il fait le lien entre le contrôleur et l’accès aux données (Repository).
     */
    public class PersonneService : IPersonneService
    {

        /*
         * Implémentation de la méthode définie dans l’interface.
         * 
         * Le service doit respecter le contrat imposé par IPersonneService,
         * afin de répondre aux attentes du contrôleur.
         */
        public Personne RecupererPersonne()
        {
            /* Logique métier:
            *   - Validation ou vérification des données
            *   - Calculs ou transformations
            *   - Appels à un Repository (accès base de données)
            *   - Mapping vers un DTO
            *       
            */
            return new Personne(1, "Toto", "C'est toto", 30);
        }

    }
}
