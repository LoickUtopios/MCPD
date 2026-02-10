using CorrectionExercice2.Class.DbManager;
using CorrectionExercice2.Class.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionExercice2.Class.Repository
{
    internal class CommandeRepository
    {
        public Commande Save(Commande commande)
        {
            string request = "INSERT INTO commande (total, date_commande, client_id) VALUES (@total, @date_commande, @client_id);";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@total", commande.Total);
                    command.Parameters.AddWithValue("@date_commande", commande.DateCommande);
                    command.Parameters.AddWithValue("@client_id", commande.ClientId);

                    
                    command.ExecuteNonQuery();

                    // Récupération de l’ID auto-généré par MySQL utile pour connaitre l'id attribue au client (auto increment en bdd)
                    commande.Id = (int)command.LastInsertedId;
                }
            }
            return commande;
        }

        public List<Commande> GetAllCommandsOfAClient(Client client)
        {
            List<Commande> commandes = new();

            string request = "SELECT id, total, date_commande, client_id FROM commande WHERE client_id=@client_id;";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@client_id", client.Id);

                    connection.Open();

                    // TODO
                    using MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        commandes.Add(new Commande(reader.GetInt32("id"),
                            reader.GetDecimal("total"),
                            reader.GetDateTime("date_commande"),
                            reader.GetInt32("client_id")));
                    }
                }
            }
            return commandes;
        }

        public void DeleteAllCommandsOfAClient(Client client)
        {
            string request = "DELETE FROM commande WHERE client_id=@client_id";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@client_id", client.Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
