using DemoADO.Classes.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO.Classes.Repository
{
    internal class PersonneRepository
    {
        // Cette chaine donne les paramètres de connection avec la BDD.
        string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public void AjouterUnePersonne(Personne p)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Attention de ne pas permettre à l'utilisateur d'insérer directement ses valeurs.
                // Il risque d'écrire des requêtes SQL dangereuse (Injection de SQL)
                //string query = $"INSERT INTO Personne (nom, prenom, age, email) " +
                //    $"VALUES ('{p.Nom}','{p.Prenom}',{p.Age},'{p.Email}')";

                string query = $"INSERT INTO Personne (nom, prenom, age, email) " +
                    $"VALUES (@nom,@prenom,@age,@email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", p.Nom);
                    command.Parameters.AddWithValue("@prenom", p.Prenom);
                    command.Parameters.AddWithValue("@age", p.Age);
                    command.Parameters.AddWithValue("@email", p.Email);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été inséré : " + nbInsertion);
                }
            }
        }

        public void ModifierUnePersonne(Personne p)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Personne SET nom=@nom, prenom=@prenom, age=@age, email=@email WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", p.Id);
                    command.Parameters.AddWithValue("@nom", p.Nom);
                    command.Parameters.AddWithValue("@prenom", p.Prenom);
                    command.Parameters.AddWithValue("@age", p.Age);
                    command.Parameters.AddWithValue("@email", p.Email);
                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été modifié : " + nbModification);
                }
            }
        }

        public void SupprimerUnePersonne(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Personne WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Element(s) ayant été supprimé : " + nbSuppression);
                }
            }
        }

        public List<Personne> AfficherToutesLesPersonnes()
        {
            List<Personne> personnes = new List<Personne>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Personne;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        personnes.Add(new Personne(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetInt32("age"),
                            reader.GetString("email")
                         ));
                    }
                }
            }
            return personnes;
        }

        public Personne AfficherUnePersonneParSonId(int id)
        {
            Personne personne;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Personne WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read(); 

                    personne = new Personne(
                        reader.GetInt32("id"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetInt32("age"),
                        reader.GetString("email")
                        );      
                }
            }
            return personne;
        }

        public void CreateTablePersonne()
        {
            // Ici, je créer la connection avec la SQGB
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // La connection doit être ouverte pour transmettre une requete SQL.
                connection.Open();

                // Mes Requetes SQL
                string query = """
        CREATE TABLE IF NOT EXISTS Personne (
            id INT AUTO_INCREMENT PRIMARY KEY,
            nom VARCHAR(255),
            prenom VARCHAR(255),
            age INT,
            email VARCHAR(255) UNIQUE
        );
        """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            // La connection doit être fermé à la fin du programme.
            // La fermeture est automatique lors de l'utilisation d'un using.
            // connection.Close(); 
        }

    }
}
