namespace week4_lab
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
            this.circle_btn = new System.Windows.Forms.Button();
            this.txt_paramet = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cube_btn = new System.Windows.Forms.Button();
            this.square_btn = new System.Windows.Forms.Button();
            this.sphere_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circle_btn
            // 
            this.circle_btn.Location = new System.Drawing.Point(496, 92);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(75, 23);
            this.circle_btn.TabIndex = 0;
            this.circle_btn.Text = "CircleCalc";
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // txt_paramet
            // 
            this.txt_paramet.Location = new System.Drawing.Point(292, 138);
            this.txt_paramet.Name = "txt_paramet";
            this.txt_paramet.Size = new System.Drawing.Size(100, 20);
            this.txt_paramet.TabIndex = 1;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(292, 95);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(292, 181);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area / SurfaceArea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Circum / Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // cube_btn
            // 
            this.cube_btn.Location = new System.Drawing.Point(496, 121);
            this.cube_btn.Name = "cube_btn";
            this.cube_btn.Size = new System.Drawing.Size(75, 23);
            this.cube_btn.TabIndex = 7;
            this.cube_btn.Text = "CubeCalc";
            this.cube_btn.UseVisualStyleBackColor = true;
            this.cube_btn.Click += new System.EventHandler(this.cube_btn_Click);
            // 
            // square_btn
            // 
            this.square_btn.Location = new System.Drawing.Point(496, 150);
            this.square_btn.Name = "square_btn";
            this.square_btn.Size = new System.Drawing.Size(75, 23);
            this.square_btn.TabIndex = 8;
            this.square_btn.Text = "SquareClac";
            this.square_btn.UseVisualStyleBackColor = true;
            this.square_btn.Click += new System.EventHandler(this.square_btn_Click);
            // 
            // sphere_btn
            // 
            this.sphere_btn.Location = new System.Drawing.Point(496, 178);
            this.sphere_btn.Name = "sphere_btn";
            this.sphere_btn.Size = new System.Drawing.Size(75, 23);
            this.sphere_btn.TabIndex = 9;
            this.sphere_btn.Text = "SphereCalc";
            this.sphere_btn.UseVisualStyleBackColor = true;
            this.sphere_btn.Click += new System.EventHandler(this.sphere_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sphere_btn);
            this.Controls.Add(this.square_btn);
            this.Controls.Add(this.cube_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_paramet);
            this.Controls.Add(this.circle_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.TextBox txt_paramet;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cube_btn;
        private System.Windows.Forms.Button square_btn;
        private System.Windows.Forms.Button sphere_btn;
    }
}

