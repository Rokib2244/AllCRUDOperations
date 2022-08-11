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
    public class EditStudentModel
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public int Id { get; set; }
        public string StudentName { get; set; }
        public double StudentRollNumber { get; set; }
        public EditStudentModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public void LoadModelData( int id)
        {
            var student = _studentService.GetStudentById(id);
            _mapper.Map(student, this);
        }

        internal void Update()
        {
            var student = _mapper.Map<Student>(this);
            _studentService.UpdateStudent(student);
        }
    }
}
