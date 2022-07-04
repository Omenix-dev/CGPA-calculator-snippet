using System;
using CGPA_Calculator.UI;

namespace CGPA_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is the main method

            // clear and add a custom message to the console App bar;
            Console.Title = "CGPA Calculator Console app";

            // this is the method that is used to collect
            // the course details for the student
            var info = getInfo.GetCourseDetails();

            // store the List of the Course in this variable
            var ArrayOfListOfCourse = storeListOfCourses.AddList(info);

            // print the data in the array of the list of the Courses in a tabular form
            printTable.printFormat(ArrayOfListOfCourse);

            // this is used to print the other details  including CGPA values
            PrintCGPA.Values(ArrayOfListOfCourse);
        }
    }
}
