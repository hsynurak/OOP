using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_area_circum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            myCircle circle1 = new myCircle();

            //circle1.R = ToString(txtRadius.Text);

            circle1.R = 1;
            double.TryParse(txtRadius.Text, out circle1.R);

            double A, C;
            A = circle1.area();
            C = circle1.circum();

            txtArea.Text = A.ToString();
            txtCircum.Text = C.ToString();
        }
    }
    public class myCircle
    {
        public double R;

        public double area()
        {
            double ret = 3.14 * R * R;
            return ret;
        }
        public double circum()
        {
            double ret = 2 * 3.14 * R;
            return ret;
        }
    }
}
