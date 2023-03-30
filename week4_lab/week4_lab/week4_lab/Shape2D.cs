using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Shape2D: Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Shape2D() : base()
        {
            X = 0;
            Y = 0;
            Name = "2D Shape";
        }
        public Shape2D(double xx, double yy) : base()
        {
            X = xx;
            Y = yy;
            Name = "2D Shape";
        } 
    }
}
