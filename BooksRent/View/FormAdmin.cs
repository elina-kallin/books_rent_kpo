using AppUsersLab1.Forms;
using AppUsersLab1.Models;
using AppUsersLab1.Storage;
using AppUsersLab1.View;
using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Services;
using BooksRent.Storage;
using BooksRent.View;
using BooksRent.View.Books;

namespace AppUsersLab1
{
    public partial class FormAdmin : Form
    {
        private UsersStorage _usersStorage;
        private BookStorage _booksStorage;
        private RentCheckStorage _rentStorage;
        private User _currentUser;
        private BookFilterParams _bookFilter;
        public string CurrentUserID { get; set; }
        public FormAdmin(string currentUserID)
        {
            InitializeComponent();
            CurrentUserID = currentUserID;
            _usersStorage = UsersStorage.GetInstance();
            _booksStorage = new BookStorage();
            _rentStorage = new RentCheckStorage();
            _bookFilter = new BookFilterParams();

            выдатьКнигуToolStripMenuItem.Enabled = false;
            принятьКнигуToolStripMenuItem.Enabled = false;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var currentAdmin = _usersStorage.GetById(CurrentUserID);
            List<User> users = _usersStorage.GetUsers();
            dataGridViewUsersAdmin.DataSource = null;
            // Устанавливаем новый источник
            dataGridViewUsersAdmin.DataSource = users;

            // Обновляем отображение
            dataGridViewUsersAdmin.Refresh();

            helloUsernameLabel.Text = $"Привет, {currentAdmin.Name}!";

            List<Book> books = _booksStorage.GetFilteredBooks(
                _bookFilter.Author,
                _bookFilter.Category);

            dataGridViewBooksAdmin.DataSource = books;
            dataGridViewBooksAdmin.Columns["Year"].DefaultCellStyle.Format = "dd MMMM yyyy г.";
            dataGridViewBooksAdmin.Refresh();

            List<RentCheck> checks = _rentStorage.GetAll();
            dataGridViewRentsAdmin.DataSource = checks;
            dataGridViewRentsAdmin.Refresh();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEdit = new FormAddEditUser(null, CurrentUserID);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void редактироватьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = GetUserIdFromRow();
            if (user != null)
            {
                var userId = user.Id;
                var formEdit = new FormAddEditUser(userId, CurrentUserID);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Обновляем только если были изменения
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя!");
            }
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = GetUserIdFromRow();
            if (user != null)
            {
                // Запрещаем удаление самого себя
                if (user.Id == CurrentUserID)
                {
                    MessageBox.Show("Нельзя удалить самого себя!");
                    return;
                }

                // Запрещаем удаление последнего администратора
                var adminsCount = _usersStorage.GetUsers().Count(u => u.Roles == Enums.UserRoles.Администратор);
                if (user.Roles == Enums.UserRoles.Администратор && adminsCount <= 1)
                {
                    MessageBox.Show("Нельзя удалить последнего администратора!");
                    return;
                }

                // Подтверждение удаления
                var result = MessageBox.Show($"Вы уверены, что хотите удалить пользователя {user.Name}?",
                                           "Подтверждение удаления",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _usersStorage.Delete(user);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя!");
            }
        }

        private User? GetUserIdFromRow()
        {
            if (dataGridViewUsersAdmin.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewUsersAdmin.SelectedRows[0];
                var user = selectedRow.DataBoundItem as User;
                return user;
            }
            return null;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutProgram = new FormAboutProgram();
            aboutProgram.ShowDialog();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formChangePassword = new FormChangePassword(_usersStorage.GetById(CurrentUserID));
            //Close();
            if (formChangePassword.ShowDialog() == DialogResult.OK)
            {
                Form formUser = new FormUser(CurrentUserID);
                formUser.ShowDialog();
            }
        }

        private void создатьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAddBook = new AddEdit(null);
            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetBookId();
            Form formAddBook = new AddEdit(id);
            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private string GetBookId()
        {
            if (dataGridViewBooksAdmin.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewBooksAdmin.SelectedRows[0];
                var book = selectedRow.DataBoundItem as Book;
                return book.Id;
            }
            return null;
        }


        private string GetCheckId()
        {
            if (dataGridViewRentsAdmin.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewRentsAdmin.SelectedRows[0];
                var check = selectedRow.DataBoundItem as RentCheck;
                return check.Id;
            }
            return null;
        }

        private void удалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = GetBookId();
            try
            {
                _booksStorage.Delete(id);
                MessageBox.Show("Удалилось, все норм");
            }
            catch (Exception)
            {
                MessageBox.Show("по какой-то причине не удалось сделать");
            }
            LoadData();
        }

        private void выдатьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkId = GetCheckId();
            var check = _rentStorage.GetById(checkId);

            var book = _booksStorage.GetById(check.BookId);

            if (book != null)
            {
                book.StatusRent = StatusRent.Выдана;
                _booksStorage.Update(book);

                var newBook = _booksStorage.GetById(check.BookId);

                check.StatusRent = newBook.StatusRent;
                _rentStorage.Update(check);
            }
            else
            {
                MessageBox.Show("Книги почему-то нет такой");
            }

            MessageBox.Show("Книга выдана");
            LoadData();

        }

        private void принятьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkId = GetCheckId();
            var check = _rentStorage.GetById(checkId);

            var book = _booksStorage.GetById(check.BookId);

            if (book != null)
            {
                book.StatusRent = StatusRent.Свободна;
                _booksStorage.Update(book);

                var newBook = _booksStorage.GetById(check.BookId);

                check.StatusRent = newBook.StatusRent;
                _rentStorage.Update(check);
            }
            else
            {
                MessageBox.Show("Книги почему-то нет такой");
            }

            MessageBox.Show("Книга вернулась в библиотеку!");
            LoadData();
        }

        private void dataGridViewRentsAdmin_SelectionChanged(object sender, EventArgs e)
        {
            // Сбрасываем состояние меню
            выдатьКнигуToolStripMenuItem.Enabled = false;
            принятьКнигуToolStripMenuItem.Enabled = false;

            if (dataGridViewRentsAdmin.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewRentsAdmin.SelectedRows[0];
                var check = selectedRow.DataBoundItem as RentCheck;

                if (check != null)
                {
                    // Получаем книгу по BookId из чека
                    var book = _booksStorage.GetById(check.BookId);

                    if (book != null)
                    {
                        if (book.StatusRent == StatusRent.Арендована)
                        {
                            выдатьКнигуToolStripMenuItem.Enabled = true;
                        }
                        else if (book.StatusRent == StatusRent.Выдана)
                        {
                            принятьКнигуToolStripMenuItem.Enabled = true;
                        }
                    }
                }
            }
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

        private void сброситьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bookFilter.Author = "";
            _bookFilter.Category = "";
            LoadData();
        }
    }
}
