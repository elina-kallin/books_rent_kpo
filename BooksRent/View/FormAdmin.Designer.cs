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
            dataGridViewBooks = new DataGridView();
            textBox1 = new TextBox();
            labelSearch = new Label();
            menuStrip2 = new MenuStrip();
            создатьКнигуToolStripMenuItem = new ToolStripMenuItem();
            редактироватьКнигуToolStripMenuItem = new ToolStripMenuItem();
            удалитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dataGridViewUsers = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            редактироватьПользователяToolStripMenuItem = new ToolStripMenuItem();
            удалитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabPage3 = new TabPage();
            textBox2 = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            menuStrip3 = new MenuStrip();
            фильтрToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            menuStrip2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip3.SuspendLayout();
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
            tabPage2.BackColor = Color.AntiqueWhite;
            tabPage2.Controls.Add(dataGridViewBooks);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(labelSearch);
            tabPage2.Controls.Add(menuStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1167, 534);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBooks.BackgroundColor = Color.Bisque;
            dataGridViewBooks.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(3, 86);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(1161, 445);
            dataGridViewBooks.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(8, 43);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(52, 20);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Поиск";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { создатьКнигуToolStripMenuItem, редактироватьКнигуToolStripMenuItem, удалитьКнигуToolStripMenuItem, фильтрToolStripMenuItem });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1161, 28);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // создатьКнигуToolStripMenuItem
            // 
            создатьКнигуToolStripMenuItem.Name = "создатьКнигуToolStripMenuItem";
            создатьКнигуToolStripMenuItem.Size = new Size(120, 24);
            создатьКнигуToolStripMenuItem.Text = "Создать книгу";
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            редактироватьКнигуToolStripMenuItem.Size = new Size(167, 24);
            редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            удалитьКнигуToolStripMenuItem.Size = new Size(121, 24);
            удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
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
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToOrderColumns = true;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.AntiqueWhite;
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
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1175, 567);
            tabControl.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.AntiqueWhite;
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView);
            tabPage3.Controls.Add(menuStrip3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1167, 534);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Арендные чеки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 48);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Поиск";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.Bisque;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 86);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1167, 448);
            dataGridView.TabIndex = 4;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { фильтрToolStripMenuItem1 });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1167, 28);
            menuStrip3.TabIndex = 7;
            menuStrip3.Text = "menuStrip3";
            // 
            // фильтрToolStripMenuItem1
            // 
            фильтрToolStripMenuItem1.Name = "фильтрToolStripMenuItem1";
            фильтрToolStripMenuItem1.Size = new Size(74, 24);
            фильтрToolStripMenuItem1.Text = "Фильтр";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
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
        private DataGridView dataGridViewBooks;
        private TextBox textBox1;
        private Label labelSearch;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem создатьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private TabPage tabPage3;
        private TextBox textBox2;
        private Label label1;
        private DataGridView dataGridView;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem фильтрToolStripMenuItem1;
    }
}
