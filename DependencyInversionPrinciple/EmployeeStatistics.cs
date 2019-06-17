using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Interface;
using DependencyInversionPrinciple.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers()
        {
            return _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }

        public int CountMaleAdministrators() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Male, Position.Administrator).Count();
    }
}
