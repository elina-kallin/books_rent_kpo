using BooksRent.Models.enums;
using BooksRent.Models;
using Npgsql;
using BooksRent.DBSettings;

namespace BooksRent.Storage
{
    public class BookStorage
    {
        public List<Book> GetAll()
        {
            var result = new List<Book>();

            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = "SELECT id, name, author, year, category, status_rent FROM books";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Book
                {
                    Id = reader.GetGuid(0).ToString(),
                    Name = reader.GetString(1),
                    Author = reader.GetString(2),
                    Year = reader.GetDateTime(3),
                    Category = (CategoryBook)reader.GetInt32(4),
                    StatusRent = ((StatusRent)reader.GetInt32(5))
                });
            }

            return result;
        }

        public Book? GetById(string id)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"SELECT id, name, author, year, category, status_rent
                           FROM books
                           WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(id));

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Book
            {
                Id = reader.GetGuid(0).ToString(),
                Name = reader.GetString(1),
                Author = reader.GetString(2),
                Year = reader.GetDateTime(3),
                Category = (CategoryBook)reader.GetInt32(4),
                StatusRent = ((StatusRent)reader.GetInt32(5))
            };
        }

        public void Add(Book b)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO books(id, name, author, year, category, status_rent)
                VALUES (@id, @name, @author, @year, @category, @status_rent)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(b.Id));
            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@author", b.Author);
            cmd.Parameters.AddWithValue("@year", b.Year);
            cmd.Parameters.AddWithValue("@category", (int)b.Category);
            cmd.Parameters.AddWithValue("@status_rent", (int)b.StatusRent);

            cmd.ExecuteNonQuery();
        }

        public bool Update(Book b)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"
                UPDATE books
                SET name=@name,
                    author=@author,
                    year=@year,
                    category=@category,
                    status_rent=@status_rent
                WHERE id=@id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(b.Id));
            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@author", b.Author);
            cmd.Parameters.AddWithValue("@year", b.Year);
            cmd.Parameters.AddWithValue("@category", (int)b.Category);
            cmd.Parameters.AddWithValue("@status_rent", (int)b.StatusRent);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(string id)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = "DELETE FROM books WHERE id=@id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(id));

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
