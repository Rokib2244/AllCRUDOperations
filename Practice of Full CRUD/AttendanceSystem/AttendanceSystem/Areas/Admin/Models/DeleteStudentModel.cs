using AttendanceSystem.Training.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class DeleteStudentModel
    {
        private readonly IStudentService _studentService;
        public DeleteStudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }

        internal void DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
        }
    }
}
