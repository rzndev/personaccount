namespace VUS
{
    partial class ИмпортСотрудников
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonИмпорт = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя файла";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonИмпорт
            // 
            this.buttonИмпорт.Location = new System.Drawing.Point(662, 16);
            this.buttonИмпорт.Name = "buttonИмпорт";
            this.buttonИмпорт.Size = new System.Drawing.Size(75, 23);
            this.buttonИмпорт.TabIndex = 2;
            this.buttonИмпорт.Text = "Импорт";
            this.buttonИмпорт.UseVisualStyleBackColor = true;
            this.buttonИмпорт.Click += new System.EventHandler(this.buttonИмпорт_Click);
            // 
            // ИмпортСотрудников
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 57);
            this.Controls.Add(this.buttonИмпорт);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ИмпортСотрудников";
            this.Text = "ИмпортСотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonИмпорт;
    }
}