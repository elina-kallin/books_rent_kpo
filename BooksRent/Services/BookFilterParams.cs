namespace BooksRent.Services
{
    public class BookFilterParams
    {
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Author) && string.IsNullOrEmpty(Category);
        }
    }
}
