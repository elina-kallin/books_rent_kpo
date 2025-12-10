using BooksRent.Storage;

namespace BooksRent.View.Books
{
    public partial class AddEditRent : Form
    {

        private BookStorage bookStorage;

        private string? _id;
        public AddEditRent(string id)
        {
            InitializeComponent();
            bookStorage = new BookStorage();
            _id = id;
        }

        private void AddEditRent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var book = bookStorage.GetById(_id);
            if(_id != null)
            {
                textBoxBookName.Text = book.Name;
            }
        }
    }
}
