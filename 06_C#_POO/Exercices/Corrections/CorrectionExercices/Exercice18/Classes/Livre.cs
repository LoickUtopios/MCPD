using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


//1.Créer une classe **Livre**

//La classe `Livre` contient :

//*Un numéro(int)
//* Un titre(string)
//* Un auteur(string)
//* Un nombre d’exemplaires disponibles (int)

namespace Exercice18.Classes
{
    internal class Livre
    {
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbExemplaire { get; set; }

        public Livre(int numero, string titre, string auteur, int nbExemplaire)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            NbExemplaire = nbExemplaire;
        }

        public override string ToString()
        {
            return $"Numero : {Numero}, Titre : {Titre}, Auteur : {Auteur}, NbExemplaire : {NbExemplaire}.";
        }
    }
}
