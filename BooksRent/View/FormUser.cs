using AppUsersLab1.Storage;
using AppUsersLab1.View;

namespace AppUsersLab1.Forms
{
    public partial class FormUser : Form
    {
        private string CurrentUserID;
        private UsersStorage _usersStorage;
        public FormUser(string currentUserID)
        {
            InitializeComponent();
            CurrentUserID = currentUserID;
            _usersStorage = UsersStorage.GetInstance();
            statusStripHelloUser.Text = $"Привет, {_usersStorage.GetById(CurrentUserID)}!";
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
            labelProgram.Text = $"Привет, {currentUser.Name}!\nСовсем скоро тут появится программа :D";
        }
    }
}
