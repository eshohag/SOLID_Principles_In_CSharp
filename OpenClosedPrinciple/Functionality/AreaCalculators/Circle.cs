﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Functionality.AreaCalculators
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
