using System;
using System.Threading.Tasks.Dataflow;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.Id = 3;
            student.StudentName = "Fahim";
            var db = new DataOperation<Student>();
            db.Insert(student);
            //db.Delete(student);
            //db.Update(student);
            //db.GetAll();
        }
    }
}
