using AttendanceSystem.Training.BussinessObjects;
using AttendanceSystem.Training.UnitOfWorks;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Training.Services
{
    class StudentService : IStudentService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public StudentService(ITrainingUnitOfWork trainingUnitOfWork, IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void CreateStudent(Student student)
        {
            if (student == null)
                throw new InvalidOperationException("Student was not found");
            if(IsStudentAlreadyExist(student.StudentRollNumber))
               throw new NotImplementedException("Student already existed");
            _trainingUnitOfWork.Students.Add(
                _mapper.Map<Entities.Student>(student));
            _trainingUnitOfWork.Save();
        }

        public void DeleteStudent(int id)
        {
            _trainingUnitOfWork.Students.Remove(id);
            _trainingUnitOfWork.Save();
        }

        public IList<Student> GetAllStudents()
        {
            var studentEntities = _trainingUnitOfWork.Students.GetAll();
            var students = new List<Student>();
            foreach( var entity in studentEntities)
            {
                var student = _mapper.Map<Student>(entity);
                students.Add(student);
            }
            return students;
        }

        public object GetStudentById(int id)
        {
            var student = _trainingUnitOfWork.Students.GetById(id);
            if (student == null) return null;
            return _mapper.Map<Student>(student);
        }

        public void UpdateStudent(Student student)
        {
            //if (student == null)
            //    return new InvalidOperationException("Student was not found");
            var studentEntity = _trainingUnitOfWork.Students.GetById(student.Id);
            if( studentEntity != null)
            {
                _mapper.Map(student, studentEntity);
                _trainingUnitOfWork.Save();
            }

            
        }

        private bool IsStudentAlreadyExist(double studentRollNumber)
        {
            return _trainingUnitOfWork.Students.GetCount( x=> x.StudentRollNumber == studentRollNumber) > 0;         

        }
             
    }
}
