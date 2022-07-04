using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : IShape
    {
        double side;
        double height;
        double area;
        public double Area { get { return area = side * height; } }
        public Rectangle(double side, double height)
        {
            this.side = side;
            this.height = height;

        }

       
    }
}
