using AppUsersLab1.Forms;
using AppUsersLab1.Models;
using AppUsersLab1.Storage;
using AppUsersLab1.View;

namespace AppUsersLab1
{
    public partial class FormAdmin : Form
    {
        private UsersStorage _usersStorage;
        private User _currentUser;
        public string CurrentUserID { get; set; }
        public FormAdmin(string currentUserID)
        {
            InitializeComponent();
            CurrentUserID = currentUserID;
            _usersStorage = UsersStorage.GetInstance();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var currentAdmin = _usersStorage.GetById(CurrentUserID);
            List<User> users = _usersStorage.GetUsers();
            dataGridViewUsers.DataSource = null;
            // Устанавливаем новый источник
            dataGridViewUsers.DataSource = users;

            // Обновляем отображение
            dataGridViewUsers.Refresh();

            helloUsernameLabel.Text = $"Привет, {currentAdmin.Name}!";
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
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewUsers.SelectedRows[0];
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

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            // users
            if(e.TabPageIndex == 2)
            {
                Form formChangePassword = new FormChangePassword(_usersStorage.GetById(CurrentUserID));
                Close();
                if (formChangePassword.ShowDialog() == DialogResult.OK)
                {
                    Form formUser = new FormUser(CurrentUserID);
                    formUser.ShowDialog();
                }
            }
        }
    }
}
