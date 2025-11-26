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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            menuStrip1 = new MenuStrip();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            опреацииСПользователямиToolStripMenuItem = new ToolStripMenuItem();
            добавитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            редактироватьПользователяToolStripMenuItem = new ToolStripMenuItem();
            удалитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewUsers = new DataGridView();
            statusStrip1 = new StatusStrip();
            helloUsernameLabel = new ToolStripStatusLabel();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, пользователиToolStripMenuItem, опреацииСПользователямиToolStripMenuItem, сменитьПарольToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(122, 24);
            пользователиToolStripMenuItem.Text = "Пользователи";
            пользователиToolStripMenuItem.Click += пользователиToolStripMenuItem_Click;
            // 
            // опреацииСПользователямиToolStripMenuItem
            // 
            опреацииСПользователямиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьПользователяToolStripMenuItem, редактироватьПользователяToolStripMenuItem, удалитьПользователяToolStripMenuItem });
            опреацииСПользователямиToolStripMenuItem.Name = "опреацииСПользователямиToolStripMenuItem";
            опреацииСПользователямиToolStripMenuItem.Size = new Size(226, 24);
            опреацииСПользователямиToolStripMenuItem.Text = "Операции с пользователями";
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            добавитьПользователяToolStripMenuItem.Size = new Size(294, 26);
            добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            добавитьПользователяToolStripMenuItem.Click += добавитьПользователяToolStripMenuItem_Click;
            // 
            // редактироватьПользователяToolStripMenuItem
            // 
            редактироватьПользователяToolStripMenuItem.Name = "редактироватьПользователяToolStripMenuItem";
            редактироватьПользователяToolStripMenuItem.Size = new Size(294, 26);
            редактироватьПользователяToolStripMenuItem.Text = "Редактировать пользователя";
            редактироватьПользователяToolStripMenuItem.Click += редактироватьПользователяToolStripMenuItem_Click;
            // 
            // удалитьПользователяToolStripMenuItem
            // 
            удалитьПользователяToolStripMenuItem.Name = "удалитьПользователяToolStripMenuItem";
            удалитьПользователяToolStripMenuItem.Size = new Size(294, 26);
            удалитьПользователяToolStripMenuItem.Text = "Удалить пользователя";
            удалитьПользователяToolStripMenuItem.Click += удалитьПользователяToolStripMenuItem_Click;
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
            dataGridViewUsers.Location = new Point(0, 28);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(800, 422);
            dataGridViewUsers.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { helloUsernameLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // helloUsernameLabel
            // 
            helloUsernameLabel.Name = "helloUsernameLabel";
            helloUsernameLabel.Size = new Size(0, 16);
            // 
            // сменитьПарольToolStripMenuItem
            // 
            сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            сменитьПарольToolStripMenuItem.Size = new Size(138, 24);
            сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            сменитьПарольToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridViewUsers);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Админ панель";
            WindowState = FormWindowState.Maximized;
            Load += FormAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private DataGridView dataGridViewUsers;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel helloUsernameLabel;
        private ToolStripMenuItem опреацииСПользователямиToolStripMenuItem;
        private ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private ToolStripMenuItem редактироватьПользователяToolStripMenuItem;
        private ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem;
    }
}
