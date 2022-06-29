
using System.Collections.Generic;
using CGPA_Calculator.Core.contructs;

namespace CGPA_Calculator.Core.functions
{
    public class TotalCourseUnitPassed
    {
        public static int calculate(List<CourseClass> ArrayValue)
        {
            int passedUnit = 0;
            if (ArrayValue != null)
            {
                foreach (var Course in ArrayValue)
                {
                    if(Course.GradeUnit >= 1)
                    {
                        passedUnit += Course.CourseUnit;
                    }
                    continue;
                }
            }
            return passedUnit;
        }
    }
}
