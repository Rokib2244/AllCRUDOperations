using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple1
{
   public class StudentDataAccess:IStudentDataAccess
    {
        public Student GetStudentDetails(int id)
        {
            
            Student student = new Student()
            {
                StudentId = id,
                StudentName = "Rokib",
                StudentDepartment = "CSE",
                
            };
            return student;
        }
    }
}
