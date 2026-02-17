using Demo3_Model.Models;
using Demo3_Model.Views.Personne;

namespace Demo3_Model.Interfaces
{
    // L'interface sert à préciser les méthodes utilisable par notre controleur.
    // Les méthodes sont à définir avec notre équipe afin de pouvoir travailler sur des parties séparé mais lié par l'interface.
    public interface IPersonneService
    {
        public Personne RecupererPersonne(); 
    }
}
