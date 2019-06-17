using InterfaceSegregationPrinciple.Interface;
using System;

namespace InterfaceSegregationPrinciple.Functionality
{
    class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
