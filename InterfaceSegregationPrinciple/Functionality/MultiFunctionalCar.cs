using InterfaceSegregationPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Functionality
{
    class MultiFunctionalCar : IMultiFunctionalVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
