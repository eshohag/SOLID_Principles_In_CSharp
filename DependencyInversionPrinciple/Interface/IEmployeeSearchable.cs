using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Model;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.Interface
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
