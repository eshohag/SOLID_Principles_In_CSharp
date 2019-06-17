using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Interface;
using DependencyInversionPrinciple.Manager;
using DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            var empManager = new EmployeeManager();

            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
            Console.WriteLine($"Number of Male Administrators in our company is: {stats.CountMaleAdministrators()}");

            Console.ReadKey();
        }
    }
}
