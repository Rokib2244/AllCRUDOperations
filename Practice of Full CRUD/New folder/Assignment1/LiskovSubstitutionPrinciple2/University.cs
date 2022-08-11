using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple2
{
   public class University :EducationalInstitute
    {
        public override string GetInstituteType()
        {
            return "I'm from University";
        }
    }
}
