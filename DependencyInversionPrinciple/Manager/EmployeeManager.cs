using DependencyInversionPrinciple.Enum;
using DependencyInversionPrinciple.Interface;
using DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager },
                            new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager },
                            new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager }
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