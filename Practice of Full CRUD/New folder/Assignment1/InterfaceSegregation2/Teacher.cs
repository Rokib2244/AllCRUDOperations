using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation2
{
    class Teacher:IClassRoom, IExamMarkCalculation,IStudentAttendence
    {
        public void ProvideLectureVideo()
        {
            throw new NotImplementedException();
        }

        public void CalculateMarking()
        {
            throw new NotImplementedException();
        }

        public void CalculateAttendance()
        {
            throw new NotImplementedException();
        }
    }
}
