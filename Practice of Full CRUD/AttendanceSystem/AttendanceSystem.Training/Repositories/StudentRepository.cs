using AttendanceSystem.Data;
using AttendanceSystem.Training.Contexts;
using AttendanceSystem.Training.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Training.Repositories
{
    public class StudentRepository : Repository<Student, int>, IStudentRepository
    {
        public StudentRepository( ITrainingContext context) : base((DbContext)context)
        {

        }
    }
}
