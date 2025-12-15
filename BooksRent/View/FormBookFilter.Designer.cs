namespace BooksRent.View
{
    partial class FormBookFilter
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
            buttonOK = new Button();
            comboBoxCategory = new ComboBox();
            label5 = new Label();
            comboBoxAuthors = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(434, 113);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 16;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += ButtonOK_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(142, 65);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(386, 28);
            comboBoxCategory.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 73);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 14;
            label5.Text = "Категория";
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(142, 12);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(386, 28);
            comboBoxAuthors.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 12;
            label2.Text = "Автор";
            // 
            // FormBookFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 172);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxCategory);
            Controls.Add(label5);
            Controls.Add(comboBoxAuthors);
            Controls.Add(label2);
            Name = "FormBookFilter";
            Text = "Фильтрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private ComboBox comboBoxCategory;
        private Label label5;
        private ComboBox comboBoxAuthors;
        private Label label2;
    }
}