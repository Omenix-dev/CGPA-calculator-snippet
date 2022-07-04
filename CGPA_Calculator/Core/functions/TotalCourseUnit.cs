using System.Collections.Generic;
using CGPA_Calculator.Core.contructs;

namespace CGPA_Calculator.Core.functions
{
    public static class TotalCourseUnit
    {
        public static int calculate(List<CourseClass> ArrayValue)
        {

            int totalUnit = 0;
            if (ArrayValue != null)
            {
                foreach (var Course in ArrayValue)
                {
                    totalUnit += Course.CourseUnit;
                }
            }
            return totalUnit;
        }
    }
}
