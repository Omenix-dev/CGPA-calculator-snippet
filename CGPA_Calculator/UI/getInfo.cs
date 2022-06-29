using System;
using System.Collections.Generic;
using CGPA_Calculator.Core.functions;


namespace CGPA_Calculator.UI
{
    public static class  getInfo
    {
        public static List<ValueTuple<string, int, float>> GetCourseDetails()
        {
            // welcome message
            Console.WriteLine("\nInput the details of the Courses you want to compute their CGPA:-");

            //dummy containers
            // holds the value for all the grades before they are instantiated with Course Class
            var listOfCourse = new List<ValueTuple<string, int, float>> { };


            // store the number of the courses offered
            int numberOfCourse = Validator.Validate<int>("Enter the number of course you offered: ");

            // for the amount depending on how many courses that was registered
            for (int i = 0; i < numberOfCourse; i++)
            {
                Console.Clear();
                if (listOfCourse != null)
                {
                    // shows the last record collect before collecting the new one
                    foreach(var item in listOfCourse)
                    {
                        Console.WriteLine(String.Format("|{0,5}||{1,5}||{2,5}|", item.Item1,item.Item2,item.Item3));
                    }
                }
                Console.WriteLine("");
                string CourseCode = Validator.Validate<string>("Enter the Course Code: ");
                int CourseUnit = Validator.Validate<int>("Enter the Course Credit unit: ");
                float score = Validator.Validate<float>("Enter the Course score: ");
                listOfCourse.Add((CourseCode, CourseUnit, score));// adds the value to list;
            }

            // this method is used to check if the user
            // wants to change the value before futher computation
            return Update.change(listOfCourse);

        }
    }
}
