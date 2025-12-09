using BooksRent.Models.enums;
using System.ComponentModel;

namespace BooksRent.Models
{
    public class Book
    {
        [Browsable(false)]
        [DisplayName("Id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("Название")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Автор")]
        public string Author { get; set; } = string.Empty;

        [DisplayName("Год издания")]
        public DateTime Year { get; set; } = DateTime.Now;

        [DisplayName("Категория")]
        public CategoryBook Category { get; set; } = CategoryBook.Физика;
    }
}
