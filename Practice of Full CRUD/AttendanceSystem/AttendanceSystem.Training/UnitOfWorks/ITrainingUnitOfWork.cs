using AttendanceSystem.Data;
using AttendanceSystem.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Training.UnitOfWorks
{
     public interface ITrainingUnitOfWork : IUnitOfWork
    {
        public IStudentRepository Students { get; }
    }
}
