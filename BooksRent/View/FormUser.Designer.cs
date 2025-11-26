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
            menuStrip1 = new MenuStrip();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            statusStripHelloUser = new StatusStrip();
            labelProgram = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, сменитьПарольToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(150, 26);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // сменитьПарольToolStripMenuItem
            // 
            сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            сменитьПарольToolStripMenuItem.Size = new Size(138, 24);
            сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            сменитьПарольToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
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
            // labelProgram
            // 
            labelProgram.AutoSize = true;
            labelProgram.Location = new Point(373, 203);
            labelProgram.Name = "labelProgram";
            labelProgram.Size = new Size(50, 20);
            labelProgram.TabIndex = 3;
            labelProgram.Text = "label1";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelProgram);
            Controls.Add(statusStripHelloUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormUser";
            Text = "Пользователь";
            Load += FormUser_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private StatusStrip statusStripHelloUser;
        private Label labelProgram;
    }
}