using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple2
{
   public class College:EducationalInstitute
    {
        public override string GetInstituteType()
        {
            return "I'm from College";
        }
    }
}
