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
    internal class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public StatutReservation StatutReservation { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client? Client { get; set; }

        public int ChambreId { get; set; }
        [ForeignKey("ChambreId")]
        public Chambre? Chambre { get; set; }
        
        public Reservation() { }
        public Reservation(int clientId, int chambreId, StatutReservation statut)
        {
            ClientId = clientId;
            ChambreId = chambreId;
            StatutReservation = statut;
        }

        public override string ToString()
        {
            return $"Reservation n°{Id} ({StatutReservation}) : \n" +
                $"Client : \n {Client} \n" +
                $"Chambre : \n {Chambre} \n";
        }
    }
}
