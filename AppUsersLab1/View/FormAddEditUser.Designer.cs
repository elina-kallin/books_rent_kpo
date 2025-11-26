namespace AppUsersLab1.View
{
    partial class FormAddEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelID = new Label();
            labelName = new Label();
            labelUsername = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            textBoxUsername = new TextBox();
            numericUpDownMinLenPasswd = new NumericUpDown();
            groupBoxLimits = new GroupBox();
            checkBoxIsBlocked = new CheckBox();
            textBoxDateChangePAssword = new TextBox();
            labelDateChangePassword = new Label();
            checkBoxMarks = new CheckBox();
            checkBoxNumbers = new CheckBox();
            checkBoxLetters = new CheckBox();
            labelPeriodLifePasswd = new Label();
            numericUpDownPeriodLifePassword = new NumericUpDown();
            radioButtonUser = new RadioButton();
            radioButtonAdmin = new RadioButton();
            labelRole = new Label();
            labelMinLength = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinLenPasswd).BeginInit();
            groupBoxLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeriodLifePassword).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(18, 28);
            labelID.Name = "labelID";
            labelID.Size = new Size(27, 20);
            labelID.TabIndex = 0;
            labelID.Text = "ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(18, 62);
            labelName.Name = "labelName";
            labelName.Size = new Size(46, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Имя: ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(18, 100);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(80, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "username: ";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(122, 17);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(477, 27);
            textBoxID.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(122, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(477, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(122, 93);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(477, 27);
            textBoxUsername.TabIndex = 8;
            // 
            // numericUpDownMinLenPasswd
            // 
            numericUpDownMinLenPasswd.Location = new Point(280, 71);
            numericUpDownMinLenPasswd.Name = "numericUpDownMinLenPasswd";
            numericUpDownMinLenPasswd.Size = new Size(287, 27);
            numericUpDownMinLenPasswd.TabIndex = 9;
            // 
            // groupBoxLimits
            // 
            groupBoxLimits.BackColor = Color.LightSteelBlue;
            groupBoxLimits.Controls.Add(checkBoxIsBlocked);
            groupBoxLimits.Controls.Add(textBoxDateChangePAssword);
            groupBoxLimits.Controls.Add(labelDateChangePassword);
            groupBoxLimits.Controls.Add(checkBoxMarks);
            groupBoxLimits.Controls.Add(checkBoxNumbers);
            groupBoxLimits.Controls.Add(checkBoxLetters);
            groupBoxLimits.Controls.Add(labelPeriodLifePasswd);
            groupBoxLimits.Controls.Add(numericUpDownPeriodLifePassword);
            groupBoxLimits.Controls.Add(radioButtonUser);
            groupBoxLimits.Controls.Add(radioButtonAdmin);
            groupBoxLimits.Controls.Add(labelRole);
            groupBoxLimits.Controls.Add(labelMinLength);
            groupBoxLimits.Controls.Add(numericUpDownMinLenPasswd);
            groupBoxLimits.Location = new Point(11, 141);
            groupBoxLimits.Name = "groupBoxLimits";
            groupBoxLimits.Size = new Size(588, 275);
            groupBoxLimits.TabIndex = 10;
            groupBoxLimits.TabStop = false;
            groupBoxLimits.Text = "Ограничения на пароль";
            // 
            // checkBoxIsBlocked
            // 
            checkBoxIsBlocked.AutoSize = true;
            checkBoxIsBlocked.Location = new Point(11, 232);
            checkBoxIsBlocked.Name = "checkBoxIsBlocked";
            checkBoxIsBlocked.Size = new Size(137, 24);
            checkBoxIsBlocked.TabIndex = 24;
            checkBoxIsBlocked.Text = "Заблокировать";
            checkBoxIsBlocked.UseVisualStyleBackColor = true;
            // 
            // textBoxDateChangePAssword
            // 
            textBoxDateChangePAssword.Anchor = AnchorStyles.None;
            textBoxDateChangePAssword.Location = new Point(280, 193);
            textBoxDateChangePAssword.Name = "textBoxDateChangePAssword";
            textBoxDateChangePAssword.ReadOnly = true;
            textBoxDateChangePAssword.Size = new Size(287, 27);
            textBoxDateChangePAssword.TabIndex = 22;
            // 
            // labelDateChangePassword
            // 
            labelDateChangePassword.AutoSize = true;
            labelDateChangePassword.Location = new Point(11, 193);
            labelDateChangePassword.Name = "labelDateChangePassword";
            labelDateChangePassword.Size = new Size(232, 20);
            labelDateChangePassword.TabIndex = 21;
            labelDateChangePassword.Text = "Дата последней смены пароля: ";
            // 
            // checkBoxMarks
            // 
            checkBoxMarks.AutoSize = true;
            checkBoxMarks.Location = new Point(404, 148);
            checkBoxMarks.Name = "checkBoxMarks";
            checkBoxMarks.Size = new Size(163, 24);
            checkBoxMarks.TabIndex = 20;
            checkBoxMarks.Text = "Знаки препинания";
            checkBoxMarks.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Location = new Point(218, 148);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(73, 24);
            checkBoxNumbers.TabIndex = 19;
            checkBoxNumbers.Text = "Числа";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxLetters
            // 
            checkBoxLetters.AutoSize = true;
            checkBoxLetters.Location = new Point(11, 148);
            checkBoxLetters.Name = "checkBoxLetters";
            checkBoxLetters.Size = new Size(73, 24);
            checkBoxLetters.TabIndex = 18;
            checkBoxLetters.Text = "Буквы";
            checkBoxLetters.UseVisualStyleBackColor = true;
            // 
            // labelPeriodLifePasswd
            // 
            labelPeriodLifePasswd.AutoSize = true;
            labelPeriodLifePasswd.Location = new Point(11, 112);
            labelPeriodLifePasswd.Name = "labelPeriodLifePasswd";
            labelPeriodLifePasswd.Size = new Size(215, 20);
            labelPeriodLifePasswd.TabIndex = 17;
            labelPeriodLifePasswd.Text = "Срок действия пароля (мес.): ";
            // 
            // numericUpDownPeriodLifePassword
            // 
            numericUpDownPeriodLifePassword.Location = new Point(280, 105);
            numericUpDownPeriodLifePassword.Name = "numericUpDownPeriodLifePassword";
            numericUpDownPeriodLifePassword.Size = new Size(287, 27);
            numericUpDownPeriodLifePassword.TabIndex = 16;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Location = new Point(506, 37);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(57, 24);
            radioButtonUser.TabIndex = 15;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "user";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Location = new Point(280, 37);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(72, 24);
            radioButtonAdmin.TabIndex = 14;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "admin";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(11, 39);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(45, 20);
            labelRole.TabIndex = 13;
            labelRole.Text = "Роль:";
            // 
            // labelMinLength
            // 
            labelMinLength.AutoSize = true;
            labelMinLength.Location = new Point(11, 78);
            labelMinLength.Name = "labelMinLength";
            labelMinLength.Size = new Size(217, 20);
            labelMinLength.TabIndex = 11;
            labelMinLength.Text = "Минимальная длина пароля: ";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.CornflowerBlue;
            buttonOK.Location = new Point(475, 422);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(124, 42);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "Сохранить";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 474);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxLimits);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(labelUsername);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Name = "FormAddEditUser";
            Text = "Данные пользователя";
            Load += FormAddEditUser_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinLenPasswd).EndInit();
            groupBoxLimits.ResumeLayout(false);
            groupBoxLimits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeriodLifePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelName;
        private Label labelUsername;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxUsername;
        private NumericUpDown numericUpDownMinLenPasswd;
        private GroupBox groupBoxLimits;
        private Label labelMinLength;
        private Label labelRole;
        private RadioButton radioButtonUser;
        private RadioButton radioButtonAdmin;
        private Label labelPeriodLifePasswd;
        private NumericUpDown numericUpDownPeriodLifePassword;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxLetters;
        private CheckBox checkBoxMarks;
        private Label labelDateChangePassword;
        private TextBox textBoxDateChangePAssword;
        private CheckBox checkBoxIsBlocked;
        private Button buttonOK;
    }
}