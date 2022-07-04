using CGPA_Calculator.Core.contructs;
using System;
using System.Collections.Generic;


namespace CGPA_Calculator.UI
{
    public class storeListOfCourses
    {
        public static List<CourseClass> AddList(List<ValueTuple<string, int, float>> listOfCourse)
        {
            // this is the array that holds the individual course as a List of the Course class object
            var ArrayListOfCourseObj = new List<CourseClass>() { };

            foreach (var item in listOfCourse)
            {
                var course = new CourseClass(item.Item1, item.Item2, item.Item3);
                ArrayListOfCourseObj.Add(course);
            }
            return ArrayListOfCourseObj;
        }
}
}
