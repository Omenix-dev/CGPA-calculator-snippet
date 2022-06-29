using System;
using System.Collections.Generic;

namespace CGPA_Calculator.Core.functions
{
    public static class Update
    {
        public static List<ValueTuple<string, int,float >> change(List<ValueTuple<string, int, float>> value)
        {
            while (true)
            {

                Console.Clear();
                // this is a preview to the data entered in case you may want to implement a data update
                if (value != null)
                {
                    // shows the last record collect before collecting the new one
                    foreach (var item in value)
                    {
                        Console.WriteLine(String.Format("|{0,5}||{1,5}||{2,5}|", item.Item1, item.Item2, item.Item3));
                    }
                }

                // display message
                PrintValidationMessage.Messg("DO you want change any data in the table above before computing the CGPA", true);
                Console.Write("\nPress ");
                ColoredString.Singular("C", true);
                Console.Write(" Compute the CGPA OR press ");
                ColoredString.Singular("U", true);
                Console.WriteLine(" to update table above");

                // listen for key
                ConsoleKeyInfo KeyValue = Console.ReadKey();

                // this test if the key pressed is an Enter key
                if (KeyValue.Key == ConsoleKey.C)
                {
                    return value;
                }
                else if (KeyValue.Key == ConsoleKey.U)
                {
                    bool match = false;
                    //return value;
                    Console.Write("\nEnter you action Press ");
                    ColoredString.Singular("D", false);
                    Console.Write(" to Delete OR Press");
                    ColoredString.Singular(" U", true);
                    Console.Write(" to update OR press");
                    ColoredString.Singular(" A", true);
                    Console.WriteLine(" to Add Course");

                    while (true)
                    {
                        ConsoleKeyInfo listenKey = Console.ReadKey();
                        if (listenKey.Key == ConsoleKey.D)
                        {
                            // delete
                            value = helper.DelVal(value);
                            break;
                        }
                        else if (listenKey.Key == ConsoleKey.A)
                        {
                            // add to the array list
                            value = helper.AddVal(value);
                            break;
                        }
                        else if (listenKey.Key == ConsoleKey.U)
                        {
                            // update to the array list
                            value = helper.Update(value);
                            break;
                        }
                    }


                }
                


            }
        }
    }

















    // this class is used to reduce the code into a much readable sectioning
    internal static class helper
    {
        internal static List<ValueTuple<string, int, float>> Update(List<(string, int, float)> value)
        {
            bool match = false;
            string CourseCode = Validator.Validate<string>("\nEnter the Correct Course Code: ");
            int CourseUnit = Validator.Validate<int>("\nEnter the  Correct Course Credit unit: ");
            float score = Validator.Validate<float>("\nEnter the Correct Course score: ");
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i].Item1 == CourseCode)
                {
                    match = true;
                    value.RemoveAt(i);// removes the tuple becos it cant be updated
                    value.Insert(i, (CourseCode, CourseUnit, score));// added the new one
                }
            }
            if (!match)
            {
                PrintValidationMessage.Messg("didnt find a match", false);
            }

            return value;       
        }








        internal static List<(string, int,float)> AddVal(List<(string, int, float)>value)
        {
            string CourseCode = Validator.Validate<string>("\nEnter the Correct Course Code: ");
            int CourseUnit = Validator.Validate<int>("\nEnter the  Correct Course Credit unit: ");
            float score = Validator.Validate<float>("\nEnter the Correct Course score: ");
            value.Add((CourseCode, CourseUnit, score));
            
            return value;
        }








        internal static List<ValueTuple<string, int, float>> DelVal(List<(string, int, float)> value)
        {
            string CourseCode = Validator.Validate<string>("\nEnter the Correct Course Code: ");
            bool match = false;
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i].Item1 == CourseCode)
                {
                    match = true;
                    value.RemoveAt(i);// removes the tuple becos it cant be updated
                }
            }
            if (!match)
            {
                PrintValidationMessage.Messg("didnt find a match", false);
            }
            return value;
        }

    }

























}
