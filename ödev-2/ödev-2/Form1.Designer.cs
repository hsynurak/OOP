namespace ödev_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGPA = new System.Windows.Forms.Button();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtSalaryPerHour = new System.Windows.Forms.TextBox();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGPA
            // 
            this.btnGPA.Location = new System.Drawing.Point(38, 12);
            this.btnGPA.Name = "btnGPA";
            this.btnGPA.Size = new System.Drawing.Size(75, 23);
            this.btnGPA.TabIndex = 0;
            this.btnGPA.Text = "ClassGPA";
            this.btnGPA.UseVisualStyleBackColor = true;
            this.btnGPA.Click += new System.EventHandler(this.btnGPA_Click);
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(186, 15);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 1;
            // 
            // txtSalaryPerHour
            // 
            this.txtSalaryPerHour.Location = new System.Drawing.Point(186, 135);
            this.txtSalaryPerHour.Name = "txtSalaryPerHour";
            this.txtSalaryPerHour.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryPerHour.TabIndex = 3;
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(38, 133);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(116, 23);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "CalcSalaryPerHour";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(38, 231);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(75, 23);
            this.btnAge.TabIndex = 5;
            this.btnAge.Text = "CalcAge";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(186, 231);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.txtSalaryPerHour);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.btnGPA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtSalaryPerHour;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}

