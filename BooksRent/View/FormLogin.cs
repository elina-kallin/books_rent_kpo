
using AppUsersLab1.Models;
using AppUsersLab1.Services;
using AppUsersLab1.Storage;
using AppUsersLab1.View;

namespace AppUsersLab1.Forms
{
    public partial class FormLogin : Form
    {
        private UsersStorage _usersStorage;
        public string CurrentUserID;
        private User _user;
        public FormLogin()
        {
            InitializeComponent();
            _usersStorage = UsersStorage.GetInstance();
        }

        int counter = 0;


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }

            var user = _usersStorage.GetByUsername(username);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            if (user.IsBlocked)
            {
                MessageBox.Show("Вы заблокированы и не можете войти в систему");
                return;
            }

            if (!SecurityService.CheckHashPassword(user, password))
            {
                counter++;
                if (counter < 3)
                {
                    MessageBox.Show($"Неверный пароль. Осталось попыток: {3 - counter}");
                    return;
                }
                else
                {
                    MessageBox.Show($"Неверный пароль введён 3 раза. Программа закроется");
                    Close();
                    return;
                }
            }

            counter = 0;
            CurrentUserID = user.Id;

            if (user.IsChangedPassword)
            {
                if (user.Roles == Enums.UserRoles.Администратор)
                {
                    Hide();
                    Form formAdmin = new FormAdmin(CurrentUserID);
                    formAdmin.ShowDialog();
                    Close();
                }
                else
                {
                    Hide();
                    Form formUser = new FormUser(CurrentUserID);
                    formUser.ShowDialog();
                    Close();
                }
            }

            else
            {
                if (user.Roles == Enums.UserRoles.Администратор)
                {

                    Hide();
                    Form formChangePassword = new FormChangePassword(user);
                    if (formChangePassword.ShowDialog() == DialogResult.OK)
                    {
                        Form formUser = new FormUser(CurrentUserID);
                        formUser.ShowDialog();
                        Close();
                    }
                }
                else
                {
                    Hide();
                    Form formChangePassword = new FormChangePassword(user);
                    if (formChangePassword.ShowDialog() == DialogResult.OK)
                    {
                        Form formUser = new FormUser(CurrentUserID);
                        formUser.ShowDialog();
                        Close();
                    }
                }
                textBoxUserName.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
            }
        }
    }
}
