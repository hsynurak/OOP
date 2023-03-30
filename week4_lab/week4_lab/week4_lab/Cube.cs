using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Cube : Shape3D
    {
        public double Edge_Length { get; set; }
        public Cube() : base()
        {
            Edge_Length = 0;
            Name = "Cube";
        }
        public Cube(double edge_Length)
        {
            Edge_Length = edge_Length;
            Name = "Cube";
        }

        public double Cube_Surface_Area()
        {
            return 6 * Edge_Length * Edge_Length;
        }
        public double Cube_Volume()
        {
            return Edge_Length * Edge_Length * Edge_Length;
        }
    }
}
