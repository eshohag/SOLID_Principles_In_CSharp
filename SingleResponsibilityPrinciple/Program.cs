using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepository = new StudentRepository();
            var successFaildResult = studentRepository.ValidateAndCreate(new Student() { Id = 1001, FullName = "Shohag" });
            Console.WriteLine(successFaildResult);

            Console.ReadKey();
        }
    }
}
