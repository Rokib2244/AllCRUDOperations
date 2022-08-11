using AttendanceSystem.Training.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Training.Services
{
    public interface IStudentService
    {
        void CreateStudent(Student student);
        object GetStudentById(int id);
        void UpdateStudent(Student student);
        IList<Student> GetAllStudents();
        void DeleteStudent(int id);
    }
}
