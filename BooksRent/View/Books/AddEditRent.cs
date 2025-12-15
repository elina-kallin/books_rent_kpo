using AppUsersLab1.Storage;
using BooksRent.Models;
using BooksRent.Models.enums;
using BooksRent.Storage;

namespace BooksRent.View.Books
{
    public partial class AddEditRent : Form
    {

        private BookStorage bookStorage;
        private RentCheckStorage rentCheckStorage;
        private UsersStorage usersStorage;

        private string? _id;
        private string? _userId;
        public AddEditRent(string bookId, string currentUserId)
        {
            InitializeComponent();
            bookStorage = new BookStorage();
            rentCheckStorage = new RentCheckStorage();
            _id = bookId;
            _userId = currentUserId;
            usersStorage = UsersStorage.GetInstance();
        }

        private void AddEditRent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var book = bookStorage.GetById(_id);
            if(book.StatusRent == StatusRent.Арендована)
            {
                MessageBox.Show("Книга арендована, ее нельзя арендовать");
                return;
            }
            if (_id != null)
            {
                textBoxBookName.Text = book.Name;
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            var book = bookStorage.GetById(_id);
            if (book.StatusRent == StatusRent.Арендована)
            {
                MessageBox.Show("Книга арендована, ее нельзя арендовать");
                return;
            }
            book.StatusRent = StatusRent.Арендована;
            bookStorage.Update(book);

            var newRent = new RentCheck
            {
                BookId = _id,
                UserId = _userId,
                BookName = book.Name,
                FIO = usersStorage.GetById(_userId).Name,
                StatusRent = book.StatusRent,
            };

            rentCheckStorage.Add(newRent);

            MessageBox.Show("Чек создался. Вы можете найти его во вкладке 'Арендные чеки'");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
