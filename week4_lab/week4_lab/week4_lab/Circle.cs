using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Circle: Shape2D
    {
        public double R { get; set; }
        public Circle() : base()
        {
            R = 0;
            Name = "Circle";
        }
        public Circle(double r, double x,  double y) : base(x, y)
        {
            R = r;
            Name = "Circle";
        }
        public double Circle_Area()
        {
            return 3.142 * R * R;
        }
        public double Circle_Prmtr()
        {
            return 2 * 3.142 * R;
        }
    }
}
