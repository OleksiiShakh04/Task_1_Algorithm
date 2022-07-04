using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : IShape 
    {


        double baseSide;
        double height;
        double area;
        public double Area { get { return area = (baseSide * height) * 0.5d; } }
        public Triangle(double baseSide, double height)
        {
            this.baseSide = baseSide;
            this.height = height;

        }

       
    }
}
