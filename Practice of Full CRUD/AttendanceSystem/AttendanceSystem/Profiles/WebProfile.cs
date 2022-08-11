using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AttendanceSystem.Areas.Admin.Models;
using AttendanceSystem.Training.BussinessObjects;
using AutoMapper;

namespace AttendanceSystem.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<CreateStudentModel, Student>().ReverseMap();
            CreateMap<EditStudentModel, Student>().ReverseMap();
        }
    }
}
