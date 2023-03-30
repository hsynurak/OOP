using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_1
{
    internal class Cylinder : Circle
    {
        private double h;
        public Cylinder() { }
        public Cylinder(double valR, double valH) : base(valR) { h = valH; }
        public double getH() { return h; }
        public void setH(double val) { h = val; }
        public double Cylinder_Area()
        {
            double ret;
            ret = (h * Circle_Perimeter()) + (2 * Circle_Area());
            return ret;
        }
        public double Cylinder_Volume()
        {
            double ret;
            ret = h * Circle_Area();
            return ret; 
        }
    }
}
