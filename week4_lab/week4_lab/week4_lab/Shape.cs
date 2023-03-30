using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lab
{
    internal class Shape
    {
        public string Name { get; set; }
        public Color Col;

        public Shape()
        {
            Name = "";
            Col = new Color();
            Col = Color.White;
        }
    }
}
