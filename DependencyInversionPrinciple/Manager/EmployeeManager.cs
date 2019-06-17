using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Interface;
using DependencyInversionPrinciple.Model;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple.Manager
{
    public class EmployeeManager : IEmployeeSearchable, IEmployeeDetails
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>()
                        {
                            new Employee { Name = "Shohag", Gender = Gender.Male, Position = Position.Administrator },
                            new Employee { Name = "Susmita", Gender = Gender.Female, Position = Position.Manager },
                            new Employee { Name = "Sayed", Gender = Gender.Male, Position = Position.Manager },
                            new Employee { Name = "Kobir", Gender = Gender.Male, Position = Position.Executive }
                        };
        }

        public List<Employee> GetEmployeeDetails()
        {
            return _employees;
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}