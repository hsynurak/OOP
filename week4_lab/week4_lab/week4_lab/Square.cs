using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Square : Shape2D
    {
        public double Edge_Length { get; set; }
        public Square()
        {
            Edge_Length = 0;
            Name = "Square";
        }
        public Square(double edge_Length)
        {
            Edge_Length = edge_Length;
            Name = "Square";
        }
        public double Square_Area()
        {
            return Edge_Length*Edge_Length;
        }
        public double Square_Circum()
        {
            return 4*Edge_Length;
        }
    }
}
