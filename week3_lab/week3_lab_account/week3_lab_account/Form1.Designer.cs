namespace week3_lab_account
{
    partial class Form1
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
            this.ADD_button = new System.Windows.Forms.Button();
            this.ACC_No_textBox = new System.Windows.Forms.TextBox();
            this.Acc_Name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ADD_button
            // 
            this.ADD_button.Location = new System.Drawing.Point(375, 131);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(75, 23);
            this.ADD_button.TabIndex = 0;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // ACC_No_textBox
            // 
            this.ACC_No_textBox.Location = new System.Drawing.Point(243, 131);
            this.ACC_No_textBox.Name = "ACC_No_textBox";
            this.ACC_No_textBox.Size = new System.Drawing.Size(100, 20);
            this.ACC_No_textBox.TabIndex = 1;
            // 
            // Acc_Name_textBox
            // 
            this.Acc_Name_textBox.Location = new System.Drawing.Point(243, 168);
            this.Acc_Name_textBox.Name = "Acc_Name_textBox";
            this.Acc_Name_textBox.Size = new System.Drawing.Size(100, 20);
            this.Acc_Name_textBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Acc_Name_textBox);
            this.Controls.Add(this.ACC_No_textBox);
            this.Controls.Add(this.ADD_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.TextBox ACC_No_textBox;
        private System.Windows.Forms.TextBox Acc_Name_textBox;
    }
}

