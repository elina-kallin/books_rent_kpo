using BooksRent.DBSettings;
using BooksRent.Models;
using BooksRent.Models.enums;
using Npgsql;

namespace BooksRent.Storage
{
    public class RentCheckStorage
    {
        // Добавили book_name в запросы
        private readonly string _selectAll = @"SELECT id, book_id, user_id, fio, book_name, status_rent FROM rent_checks";
        private readonly string _selectById = @"SELECT id, book_id, user_id, fio, book_name, status_rent FROM rent_checks WHERE id = @id";

        public List<RentCheck> GetAll()
        {
            var list = new List<RentCheck>();

            using var conn = DBConfig.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(_selectAll, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(MapReaderToRentCheck(reader));
            }

            return list;
        }

        public RentCheck? GetById(string id)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(_selectById, conn);
            cmd.Parameters.AddWithValue("id", Guid.Parse(id));

            using var reader = cmd.ExecuteReader();

            if (!reader.Read()) return null;

            return MapReaderToRentCheck(reader);
        }

        public void Add(RentCheck check)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO rent_checks(id, book_id, user_id, fio, book_name, status_rent)
                VALUES (@id, @book_id, @user_id, @fio, @book_name, @status_rent)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", Guid.Parse(check.Id));
            cmd.Parameters.AddWithValue("book_id", Guid.Parse(check.BookId));
            // user_id мы храним как строку (user из файлового хранилища), поэтому не парсим:
            cmd.Parameters.AddWithValue("user_id", check.UserId ?? string.Empty);
            cmd.Parameters.AddWithValue("fio", check.FIO ?? string.Empty);
            cmd.Parameters.AddWithValue("book_name", check.BookName ?? string.Empty); // ДОБАВЛЕНО!
            cmd.Parameters.AddWithValue("status_rent", (int)check.StatusRent);

            cmd.ExecuteNonQuery();
        }

        public bool Update(RentCheck check)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"
                UPDATE rent_checks
                SET book_id = @book_id,
                    user_id = @user_id,
                    fio = @fio,
                    book_name = @book_name, -- ДОБАВЛЕНО!
                    status_rent = @status_rent
                WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", Guid.Parse(check.Id));
            cmd.Parameters.AddWithValue("book_id", Guid.Parse(check.BookId));
            cmd.Parameters.AddWithValue("user_id", check.UserId ?? string.Empty);
            cmd.Parameters.AddWithValue("fio", check.FIO ?? string.Empty);
            cmd.Parameters.AddWithValue("book_name", check.BookName ?? string.Empty); // ДОБАВЛЕНО!
            cmd.Parameters.AddWithValue("status_rent", (int)check.StatusRent);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(string id)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = "DELETE FROM rent_checks WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", Guid.Parse(id));

            return cmd.ExecuteNonQuery() > 0;
        }

        private RentCheck MapReaderToRentCheck(NpgsqlDataReader reader)
        {

            var rc = new RentCheck
            {
                Id = reader.GetGuid(0).ToString(),
                BookId = reader.GetGuid(1).ToString(),
                UserId = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                FIO = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                BookName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4), // ИНДЕКС ИЗМЕНИЛСЯ НА 4!
                StatusRent = (StatusRent)reader.GetInt32(5) // ИНДЕКС ИЗМЕНИЛСЯ НА 5!
            };

            return rc;
        }
    }
}