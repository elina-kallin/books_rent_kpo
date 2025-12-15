using Npgsql;

namespace BooksRent.DBSettings
{
    public class DBConfig
    {
        private static string _connectionString =
            "Host=localhost;Port=5432;Database=books_rent;Username=postgres;Password=postgres";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
