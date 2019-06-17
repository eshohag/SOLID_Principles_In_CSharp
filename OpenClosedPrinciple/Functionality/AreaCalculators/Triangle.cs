using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Functionality.AreaCalculators
{
    public class Triangle : Shape
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double Area()
        {
            double totalHalf = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(totalHalf * (totalHalf - FirstSide) * (totalHalf - SecondSide) * (totalHalf - ThirdSide));
        }
    }
}
