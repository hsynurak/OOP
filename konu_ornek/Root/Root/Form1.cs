using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Root
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Roots my_roots = new Roots();

            my_roots.a = 0;
            my_roots.b = 0;
            my_roots.c = 0;
           
            //txta.Text = a.ToString();
            double.TryParse(txta.Text, out my_roots.a);  //stringten int32 ye geçiş için kullanıyor.
            double.TryParse(txtb.Text, out my_roots.b);
            double.TryParse(txtc.Text, out my_roots.c);

            my_roots.Roots_Calc();

            double x1, x2;
            x1 = my_roots.X1;
            x2 = my_roots.X2;

            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();
            


        }
    }
    public class Roots
    {
        public double a;
        public double b;
        public double c;

        public double X1;
        public double X2;

        public Roots() { a = 0; b = 0; c = 0; }
        public Roots(double A, double B, double C)
        {
            a = A; b = B; c = C;
        }

        public void Roots_Calc()
        {
            double SQRT_Val = b * b - 4 * a * c;
            if (SQRT_Val < 0) MessageBox.Show("Error!!", "Error -ve...!!");
            else if (Math.Abs(a)<0.000000001) MessageBox.Show("Error!!", "Error Not 2nd Order Equ...!!");
            else
            {
                X1 = (-b + Math.Sqrt(SQRT_Val)) / (2 * a);
                X2 = (-b - Math.Sqrt(SQRT_Val)) / (2 * a);
            }
        }
    }
}
