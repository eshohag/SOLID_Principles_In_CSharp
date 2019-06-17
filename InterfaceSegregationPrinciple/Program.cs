using InterfaceSegregationPrinciple.Functionality;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionalVehicle multiFunc = new MultiFunctionalVehicle(new Car(), new Airplane());
            multiFunc.Drive();
            Console.ReadKey();
        }
    }
}
