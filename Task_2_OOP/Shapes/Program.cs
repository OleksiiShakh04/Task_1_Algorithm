using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var side = 1.4D;
            var radius = 1.74D;
            var baseSide = 9D;
            var height = 4D;


            var shapes = new List<IShape>{
                  new Square(side),
                  new Circle(radius),
                  new Triangle(baseSide, height),
                  new Rectangle(side, height)
                                                             };


             shapes.Sort(delegate(IShape x, IShape y ) {

                 return x.Area.CompareTo(y.Area);
             

             });


            foreach(IShape el in shapes)
            {

                Console.WriteLine("The area of {0}  is : {1}", el , el.Area);

            }


        }
    }
}
