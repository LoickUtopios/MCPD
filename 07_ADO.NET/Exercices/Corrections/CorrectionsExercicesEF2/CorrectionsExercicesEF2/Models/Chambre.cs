using CorrectionsExercicesEF2.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionsExercicesEF2.Models
{
    internal class Chambre
    {
        [Key]
        [Required]
        public int Numero { get; set; }
        public StatutChambre Statut { get; set; }

        [Column("nombre_de_lit")]
        [Range(1, 6)]
        public int NbLit { get; set; }

        public double Tarif { get; set; }

        public Chambre() { }
        public Chambre(int numero, StatutChambre statut, int nbLit, double tarif)
        {
            Numero = numero;
            Statut = statut;
            NbLit = nbLit;
            Tarif = tarif;
        }

        public override string ToString()
        {
            return $"{Numero} - {NbLit} Lit à {Tarif}€ ({Statut.ToString()})";
        }
    }
}
