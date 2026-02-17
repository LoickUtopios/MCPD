using Demo3_Model.Interfaces;
using Demo3_Model.Models;

namespace Demo3_Model.Services
{
    public class PersonneService : IPersonneService
    {

        public Personne RecupererPersonne()
        {
            // Logique métier
            return new Personne(1, "Toto", "C'est toto", 30);
        }

    }
}
