using DependencyInversionPrinciple.Interface;
using System;

namespace DependencyInversionPrinciple
{
    class EmployeeDetails
    {
        private readonly IEmployeeDetails _emp;

        public EmployeeDetails(IEmployeeDetails emp)
        {
            _emp = emp;
        }
        public void GetEmployeeDetail()
        {
            foreach (var employee in _emp.GetEmployeeDetails())
            {
                Console.WriteLine("Name- " + employee.Name + " & Designation- " + employee.Position);
            }
        }
    }
}
