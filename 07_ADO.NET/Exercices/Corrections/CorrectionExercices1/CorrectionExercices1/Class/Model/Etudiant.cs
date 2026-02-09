using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercices1.Class.Model
{
    internal class Etudiant
    {
        public int? Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Email { get; set; }

        public Etudiant() { }
        public Etudiant(int? id, string nom, string prenom, DateTime dateDeNaissance, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Id} - {Nom} {Prenom} née le {DateDeNaissance} ({Email})";
        }
    }
}
