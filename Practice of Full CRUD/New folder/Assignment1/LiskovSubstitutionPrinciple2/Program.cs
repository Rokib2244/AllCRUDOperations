using System;

namespace LiskovSubstitutionPrinciple2
{
    class Program
    {
        static void Main(string[] args)
        {
            EducationalInstitute institute1 = new College();
            Console.WriteLine(institute1.GetInstituteType());
            EducationalInstitute institute2 = new School();
            Console.WriteLine(institute2.GetInstituteType());
            Console.ReadKey();
        }
    }
}
