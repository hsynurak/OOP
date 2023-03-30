using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Sphere : Shape3D
    {
        public double R { get; set; }
        public Sphere() : base()
        {
            R = 0;
            Name = "Sphere";
        }
        public Sphere(double r)
        {
            R = r;
            Name = "Sphere";
        }
        public double Sphere_Surface_Area()
        {
            return 4 * 3.142 * R * R;
        }
        public double Sphere_Volume()
        {
            return 4 / 3 * 3.142 * R * R * R;
        }
    }
    
}
