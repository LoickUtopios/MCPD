using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercicesEF1.Classes
{
    internal class Adresse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("numero_de_voie")]
        public int NumVoie {  get; set; }

        [Column("complement_d_adresse")]
        public string Complement { get; set; }

        [Column("intitule_de_voie")]
        public string Intitule { get; set; }

        public string Commune { get; set; }

        [StringLength(5)]
        public string CodePostal { get; set; }

        public Adresse() { }

        public Adresse(int numVoie, string complement, string intitule, string commune, string codePostal)
        {
            NumVoie = numVoie;
            Complement = complement;
            Intitule = intitule;
            Commune = commune;
            CodePostal = codePostal;
        }

        public override string ToString()
        {
            return $"{Id} - {NumVoie} {Complement} {Intitule}, {Commune} ({CodePostal})";
        }
    }
}
