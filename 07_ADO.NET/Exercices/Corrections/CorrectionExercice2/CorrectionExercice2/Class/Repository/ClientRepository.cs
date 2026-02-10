using CorrectionExercice2.Class.DbManager;
using CorrectionExercice2.Class.DTOs;
using CorrectionExercice2.Class.Model;
using MySql.Data.MySqlClient;

namespace CorrectionExercice2.Class.Repository
{
    internal class ClientRepository
    {
        public Client Save(Client client)
        {
            string request = "INSERT INTO client (prenom, nom, adresse, code_postal, ville, telephone) VALUES (@prenom, @nom, @adresse, @code_postal, @ville, @telephone);";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {
                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@code_postal", client.CodePostal);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@telephone", client.Telephone);

                    connection.Open();
                    command.ExecuteNonQuery();                
                    
                    // Récupération de l’ID auto-généré par MySQL utile pour connaitre l'id attribue au client (auto increment en bdd)
                    client.Id = (int)command.LastInsertedId;
                }
            }
            return client;
        }

        public Client Update(Client client)
        {
            string request = "UPDATE client SET prenom=@prenom, nom=@nom, adresse=@adresse, code_postal=@code_postal, ville=@ville, telephone=@telephone WHERE id=@id;";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {

                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@code_postal", client.CodePostal);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@telephone", client.Telephone);
                    command.Parameters.AddWithValue("@id", client.Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            return client;
        }

        public bool Delete(Client client)
        {
            // Suppression des commandes du client
            CommandeRepository commandeRepo = new CommandeRepository();
            commandeRepo.DeleteAllCommandsOfAClient(client);

            // Suppression du client
            string request = "DELETE FROM client WHERE id=@id";
            int rows = 0;
            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@id", client.Id);

                    connection.Open();

                    rows = command.ExecuteNonQuery();
                }
            }
            return rows > 0;
        }

        public Client? GetOneById(int id)
        {
            Client? client = null;

            string request = "SELECT id, prenom, nom, adresse, code_postal, ville, telephone FROM client WHERE id=@id;";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();

                    using MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        client = new Client(reader.GetInt32("id"),
                            reader.GetString("prenom"),
                            reader.GetString("nom"),
                            reader.GetString("adresse"),
                            reader.GetString("code_postal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone"));
                    }

                    if (client is not null)
                    {
                        CommandeRepository commandeRepo = new CommandeRepository();
                        client.Commandes = commandeRepo.GetAllCommandsOfAClient(client);
                    }
                }
            }
            return client;
        }

        // Méthode 2 avec jointure et DTO
        public ClientInfoDTO? GetInfoById(int id)
        {
            ClientInfoDTO? client = null;

            string request = """
                    SELECT 
                        cl.id, cl.prenom, cl.nom, cl.adresse, cl.code_postal, cl.ville, cl.telephone,
                        co.id AS commande_id, co.total, co.date_commande
                    FROM client AS cl
                    INNER JOIN commande AS co ON co.client_id = cl.id
                    WHERE cl.id = @id;
                    """;

            using MySqlConnection connection = DataConnection.GetConnection();
            using MySqlCommand command = new MySqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            using MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Création du client UNE seule fois
                if (client is null)
                {
                    client = new ClientInfoDTO(
                        new Client(
                            reader.GetInt32("id"),
                            reader.GetString("prenom"),
                            reader.GetString("nom"),
                            reader.GetString("adresse"),
                            reader.GetString("code_postal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone")
                        ),
                        new List<Commande>()
                    );
                }

                // Ajout des commandes
                client.Commandes.Add(new Commande(
                    reader.GetInt32("commande_id"),
                    reader.GetDecimal("total"),
                    reader.GetDateTime("date_commande"),
                    reader.GetInt32("id")
                ));
            }

            return client;
        }

        public List<Client> GetAll()
        {
            List<Client> clients = new();

            string request = "SELECT id, prenom, nom, adresse, code_postal, ville, telephone FROM client;";

            using (MySqlConnection connection = DataConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(request, connection))
                {

                    connection.Open();

                    using MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clients.Add(
                            new Client(reader.GetInt32("id"),
                            reader.GetString("prenom"),
                            reader.GetString("nom"),
                            reader.GetString("adresse"),
                            reader.GetString("code_postal"),
                            reader.GetString("ville"),
                            reader.GetString("telephone")));
                    }
                }
            }
            return clients;
        }
    }
}
