using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//La classe `Bibliotheque` contient :

//*Une * *liste de livres**
//* Une méthode pour :
//  *Ajouter un livre
//  * Supprimer un livre par son numéro
//  * Afficher tous les livres
//  * Rechercher un livre par son titre

namespace Exercice18.Classes
{
    internal class Bibliotheque
    {
        private List<Livre> _livreList = new List<Livre>();
        public List<Livre> Livres { get { return _livreList; } set { _livreList = value; } }

        public Bibliotheque() { }


        public void Ajouter(Livre livre)
        {
            livre.Titre = livre.Titre.Trim().ToLower();
            livre.Auteur = livre.Auteur.Trim().ToLower();
            Livres.Add(livre);
            Console.WriteLine("Livre ajouté !");
        }

        public void Ajouter(int numero, string titre, string auteur, int nbExemplaire)
        {
            titre = titre.Trim().ToLower();
            auteur = auteur.Trim().ToLower(); 

            Livres.Add(new Livre(numero, titre, auteur, nbExemplaire));
            Console.WriteLine("Livre ajouté !");
        }

        public void Supprimer(int numero)
        {
            // Méthode 1
            for (int i = 0; i < Livres.Count; i++)
            {
                if (Livres[i].Numero == numero)
                {
                    Livres.RemoveAt(i);
                    break;
                }
            }

            // Méthode 2
            //Livre livreASupprimer = Livres.FirstOrDefault(l => l.Numero == numero);
            //Livres.Remove(livreASupprimer);
        }

        public void AfficherLivres()
        {
            
            Console.WriteLine("===== Bibliothèque =====");
            if (Livres.Count == 0)
            {
                Console.WriteLine("Aucun livres dans la bibliothèques");
                return;
            }

            // Méthode 1
            foreach (Livre livre in Livres)
            {
                Console.WriteLine(" - " + livre);
            }

            // Méthode 2
            // Livres.ForEach(Console.WriteLine);
        }

        public void RechercherLivreParTitre(string titre)
        {
            titre = titre.Trim().ToLower();

            int id = -1;

            for(int i = 0;i < Livres.Count; i++)
            {
                if (Livres[i].Titre == titre)
                    id = i; 
            }

            if (id == -1)
            {
                Console.WriteLine("Aucun livre trouvé avec le titre : " + titre);
                return;
            }

            Console.WriteLine($"Le titre du livre est {Livres[id].Titre}");

            // Méthode 2
            //List<Livre> livresTrouve = Livres.FindAll(n => n.Titre == titre).ToList();
            
            //if(livresTrouve.Count == 0)
            //    Console.WriteLine("Aucun livre trouvé avec le titre : " + titre);

            //livresTrouve.ForEach(Console.WriteLine);
        }

        public void RechercherLivreParAuteur(string auteur)
        {
            auteur = auteur.Trim().ToLower();

            int id = -1;

            for (int i = 0; i < Livres.Count; i++)
            {
                if (Livres[i].Auteur == auteur)
                    id = i;
            }

            if (id == -1)
            {
                Console.WriteLine("Aucun auteur trouvé avec ce nom : " + auteur);
                return;
            }

            Console.WriteLine($"L'auteur est {Livres[id].Auteur}");
        }

    }
}
