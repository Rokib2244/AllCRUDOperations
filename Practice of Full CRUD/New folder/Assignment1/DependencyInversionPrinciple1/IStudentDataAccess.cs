using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple1
{
   public interface IStudentDataAccess
    {
        Student GetStudentDetails(int id);
    }
}
