using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleResponsibility1
{
    public class StudentsAttendence
    {
        private StudentInformation student;

        public StudentsAttendence(StudentInformation student)
        {
            this.student = student;
        }

        public string AttendenceInformation(StudentInformation student)
        {
            return $" {student.StudentId} is Present in Class";
        }
    }
}
