using AttendanceSystem.Training.Services;
using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSystem.Training.BussinessObjects;

namespace AttendanceSystem.Areas.Admin.Models
{
    public class CreateStudentModel
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public string StudentName { get; set; }
        public double StudentRollNumber { get; set; }
        public CreateStudentModel()
        {
            
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public void CreateStudent()
        {
            var student = _mapper.Map<Student>(this);
            _studentService.CreateStudent(student);
        }
    }
}
