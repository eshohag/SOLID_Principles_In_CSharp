
using OpenClosedPrinciple.Functionality;
using OpenClosedPrinciple.Functionality.AreaCalculators;
using OpenClosedPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Circle(10),
                new Square(20),
                new Triangle(10,15,20)
            };
            var totalArea = AreaCalculator.Area(shapes);
            Console.WriteLine(totalArea);


            var devCalculations = new List<BaseSalaryCalculator>()
            {
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
            };
            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

            Console.ReadKey();
        }
    }
}
