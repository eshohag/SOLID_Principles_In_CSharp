using DependencyInversionPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (var employee in _emp.Details())
            {
                Console.WriteLine("Name- " + employee.Name + " & Designation- " + employee.Position);
            }
        }
    }
}
