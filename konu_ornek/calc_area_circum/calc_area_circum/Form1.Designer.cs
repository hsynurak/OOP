namespace calc_area_circum
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtCircum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(97, 83);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(429, 83);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            // 
            // lblCircum
            // 
            this.lblCircum.AutoSize = true;
            this.lblCircum.Location = new System.Drawing.Point(562, 83);
            this.lblCircum.Name = "lblCircum";
            this.lblCircum.Size = new System.Drawing.Size(39, 13);
            this.lblCircum.TabIndex = 2;
            this.lblCircum.Text = "Circum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(70, 99);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 4;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(397, 99);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 5;
            // 
            // txtCircum
            // 
            this.txtCircum.Location = new System.Drawing.Point(534, 99);
            this.txtCircum.Name = "txtCircum";
            this.txtCircum.Size = new System.Drawing.Size(100, 20);
            this.txtCircum.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCircum);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCircum);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtCircum;
    }
}

