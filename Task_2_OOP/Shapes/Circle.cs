using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {

        double radius;
        double area;

        public double Area { get { return area = (radius * radius) * Math.PI; } }
        public Circle(double radius)
        {
            this.radius = radius;
        }

       
    }
}
