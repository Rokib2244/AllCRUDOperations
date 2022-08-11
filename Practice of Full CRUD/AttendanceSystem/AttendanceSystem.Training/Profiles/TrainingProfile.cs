using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = AttendanceSystem.Training.Entities;
using BO = AttendanceSystem.Training.BussinessObjects;

namespace AttendanceSystem.Training.Profiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Student, BO.Student>().ReverseMap();
        }
    }
}
