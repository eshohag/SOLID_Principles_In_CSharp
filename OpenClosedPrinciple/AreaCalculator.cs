using OpenClosedPrinciple.Functionality.AreaCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class AreaCalculator
    {
        public static double Area(List<Shape> shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();


                if (shape is Circle)
                {
                    Console.WriteLine("Circle");
                }
                if (shape is Square)
                {
                    Console.WriteLine("Square");
                }
                if (shape is Triangle)
                {
                    Console.WriteLine("Triangle");
                }
            }


            return area;
        }
    }
}
