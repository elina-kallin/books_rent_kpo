namespace AppUsersLab1.View
{
    partial class FormAboutProgram
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 98);
            label1.Name = "label1";
            label1.Size = new Size(305, 20);
            label1.TabIndex = 0;
            label1.Text = "Наличие букв, цифр и знаков препинания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 31);
            label2.Name = "label2";
            label2.Size = new Size(301, 20);
            label2.TabIndex = 1;
            label2.Text = "Автор: Бакальская Елена, группа ПИбд-41";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 137);
            label3.Name = "label3";
            label3.Size = new Size(182, 20);
            label3.TabIndex = 2;
            label3.Text = "Режим шифрования OFB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 175);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 3;
            label4.Text = "Алгоритм хеширования MD5";
            // 
            // FormAboutProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 224);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAboutProgram";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}