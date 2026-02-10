using CorrectionExercice2.Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercice2.Class.DTOs
{
    internal class ClientInfoDTO
    {
        public Client Client{get ; set;}
        public List<Commande> Commandes {get; set;} = new List<Commande>();

        public ClientInfoDTO(Client c, List<Commande> allCommands)
        {
            Client = c;
            Commandes = allCommands;
        }
    }
}
