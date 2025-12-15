using AppUsersLab1.Enums;
using AppUsersLab1.Models;
using AppUsersLab1.Storage;

namespace AppUsersLab1.View
{
    public partial class FormAddEditUser : Form
    {
        private string _id;
        private UsersStorage _usersStorage;
        private string CurrentUserID;
        private User _currentUser;

        public FormAddEditUser(string id, string currentUserID)
        {
            InitializeComponent();
            _usersStorage = UsersStorage.GetInstance();
            CurrentUserID = currentUserID;
            _id = id;
            _currentUser = _usersStorage.GetById(CurrentUserID);
        }

        private void LoadData()
        {
            if (_currentUser?.Roles == UserRoles.Пользователь)
            {
                // Обычный пользователь - может менять только свой пароль
                groupBoxLimits.Enabled = false;
            }

            if (_id != null)
            {
                // РЕДАКТИРОВАНИЕ существующего пользователя
                var user = _usersStorage.GetById(_id);

                if (user.Roles == UserRoles.Администратор & user.Id == CurrentUserID)
                {
                    checkBoxIsBlocked.Checked = false;
                    radioButtonAdmin.Enabled = false;
                    radioButtonUser.Enabled = false;
                }

                textBoxName.TabIndex = 0;
                textBoxID.Text = user.Id;
                textBoxName.Text = user.Name;
                textBoxUsername.Text = user.UserName;
                numericUpDownMinLenPasswd.Value = user.MinPasswordLength;
                numericUpDownPeriodLifePassword.Value = user.PeriodLifePassword;
                checkBoxLetters.Checked = user.LettersRequire;
                checkBoxNumbers.Checked = user.NumbersRequire;
                checkBoxMarks.Checked = user.PunktMarksRequire;
                textBoxDateChangePAssword.Text = user.DateSetPassword.ToString("dd.MM.yyyy");
                checkBoxIsBlocked.Checked = user.IsBlocked;

                if (user.Roles == UserRoles.Администратор)
                {
                    radioButtonAdmin.Checked = true;
                }
                else
                {
                    radioButtonUser.Checked = true;
                }

                // ОСОБЫЕ ПРАВИЛА ДЛЯ РЕДАКТИРОВАНИЯ САМОГО СЕБЯ
                if (user.Id == CurrentUserID && _currentUser?.Roles == UserRoles.Администратор)
                {
                    groupBoxLimits.Enabled = false;
                }
            }
            else
            {
                radioButtonUser.Checked = true; // По умолчанию создаем пользователя
            }
        }

        private void FormAddEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;

            if (_id != null)
            {
                // РЕДАКТИРОВАНИЕ существующего пользователя
                var user = _usersStorage.GetById(_id);
                if (user != null)
                {
                    user.Name = textBoxName.Text;
                    user.UserName = textBoxUsername.Text;


                    user.MinPasswordLength = (int)numericUpDownMinLenPasswd.Value;
                    user.PeriodLifePassword = (int)numericUpDownPeriodLifePassword.Value;
                    user.LettersRequire = checkBoxLetters.Checked;
                    user.NumbersRequire = checkBoxNumbers.Checked;
                    user.PunktMarksRequire = checkBoxMarks.Checked;
                    user.IsBlocked = checkBoxIsBlocked.Checked;
                    user.Roles = radioButtonAdmin.Checked ? UserRoles.Администратор : UserRoles.Пользователь;

                    this.DialogResult = DialogResult.OK;
                    Close();

                    

                    var result = _usersStorage.Update(user);
                    if (result != null)
                    {
                        //    if (!string.IsNullOrEmpty(textBoxNewPassword.Text))
                        //    {
                        //        MessageBox.Show($"Пароль пользователя {user.UserName} успешно изменен!");
                        //    }
                        //    else
                        //    {
                        MessageBox.Show($"Данные пользователя {user.UserName} обновлены!");
                    }
                    this.DialogResult = DialogResult.OK;
                    Close();
                    //}
                }
            }
            else
            {
                // СОЗДАНИЕ нового пользователя (только для администратора)
                if (_currentUser?.Roles != UserRoles.Администратор)
                {
                    MessageBox.Show("Только администратор может создавать пользователей!");
                    return;
                }

                var newUser = new User
                {
                    Name = textBoxName.Text,
                    UserName = textBoxUsername.Text,
                    MinPasswordLength = (int)numericUpDownMinLenPasswd.Value,
                    PeriodLifePassword = (int)numericUpDownPeriodLifePassword.Value,
                    LettersRequire = checkBoxLetters.Checked,
                    NumbersRequire = checkBoxNumbers.Checked,
                    PunktMarksRequire = checkBoxMarks.Checked,
                    IsBlocked = false, // Новый пользователь всегда разблокирован
                    Roles = radioButtonAdmin.Checked ? UserRoles.Администратор : UserRoles.Пользователь,
                    //HashedPassword = "", // Пустой пароль для нового пользователя
                    Password = "",
                    DateSetPassword = DateTime.Now
                };

                var result = _usersStorage.Add(newUser);
                if (result != null)
                {
                    MessageBox.Show($"Добавлен пользователь {newUser.UserName} с пустым паролем!\nПользователь должен будет установить пароль при первом входе.");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите имя пользователя!");
                textBoxName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Введите логин!");
                textBoxUsername.Focus();
                return false;
            }

            // Проверка уникальности username
            if (_id == null && !_usersStorage.UniqueUsername(textBoxUsername.Text))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                textBoxUsername.Focus();
                return false;
            }

            //// Проверка паролей
            //if (!string.IsNullOrEmpty(textBoxNewPassword.Text))
            //{
            //    if (textBoxNewPassword.Text != textBoxConfirmNewPassword.Text)
            //    {
            //        MessageBox.Show("Пароли не совпадают!");
            //        textBoxConfirmNewPassword.Focus();
            //        return false;
            //    }
            //}

            //// Проверка минимальной длины пароля
            //if (numericUpDownMinLenPasswd.Value < 0)
            //{
            //    MessageBox.Show("Минимальная длина пароля не может быть отрицательной!");
            //    return false;
            //}

            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        // Показываем/скрываем символы пароля
    }
}