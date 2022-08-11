using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple1
{
   public class DataAccessRules
    {
        public static IStudentDataAccess GetStudentDataAccessObj()
        {
            return new StudentDataAccess();
        }
        
    }
}
