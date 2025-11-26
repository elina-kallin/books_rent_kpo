using AppUsersLab1.Forms;
using AppUsersLab1.Models;
using AppUsersLab1.Services;
using AppUsersLab1.Storage;
//using Microsoft.VisualBasic.ApplicationServices;

namespace AppUsersLab1.View
{
    public partial class FormChangePassword : Form
    {
        private User User { get; set; }
        private UsersStorage _usersStorage;
        public FormChangePassword(User _user)
        {
            InitializeComponent();
            User = _user;
            _usersStorage = UsersStorage.GetInstance();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // ОБРАБОТКА ПАРОЛЯ (для всех случаев)
            if(textBoxOldPassword.Text != User.Password)
            {
                MessageBox.Show("Вы ввели неправильный текущий пароль");
            }
            if(string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                MessageBox.Show("Введите новый пароль!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxConfirmNewPassword.Text))
            {
                MessageBox.Show("Подтвердите новый пароль!");
                return;
            }
            else
            {
                if (textBoxNewPassword.Text != textBoxConfirmNewPassword.Text)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return;
                }

                // Устанавливаем новый пароль
                

                if (SecurityService.SetPassword(User, textBoxNewPassword.Text, true))
                {
                    User.Password = textBoxNewPassword.Text;
                    User.IsChangedPassword = true;
                    _usersStorage.Update(User);

                    if (User.Roles == Enums.UserRoles.Администратор)
                    {
                        Hide();
                        Form formAdmin = new FormAdmin(User.Id);
                        formAdmin.ShowDialog();
                        Close();
                    }
                    else
                    {
                        Hide();
                        Form formUser = new FormUser(User.Id);
                        formUser.ShowDialog();
                        Close();
                    }
                }
                else return;
            }

        }
    }
}
