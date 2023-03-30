using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Shape3D : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Shape3D() : base()
        {
            X = 0;
            Y = 0;
            Z = 0;
            Name = "3D Shape";
        }
        public Shape3D(double xx, double yy, double zz) : base()
        {
            X = xx;
            Y = yy;
            Z = zz;
            Name = "3D Shape";
        }
    }
}
