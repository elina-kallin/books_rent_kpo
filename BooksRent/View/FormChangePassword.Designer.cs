namespace AppUsersLab1.View
{
    partial class FormChangePassword
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
            groupBoxPasswords = new GroupBox();
            textBoxConfirmNewPassword = new TextBox();
            textBoxOldPassword = new TextBox();
            labelConfirmNewPassword = new Label();
            labelConfirmOldPassword = new Label();
            textBoxNewPassword = new TextBox();
            labelNewPassword = new Label();
            buttonOK = new Button();
            groupBoxPasswords.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPasswords
            // 
            groupBoxPasswords.BackColor = SystemColors.ActiveCaption;
            groupBoxPasswords.Controls.Add(textBoxConfirmNewPassword);
            groupBoxPasswords.Controls.Add(textBoxOldPassword);
            groupBoxPasswords.Controls.Add(labelConfirmNewPassword);
            groupBoxPasswords.Controls.Add(labelConfirmOldPassword);
            groupBoxPasswords.Controls.Add(textBoxNewPassword);
            groupBoxPasswords.Controls.Add(labelNewPassword);
            groupBoxPasswords.Location = new Point(12, 12);
            groupBoxPasswords.Name = "groupBoxPasswords";
            groupBoxPasswords.Size = new Size(546, 158);
            groupBoxPasswords.TabIndex = 6;
            groupBoxPasswords.TabStop = false;
            groupBoxPasswords.Text = "Смена пароля";
            // 
            // textBoxConfirmNewPassword
            // 
            textBoxConfirmNewPassword.Anchor = AnchorStyles.None;
            textBoxConfirmNewPassword.Location = new Point(244, 111);
            textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            textBoxConfirmNewPassword.PasswordChar = '*';
            textBoxConfirmNewPassword.Size = new Size(287, 27);
            textBoxConfirmNewPassword.TabIndex = 12;
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.Anchor = AnchorStyles.None;
            textBoxOldPassword.Location = new Point(244, 34);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.PasswordChar = '*';
            textBoxOldPassword.Size = new Size(287, 27);
            textBoxOldPassword.TabIndex = 9;
            // 
            // labelConfirmNewPassword
            // 
            labelConfirmNewPassword.AutoSize = true;
            labelConfirmNewPassword.Location = new Point(9, 118);
            labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            labelConfirmNewPassword.Size = new Size(211, 20);
            labelConfirmNewPassword.TabIndex = 11;
            labelConfirmNewPassword.Text = "Подтвердите новый пароль: ";
            // 
            // labelConfirmOldPassword
            // 
            labelConfirmOldPassword.AutoSize = true;
            labelConfirmOldPassword.Location = new Point(5, 41);
            labelConfirmOldPassword.Name = "labelConfirmOldPassword";
            labelConfirmOldPassword.Size = new Size(123, 20);
            labelConfirmOldPassword.TabIndex = 3;
            labelConfirmOldPassword.Text = "Старый пароль: ";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Anchor = AnchorStyles.None;
            textBoxNewPassword.Location = new Point(244, 72);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(287, 27);
            textBoxNewPassword.TabIndex = 10;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(9, 79);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(119, 20);
            labelNewPassword.TabIndex = 4;
            labelNewPassword.Text = "Новый пароль: ";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(429, 192);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(129, 38);
            buttonOK.TabIndex = 7;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 249);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxPasswords);
            Name = "FormChangePassword";
            Text = "FormChangePassword";
            groupBoxPasswords.ResumeLayout(false);
            groupBoxPasswords.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPasswords;
        private TextBox textBoxConfirmNewPassword;
        private TextBox textBoxOldPassword;
        private Label labelConfirmNewPassword;
        private Label labelConfirmOldPassword;
        private TextBox textBoxNewPassword;
        private Label labelNewPassword;
        private Button buttonOK;
    }
}