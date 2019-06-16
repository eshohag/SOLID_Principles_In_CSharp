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
        public static double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }

                if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    area += (circle.Radius * circle.Radius) * Math.PI;
                }
            }
            //https://exceptionnotfound.net/simply-solid-the-open-closed-principle/
            return area;
        }
    }
}
