using System;
using System.Collections.Generic;
using CGPA_Calculator.Core.contructs;
using CGPA_Calculator.Core.functions;

namespace CGPA_Calculator.UI
{
    public class PrintCGPA
    {
        public static void Values(List<CourseClass> courses)
        {
            Console.WriteLine($"\n   Total Course Unit Registered is {TotalCourseUnit.calculate(courses)}");
            Console.WriteLine($"   Total Course Unit Passed is {TotalCourseUnitPassed.calculate(courses)}");
            Console.WriteLine($"   Total Weight Point is {TotalWeightPoint.Calculate(courses)}");
            Console.WriteLine($"   Your GPA is {(Convert.ToDecimal(TotalWeightPoint.Calculate(courses))/ Convert.ToDecimal(TotalCourseUnit.calculate(courses))).ToString("#.00")} to 2 decimal place");
        }
    }
}
