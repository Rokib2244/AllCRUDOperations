using AttendanceSystem.Training.BussinessObjects;
using AttendanceSystem.Training.Services;
using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class StudentListModel
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public IList<Student> Students { get; set; }
        public StudentListModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public void LoadModelData()
        {
            Students = _studentService.GetAllStudents();
        }
    }
}
