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

            string sql = "SELECT id, name, author, year, category FROM books";

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
                    Category = (CategoryBook)reader.GetInt32(4)
                });
            }

            return result;
        }

        public Book? GetById(string id)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"SELECT id, name, author, year, category
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
                Category = (CategoryBook)reader.GetInt32(4)
            };
        }

        public void Add(Book b)
        {
            using var conn = DBConfig.GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO books(id, name, author, year, category)
                VALUES (@id, @name, @author, @year, @category)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(b.Id));
            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@author", b.Author);
            cmd.Parameters.AddWithValue("@year", b.Year);
            cmd.Parameters.AddWithValue("@category", (int)b.Category);

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
                    category=@category
                WHERE id=@id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Guid.Parse(b.Id));
            cmd.Parameters.AddWithValue("@name", b.Name);
            cmd.Parameters.AddWithValue("@author", b.Author);
            cmd.Parameters.AddWithValue("@year", b.Year);
            cmd.Parameters.AddWithValue("@category", (int)b.Category);

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
