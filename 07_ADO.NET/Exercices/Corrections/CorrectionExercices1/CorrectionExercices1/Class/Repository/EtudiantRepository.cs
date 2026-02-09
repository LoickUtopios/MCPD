using MySql.Data.MySqlClient;
using CorrectionExercices1.Class.Model;

namespace CorrectionExercices1.Class.Repository
{
    internal class EtudiantRepository
    {
        static string connectionString = "Server=localhost;Uid=root;Pwd=;Database=ado";

        public static void AjouterUnEtudiant(Etudiant e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Etudiant (nom, prenom, date_de_naissance, email) " +
                    $"VALUES (@nom,@prenom,@dob,@email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@dob", e.DateDeNaissance);
                    command.Parameters.AddWithValue("@email", e.Email);
                    int nbInsertion = command.ExecuteNonQuery();
                    Console.WriteLine("Etudiant(s) ayant été inséré : " + nbInsertion);
                }
            }
        }

        public static void ModifierUnEtudiant(Etudiant e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Etudiant SET nom=@nom, prenom=@prenom, date_de_naissance=@dob, email=@email WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", e.Id);
                    command.Parameters.AddWithValue("@nom", e.Nom);
                    command.Parameters.AddWithValue("@prenom", e.Prenom);
                    command.Parameters.AddWithValue("@dob", e.DateDeNaissance);
                    command.Parameters.AddWithValue("@email", e.Email);
                    int nbModification = command.ExecuteNonQuery();
                    Console.WriteLine("Etudiant(s) ayant été modifié : " + nbModification);
                }
            }
        }

        public static void SupprimerUnEtudiant(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Etudiant WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int nbSuppression = command.ExecuteNonQuery();
                    Console.WriteLine("Etudiant(s) ayant été supprimé : " + nbSuppression);
                }
            }
        }

        public static List<Etudiant> RecupererToutLesEtudiants()
        {
            List<Etudiant> Etudiants = new List<Etudiant>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Etudiants.Add(new Etudiant(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("date_de_naissance"),
                            reader.GetString("email")
                         ));
                    }
                }
            }
            return Etudiants;
        }

        public static Etudiant RecupereUnEtudiantParSonId(int id)
        {
            Etudiant etudiant;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant WHERE id=@id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        etudiant = new Etudiant(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("date_de_naissance"),
                            reader.GetString("email")
                            );
                    }
                    else
                        etudiant = null;

                }
            }
            return etudiant;
        }

        public static List<Etudiant> RecupereToutLesEtudiantsParNomOuPrenom(string saisie)
        {
            List<Etudiant> etudiants= new List<Etudiant>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Etudiant WHERE nom LIKE '%@saisie%' OR prenom LIKE '%@saisie%';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@saisie", saisie);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        etudiants.Add(new Etudiant(
                            reader.GetInt32("id"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetDateTime("date_de_naissance"),
                            reader.GetString("email")
                        ));
                    }
                }
            }
            return etudiants;
        }

        public static void CreerTableEtudiant()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = """
                                CREATE TABLE IF NOT EXISTS Etudiant (
                                    id INT AUTO_INCREMENT PRIMARY KEY,
                                    nom VARCHAR(255),
                                    prenom VARCHAR(255),
                                    date_de_naissance DATETIME,
                                    email VARCHAR(255) UNIQUE
                                );
                                """;

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
