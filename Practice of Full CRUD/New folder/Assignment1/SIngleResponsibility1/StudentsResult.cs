using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleResponsibility1
{
    public class StudentsResult
    {
        private StudentInformation student;

        public StudentsResult(StudentInformation student)
        {
            this.student = student;

        }

        public string CalculateResult(StudentInformation student)
        {
            return $"Result of {student.StudentId} is...";
        }
    }
}
