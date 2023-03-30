using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_lab
{
    public partial class Form1 : Form
    {
        Circle my_circle = new Circle(5, 3, 3);
        Cube my_cube = new Cube(10);
        Square my_square = new Square(10);
        Sphere my_sphere = new Sphere(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            txt_area.Text = my_circle.Circle_Area().ToString();
            txt_paramet.Text = my_circle.Circle_Prmtr().ToString();
            txt_name.Text = my_circle.Name.ToString();
        }

        private void cube_btn_Click(object sender, EventArgs e)
        {
            txt_area.Text = my_cube.Cube_Surface_Area().ToString();
            txt_paramet.Text = my_cube.Cube_Volume().ToString();   
            txt_name.Text = my_cube.Name.ToString();
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            txt_area.Text = my_square.Square_Area().ToString();
            txt_paramet.Text = my_square.Square_Circum().ToString();
            txt_name.Text = my_square.Name.ToString();
        }

        private void sphere_btn_Click(object sender, EventArgs e)
        {
            txt_area.Text = my_sphere.Sphere_Surface_Area().ToString();
            txt_paramet.Text = my_sphere.Sphere_Volume().ToString();
            txt_name.Text = my_sphere.Name.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
