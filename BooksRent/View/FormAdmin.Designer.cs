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
            dataGridViewBooksAdmin = new DataGridView();
            textBoxSearchBooksAdmin = new TextBox();
            labelSearch = new Label();
            menuStrip2 = new MenuStrip();
            создатьКнигуToolStripMenuItem = new ToolStripMenuItem();
            редактироватьКнигуToolStripMenuItem = new ToolStripMenuItem();
            удалитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dataGridViewUsersAdmin = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            редактироватьПользователяToolStripMenuItem = new ToolStripMenuItem();
            удалитьПользователяToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            tabPage3 = new TabPage();
            textBoxSearchRentsAdmin = new TextBox();
            label1 = new Label();
            dataGridViewRentsAdmin = new DataGridView();
            menuStrip3 = new MenuStrip();
            фильтрToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksAdmin).BeginInit();
            menuStrip2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsersAdmin).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentsAdmin).BeginInit();
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
            tabPage2.Controls.Add(dataGridViewBooksAdmin);
            tabPage2.Controls.Add(textBoxSearchBooksAdmin);
            tabPage2.Controls.Add(labelSearch);
            tabPage2.Controls.Add(menuStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1167, 534);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            // 
            // dataGridViewBooksAdmin
            // 
            dataGridViewBooksAdmin.AllowUserToAddRows = false;
            dataGridViewBooksAdmin.AllowUserToDeleteRows = false;
            dataGridViewBooksAdmin.AllowUserToOrderColumns = true;
            dataGridViewBooksAdmin.AllowUserToResizeColumns = false;
            dataGridViewBooksAdmin.AllowUserToResizeRows = false;
            dataGridViewBooksAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBooksAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooksAdmin.BackgroundColor = Color.Bisque;
            dataGridViewBooksAdmin.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBooksAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooksAdmin.Location = new Point(3, 86);
            dataGridViewBooksAdmin.Name = "dataGridViewBooksAdmin";
            dataGridViewBooksAdmin.ReadOnly = true;
            dataGridViewBooksAdmin.RowHeadersVisible = false;
            dataGridViewBooksAdmin.RowHeadersWidth = 51;
            dataGridViewBooksAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooksAdmin.Size = new Size(1161, 445);
            dataGridViewBooksAdmin.TabIndex = 3;
            // 
            // textBoxSearchBooksAdmin
            // 
            textBoxSearchBooksAdmin.Location = new Point(66, 36);
            textBoxSearchBooksAdmin.Name = "textBoxSearchBooksAdmin";
            textBoxSearchBooksAdmin.Size = new Size(175, 27);
            textBoxSearchBooksAdmin.TabIndex = 2;
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
            создатьКнигуToolStripMenuItem.Click += создатьКнигуToolStripMenuItem_Click;
            // 
            // редактироватьКнигуToolStripMenuItem
            // 
            редактироватьКнигуToolStripMenuItem.Name = "редактироватьКнигуToolStripMenuItem";
            редактироватьКнигуToolStripMenuItem.Size = new Size(167, 24);
            редактироватьКнигуToolStripMenuItem.Text = "Редактировать книгу";
            редактироватьКнигуToolStripMenuItem.Click += редактироватьКнигуToolStripMenuItem_Click;
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            удалитьКнигуToolStripMenuItem.Size = new Size(121, 24);
            удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            удалитьКнигуToolStripMenuItem.Click += удалитьКнигуToolStripMenuItem_Click;
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewUsersAdmin);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1167, 534);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsersAdmin
            // 
            dataGridViewUsersAdmin.AllowUserToAddRows = false;
            dataGridViewUsersAdmin.AllowUserToDeleteRows = false;
            dataGridViewUsersAdmin.AllowUserToOrderColumns = true;
            dataGridViewUsersAdmin.AllowUserToResizeColumns = false;
            dataGridViewUsersAdmin.AllowUserToResizeRows = false;
            dataGridViewUsersAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsersAdmin.BackgroundColor = Color.AntiqueWhite;
            dataGridViewUsersAdmin.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsersAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsersAdmin.Dock = DockStyle.Fill;
            dataGridViewUsersAdmin.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewUsersAdmin.GridColor = SystemColors.InfoText;
            dataGridViewUsersAdmin.Location = new Point(3, 31);
            dataGridViewUsersAdmin.Name = "dataGridViewUsersAdmin";
            dataGridViewUsersAdmin.ReadOnly = true;
            dataGridViewUsersAdmin.RowHeadersVisible = false;
            dataGridViewUsersAdmin.RowHeadersWidth = 51;
            dataGridViewUsersAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsersAdmin.Size = new Size(1161, 500);
            dataGridViewUsersAdmin.TabIndex = 3;
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
            tabPage3.Controls.Add(textBoxSearchRentsAdmin);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridViewRentsAdmin);
            tabPage3.Controls.Add(menuStrip3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1167, 534);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Арендные чеки";
            // 
            // textBoxSearchRentsAdmin
            // 
            textBoxSearchRentsAdmin.Location = new Point(66, 41);
            textBoxSearchRentsAdmin.Name = "textBoxSearchRentsAdmin";
            textBoxSearchRentsAdmin.Size = new Size(175, 27);
            textBoxSearchRentsAdmin.TabIndex = 6;
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
            // dataGridViewRentsAdmin
            // 
            dataGridViewRentsAdmin.AllowUserToAddRows = false;
            dataGridViewRentsAdmin.AllowUserToDeleteRows = false;
            dataGridViewRentsAdmin.AllowUserToOrderColumns = true;
            dataGridViewRentsAdmin.AllowUserToResizeColumns = false;
            dataGridViewRentsAdmin.AllowUserToResizeRows = false;
            dataGridViewRentsAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRentsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRentsAdmin.BackgroundColor = Color.Bisque;
            dataGridViewRentsAdmin.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewRentsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentsAdmin.Location = new Point(0, 86);
            dataGridViewRentsAdmin.Name = "dataGridViewRentsAdmin";
            dataGridViewRentsAdmin.ReadOnly = true;
            dataGridViewRentsAdmin.RowHeadersVisible = false;
            dataGridViewRentsAdmin.RowHeadersWidth = 51;
            dataGridViewRentsAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRentsAdmin.Size = new Size(1167, 448);
            dataGridViewRentsAdmin.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksAdmin).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsersAdmin).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentsAdmin).EndInit();
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
        private DataGridView dataGridViewUsersAdmin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private ToolStripMenuItem редактироватьПользователяToolStripMenuItem;
        private ToolStripMenuItem удалитьПользователяToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private DataGridView dataGridViewBooksAdmin;
        private TextBox textBoxSearchBooksAdmin;
        private Label labelSearch;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem создатьКнигуToolStripMenuItem;
        private ToolStripMenuItem редактироватьКнигуToolStripMenuItem;
        private ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private TabPage tabPage3;
        private TextBox textBoxSearchRentsAdmin;
        private Label label1;
        private DataGridView dataGridViewRentsAdmin;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem фильтрToolStripMenuItem1;
    }
}
