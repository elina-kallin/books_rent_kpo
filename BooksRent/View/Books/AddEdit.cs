using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Storage;
using System.Data;


namespace BooksRent.View.Books
{
    public partial class AddEdit : Form
    {
        private BookStorage bookStorage;
        private string? _id;
        public AddEdit(string bookID)
        {
            InitializeComponent();
            bookStorage = new BookStorage();
            var books = bookStorage.GetAll();
            var authors = bookStorage.GetAll()
                .Select(book => book.Author)
                .Distinct()
                .ToList();
            foreach (var author in authors)
            {
                comboBoxAuthors.Items.Add(author);
            }

            comboBoxCategory.DataSource = Enum.GetValues(typeof(CategoryBook));
            _id = bookID;
        }

        private void AddEdit_Load(object sender, EventArgs e)
        {
            if (_id != null)
            {
                var book = bookStorage.GetById(_id);

                if (book != null)
                {
                    textBoxName.Text = book.Name;
                    comboBoxAuthors.Text = book.Author;
                    dateTimePickerYear.Value = book.Year;
                    comboBoxCategory.Text = book.Category.ToString();
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (_id == null)
            {
                var book = new Book();
                book.Name = textBoxName.Text;
                if (comboBoxAuthors.SelectedIndex != -1) book.Author = comboBoxAuthors.Text;
                else book.Author = textBoxNewAuthor.Text;
                book.Year = dateTimePickerYear.Value;
                book.StatusRent = StatusRent.Свободна;
                if (Enum.TryParse<CategoryBook>(comboBoxCategory.Text, out CategoryBook category))
                {
                    book.Category = category;
                }

                bookStorage.Add(book);
            }
            else
            {
                var book = bookStorage.GetById(_id);
                book.Name = textBoxName.Text;
                if (comboBoxAuthors.SelectedIndex != -1) book.Author = comboBoxAuthors.Text;
                else book.Author = textBoxNewAuthor.Text;
                book.Year = dateTimePickerYear.Value;
                if (Enum.TryParse<CategoryBook>(comboBoxCategory.Text, out CategoryBook category))
                {
                    book.Category = category;
                }

                bookStorage.Update(book);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
