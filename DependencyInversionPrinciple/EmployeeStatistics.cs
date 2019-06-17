using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Interface;
using System.Linq;

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
