using BooksRent.Models.enums;
using BooksRent.Services;
using BooksRent.Storage;

namespace BooksRent.View
{
    public partial class FormBookFilter : Form
    {

        private BookStorage _bookStorage;
        public BookFilterParams FilterParams { get; private set; }

        public FormBookFilter()
        {
            InitializeComponent();
            _bookStorage = new BookStorage();
            FilterParams = new BookFilterParams();

            _bookStorage = new BookStorage();
            var books = _bookStorage.GetAll();
            var authors = _bookStorage.GetAll()
                .Select(book => book.Author)
                .Distinct()
                .ToList();

            comboBoxAuthors.Items.Insert(0, "Все авторы");
            foreach (var author in authors)
            {
                comboBoxAuthors.Items.Add(author);
            }

            comboBoxCategory.Items.Insert(0, "");
            comboBoxCategory.DataSource = Enum.GetValues(typeof(CategoryBook));
        }


        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Получаем выбранного автора
            string selectedAuthor = comboBoxAuthors.SelectedItem?.ToString() ?? "";
            FilterParams.Author = selectedAuthor == "Все авторы" ? "" : selectedAuthor;

            // Получаем выбранную категорию
            var selectedCategory = comboBoxCategory.SelectedItem;
            if (selectedCategory is CategoryBook categoryEnum)
            {
                FilterParams.Category = categoryEnum.ToString();
            }
            else
            {
                FilterParams.Category = "";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
