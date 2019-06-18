using System;

namespace SingleResponsibilityPrinciple
{
    public class StudentRepository
    {
        private void Validate(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FullName))
                throw new FormatException("Student name cannot be empty!");
        }
        private int Create(Student student)
        {
           // _db.Students.Add(student);
            //_db.SaveChanges();
            return student.Id;
        }
        public int ValidateAndCreate(Student student)
        {
            Validate(student);
            return Create(student);
        }
    }
}
