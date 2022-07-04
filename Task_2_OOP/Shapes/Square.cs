using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : IShape
    {
        double side;
        double area;

        public double Area { get { return area = side * side; } }
        public Square(double side)
        {
            this.side = side;
        }



    }
}
