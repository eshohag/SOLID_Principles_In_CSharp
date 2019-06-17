using InterfaceSegregationPrinciple.Interface;
using System;

namespace InterfaceSegregationPrinciple.Functionality
{
    class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }
    }
}
