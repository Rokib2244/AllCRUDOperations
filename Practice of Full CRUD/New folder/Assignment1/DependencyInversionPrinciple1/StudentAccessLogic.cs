using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple1
{
  public  class StudentAccessLogic
    {
        IStudentDataAccess _StudentDataAccess;
        

        public StudentAccessLogic()
        {
            _StudentDataAccess = DataAccessRules.GetStudentDataAccessObj();
        }
        public Student GetStudentDetails(int id)
        {
            return _StudentDataAccess.GetStudentDetails(id);
        }
    }
}
