using AppUsersLab1.Storage;
using AppUsersLab1.View;
using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Services;
using BooksRent.Storage;
using BooksRent.View;
using BooksRent.View.Books;

namespace AppUsersLab1.Forms
{
    public partial class FormUser : Form
    {
        private string CurrentUserID;
        private UsersStorage _usersStorage;
        private BookStorage _bookStorage;
        private RentCheckStorage _rentCheckStorage;
        private BookFilterParams _bookFilter;
        public FormUser(string currentUserID)
        {
            InitializeComponent();
            CurrentUserID = currentUserID;
            _usersStorage = UsersStorage.GetInstance();
            statusStripHelloUser.Text = $"Привет, {_usersStorage.GetById(CurrentUserID)}!";
            _bookStorage = new BookStorage();
            _rentCheckStorage = new RentCheckStorage();
            _bookFilter = new BookFilterParams();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formChangePassword = new FormChangePassword(_usersStorage.GetById(CurrentUserID));
            Close();
            if (formChangePassword.ShowDialog() == DialogResult.OK)
            {
                Form formUser = new FormUser(CurrentUserID);
                formUser.ShowDialog();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutProgram = new FormAboutProgram();
            aboutProgram.ShowDialog();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            var currentUser = _usersStorage.GetById(CurrentUserID);
            statusStripHelloUser.Text = $"Здравствуй, {currentUser.Name}!";

            LoadData();
        }

        private void LoadData()
        {
            List<Book> books = _bookStorage.GetFilteredBooks(
                _bookFilter.Author,
                _bookFilter.Category);
            dataGridViewBooksUser.DataSource = books;
            dataGridViewBooksUser.Refresh();


            List<RentCheck> checks = _rentCheckStorage.GetAll().FindAll(x => x.UserId == CurrentUserID).ToList();
            dataGridViewRentsUser.DataSource = checks;
            dataGridViewRentsUser.Refresh();
        }

        private string? GetIdBook()
        {
            if (dataGridViewBooksUser.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewBooksUser.SelectedRows[0];
                var book = selectedRow.DataBoundItem as Book;

                return book.Id;
            }
            return null;
        }

        private void арендоватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookId = GetIdBook();
            var book = _bookStorage.GetById(bookId);
            if (book.StatusRent == StatusRent.Арендована || book.StatusRent == StatusRent.Выдана)
            {
                MessageBox.Show("Книга не свободна, вы не можете ее арендовать");
                return;
            }
            Form rent = new AddEditRent(bookId, CurrentUserID);
            if (rent.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void очиститьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bookFilter.Author = "";
            _bookFilter.Category = "";
            LoadData();
        }

        private void фильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formFilter = new FormBookFilter();
            if (formFilter.ShowDialog() == DialogResult.OK)
            {
                var filterForm = (FormBookFilter)formFilter;
                _bookFilter = filterForm.FilterParams;
                LoadData();
            }
        }
    }
}
