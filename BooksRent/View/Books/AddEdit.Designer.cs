namespace BooksRent.View.Books
{
    partial class AddEdit
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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNewAuthor = new TextBox();
            label3 = new Label();
            comboBoxAuthors = new ComboBox();
            dateTimePickerYear = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBoxCategory = new ComboBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(144, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(386, 27);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Автор";
            // 
            // textBoxNewAuthor
            // 
            textBoxNewAuthor.Location = new Point(144, 104);
            textBoxNewAuthor.Name = "textBoxNewAuthor";
            textBoxNewAuthor.Size = new Size(386, 27);
            textBoxNewAuthor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "или новый";
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(144, 61);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(386, 28);
            comboBoxAuthors.TabIndex = 5;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Location = new Point(144, 157);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(386, 27);
            dateTimePickerYear.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Год издания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 9;
            label5.Text = "Категория";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(144, 211);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(386, 28);
            comboBoxCategory.TabIndex = 10;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(436, 276);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 11;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // AddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 320);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerYear);
            Controls.Add(comboBoxAuthors);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNewAuthor);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "AddEdit";
            Text = "Создать/редактировать";
            Load += AddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxNewAuthor;
        private Label label3;
        private ComboBox comboBoxAuthors;
        private DateTimePicker dateTimePickerYear;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxCategory;
        private Button buttonOK;
    }
}