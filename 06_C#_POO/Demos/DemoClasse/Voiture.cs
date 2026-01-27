using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasse.Classes
{
    internal class Voiture
    {
        // Attributs
        public int _nbPneu; // Attribut publique (accès à tous)
        private int _nbPorte; // Attibut privé (accessible uniquement dans la classe)
        private string _marque;
        private string _model;

        // Attribut static
        private static int _nbVoiture = 0;

        // Propriété static
        public static int NbVoiture { get => _nbVoiture; set => _nbVoiture = value; }

        // Propriétés
        // Get permet la récupération de donnée
        // Set est uniqument pour la modification de donnée
        public int NbPorte { get => _nbPorte; set => _nbPorte = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public bool IsStarted { get; set; } = false;

        // Constructeur
        public Voiture() 
        { 
            NbVoiture++; 
        }
        public Voiture(string model, string marque)
            : this (4, 5, model, marque) {  }
        public Voiture(int nbPneu, int nbPorte, string marque, string model): this()
        {
            _nbPneu = nbPneu; // Attribut accéder directement (public)
            NbPorte = nbPorte; // Attribut accéder via leur propriété
            Marque = marque;
            Model = model;
        }

        // Méthodes (fonctions de la classe)
        public void StartEngine()
        {
            if (!IsStarted)
            {
                Console.WriteLine($"La voiture {Model} démarre !!! ");
                IsStarted = true;
            }
            else
            {
                Console.WriteLine("Crrrrrrrr la voiture est déjà démarré !!!!");
            }
            
        }

        public static void AfficherNbVoiture()
        {
            Console.WriteLine("Vous avez construit " + NbVoiture + " voitures");
        } 

        public static void Presentation(string model)
        {
            Console.WriteLine("Votre modele " + model + " est super !!"); // Utilise un parametre

            // Erreur, aucun accès à une variable d'instance en static  
            // Console.WriteLine("Votre modele " + Model + " est super !!"); 
        }

        public override string ToString()
        {
            return $"Je suis une voiture de marque {Marque} et de model {Model}. J'ai {_nbPneu} pneus et {NbPorte} portes.";
        }
    }
}
