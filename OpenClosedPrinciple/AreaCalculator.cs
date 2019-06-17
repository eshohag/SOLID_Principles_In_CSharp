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
        public static double Area(IEnumerable<Shape> shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Area();

                #region SwitchStatementIsBetterThenIfStatement
                switch (shape)
                {
                    case Circle Circle:
                        Console.WriteLine("Circle");
                        break;

                    case Square Square:
                        Console.WriteLine("Square");
                        break;

                    case Triangle Triangle:
                        Console.WriteLine("Triangle");
                        break;

                    default:
                        break;
                }
                #endregion

                #region IfStatementsComment
                //if (shape is Circle)
                //{
                //    Console.WriteLine("Circle");
                //}
                //if (shape is Square)
                //{
                //    Console.WriteLine("Square");
                //}
                //if (shape is Triangle)
                //{
                //    Console.WriteLine("Triangle");
                //}
                #endregion
            }
            return area;
        }
    }
}