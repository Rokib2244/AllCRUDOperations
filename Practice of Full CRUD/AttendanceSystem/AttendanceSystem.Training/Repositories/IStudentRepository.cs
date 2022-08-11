using AttendanceSystem.Data;
using AttendanceSystem.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Training.Repositories
{
   public interface IStudentRepository : IRepository<Student, int>
    {
    }
}
