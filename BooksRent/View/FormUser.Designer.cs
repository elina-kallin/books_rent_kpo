namespace AppUsersLab1.Forms
{
    partial class FormUser
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            statusStripHelloUser = new StatusStrip();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            фильтрToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewBooksUser = new DataGridView();
            textBox1 = new TextBox();
            labelSearch = new Label();
            dataGridViewRentsUser = new DataGridView();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentsUser).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // statusStripHelloUser
            // 
            statusStripHelloUser.ImageScalingSize = new Size(20, 20);
            statusStripHelloUser.Location = new Point(0, 428);
            statusStripHelloUser.Name = "statusStripHelloUser";
            statusStripHelloUser.Size = new Size(800, 22);
            statusStripHelloUser.TabIndex = 2;
            statusStripHelloUser.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 428);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewBooksUser);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(labelSearch);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 395);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewRentsUser);
            tabPage2.Controls.Add(menuStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 395);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Арендные чеки";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { фильтрToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(786, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // фильтрToolStripMenuItem
            // 
            фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            фильтрToolStripMenuItem.Size = new Size(74, 24);
            фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // dataGridViewBooksUser
            // 
            dataGridViewBooksUser.BackgroundColor = Color.Bisque;
            dataGridViewBooksUser.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewBooksUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooksUser.Dock = DockStyle.Fill;
            dataGridViewBooksUser.Location = new Point(3, 31);
            dataGridViewBooksUser.Name = "dataGridViewBooksUser";
            dataGridViewBooksUser.RowHeadersWidth = 51;
            dataGridViewBooksUser.Size = new Size(786, 361);
            dataGridViewBooksUser.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 5;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(11, 44);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(52, 20);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Поиск";
            // 
            // dataGridViewRentsUser
            // 
            dataGridViewRentsUser.BackgroundColor = Color.Bisque;
            dataGridViewRentsUser.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewRentsUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentsUser.Dock = DockStyle.Fill;
            dataGridViewRentsUser.Location = new Point(3, 31);
            dataGridViewRentsUser.Name = "dataGridViewRentsUser";
            dataGridViewRentsUser.RowHeadersWidth = 51;
            dataGridViewRentsUser.Size = new Size(786, 361);
            dataGridViewRentsUser.TabIndex = 8;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(786, 28);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(74, 24);
            toolStripMenuItem1.Text = "Фильтр";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(statusStripHelloUser);
            MainMenuStrip = menuStrip1;
            Name = "FormUser";
            Text = "Пользователь";
            Load += FormUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooksUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentsUser).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private StatusStrip statusStripHelloUser;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem фильтрToolStripMenuItem;
        private DataGridView dataGridViewBooksUser;
        private TextBox textBox1;
        private Label labelSearch;
        private DataGridView dataGridViewRentsUser;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}