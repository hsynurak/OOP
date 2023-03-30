using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cylinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_cylinder my_Cylinder = new my_cylinder();
            
            my_Cylinder.R = 1;
            my_Cylinder.H = 1;
            double.TryParse(txtRadius.Text, out my_Cylinder.R);
            double.TryParse(txtHeight.Text, out my_Cylinder.H);

            double V;
            double SA;

            V = my_Cylinder.volume();
            SA = my_Cylinder.surface_area();

            txtVolume.Text = V.ToString();
            txtSurfArea.Text = SA.ToString();

        }
    }

    public class my_cylinder
    {
        public double R;
        public double H;

        public double volume()
        {
            double ret = 3.14 * R * R * H;
            return ret;
        }

        public double surface_area()
        {
            double ret = (2 * 3.14 * R * R) + (2 * 3.14 * R * R * H);
            return ret;
        }
    }
}
