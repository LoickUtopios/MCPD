using MySql.Data.MySqlClient;

namespace CorrectionExercice2.Class.DbManager
{
    internal class DataConnection
    {
        private static readonly string connectionString = "Server=localhost;Database=ado;Uid=root;Pwd=";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);

        }
    }
}
