using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Functionality.AreaCalculators
{
    public class Square : Shape
    {
        public double Height { get; private set; }
        public Square(double height)
        {
            Height = height;
        }
        public override double Area()
        {
            return Math.Sqrt(Height);
        }
    }
}
