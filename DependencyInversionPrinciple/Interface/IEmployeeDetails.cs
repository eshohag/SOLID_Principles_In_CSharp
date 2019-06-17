using DependencyInversionPrinciple.Model;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Interface
{
    interface IEmployeeDetails
    {
        List<Employee> GetEmployeeDetails();
    }
}
