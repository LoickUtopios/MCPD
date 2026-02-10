using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercice2.Class.Model
{
    internal class Client
    {
        public int? Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public List<Commande> Commandes { get; set; } = new List<Commande>();


        public Client(int? id, string prenom, string nom, string adresse, string codePostal, string ville, string telephone)
        {
            Id = id;
            Prenom = prenom;
            Nom = nom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return $"ID: {Id} Identité: {Prenom} {Nom} Telephone: {Telephone} Adresse: {Adresse} {CodePostal} {Ville}";
        }
    }
}