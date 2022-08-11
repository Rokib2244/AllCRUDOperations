using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversityMangement.Training.Entities
{
    public class Student : IEntity<int>
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }
    }
}
