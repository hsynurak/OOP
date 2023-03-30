using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_1
{
    internal class Circle
    {
        public double r { get; set; }
        public Circle() { }
        public Circle(double val) { r = val; }
        public double Circle_Perimeter()
        {
            double ret;
            ret = 2 * 3.142 * r;
            return ret;
        }
        public double Circle_Area()
        {
            double ret;
            ret = 3.142 * r * r;
            return ret;
        }
    }
}
