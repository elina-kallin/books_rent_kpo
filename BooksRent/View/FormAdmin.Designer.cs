namespace AppUsersLab1
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            helloUsernameLabel = new ToolStripStatusLabel();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabControl = new TabControl();
            menuStrip1 = new MenuStrip();
            добавитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            редактироватьПользователяToolStripMenuItem = new ToolStripMenuItem();
            удалитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewUsers = new DataGridView();
            statusStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { helloUsernameLabel });
            statusStrip1.Location = new Point(0, 567);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1175, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // helloUsernameLabel
            // 
            helloUsernameLabel.Name = "helloUsernameLabel";
            helloUsernameLabel.Size = new Size(0, 16);
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1167, 534);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewUsers);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1167, 534);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1175, 567);
            tabControl.TabIndex = 3;
            tabControl.Selected += tabControl_Selected;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьПользователяToolStripMenuItem, редактироватьПользователяToolStripMenuItem, удалитьПользователяToolStripMenuItem, сменитьПарольToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1161, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            добавитьПользователяToolStripMenuItem.Size = new Size(190, 24);
            добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            добавитьПользователяToolStripMenuItem.Click += добавитьПользователяToolStripMenuItem_Click;
            // 
            // редактироватьПользователяToolStripMenuItem
            // 
            редактироватьПользователяToolStripMenuItem.Name = "редактироватьПользователяToolStripMenuItem";
            редактироватьПользователяToolStripMenuItem.Size = new Size(225, 24);
            редактироватьПользователяToolStripMenuItem.Text = "Редактировать пользователя";
            редактироватьПользователяToolStripMenuItem.Click += редактироватьПользователяToolStripMenuItem_Click;
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            удалитьПользователяToolStripMenuItem.Size = new Size(179, 24);
            удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            удалитьПользователяToolStripMenuItem.Click += удалитьПользователяToolStripMenuItem_Click;
            // 
            // сменитьПарольToolStripMenuItem
            // 
            сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            сменитьПарольToolStripMenuItem.Size = new Size(138, 24);
            сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            сменитьПарольToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.Black;
            dataGridViewUsers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewUsers.GridColor = SystemColors.InfoText;
            dataGridViewUsers.Location = new Point(3, 31);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1161, 500);
            dataGridViewUsers.TabIndex = 3;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1175, 589);
            Controls.Add(tabControl);
            Controls.Add(statusStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Админ панель";
            WindowState = FormWindowState.Maximized;
            Load += FormAdmin_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel helloUsernameLabel;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl;
        private DataGridView dataGridViewUsers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private ToolStripMenuItem редактироватьПользователяToolStripMenuItem;
        private ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem;
    }
}
