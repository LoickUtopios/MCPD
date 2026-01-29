using Exercice11.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11.Classes
{
    internal class Scientifique : Travailleur
    {
        public TypeEnum Type { get; set; }
        public DisciplineEnum Discipline { get; set; }

        public Scientifique(string nom, string prenom, string telephone, string email, string entrepriseNom, string entrepriseAdresse, string telephonePro, TypeEnum type, DisciplineEnum discipline)
            : base(nom, prenom, telephone, email, entrepriseNom, entrepriseAdresse, telephonePro)
        {
            Type = type;
            Discipline = discipline;
        }

        public override string ToString()
        {
            return base.ToString() + $"Je suis un scientifique {Type} en {Discipline}. \n";
        }

    }
}
