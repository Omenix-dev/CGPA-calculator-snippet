using System;
using System.Text;
using System.Collections.Generic;
using CGPA_Calculator.Core.contructs;
using System.Reflection;
using CGPA_Calculator.Core.functions;

namespace CGPA_Calculator.UI
{
    public class printTable
    {
        public static void printFormat(List<CourseClass>CourseData)
        {
            Console.Clear();// this is iused to clear the screen in other to print the values
            StringBuilder TableValue = new StringBuilder();
            //int numberOfCourse = values.Count// defines the number of course registered and the extra row to define the table

            // this is the array that hold the value for the head of the table
            var header_values = new List<string>() {
                                            "COURSE & CODE",
                                            "COURSE UNIT",
                                            "GRADE",
                                            "GRADE-UNIT",
                                            "WEIGHT Pt.",
                                            "REMARK"
            };

            //=============================== TableValue header==============================

            for (int y = 0; y < 3; y++)
            {
                // this used to pad the table in to the right
                TableValue.Append("   ");
                if (y == 0)
                {
                    printBar(header_values,TableValue,"_");
                    TableValue.AppendLine("");
                }
                else if (y == 1)
                {
                    TableValue.Append("|");
                    foreach (var val in header_values)
                    { 
                        string indValue = Justification.Center(val, val.Length+8);
                        TableValue.Append(indValue);   
                        TableValue.Append("|");
                    }
                    TableValue.AppendLine("");
                }
                else if (y == 2)
                {
                    printBar(header_values, TableValue,"-");
                }

            }

            //=============================== End of the table  header in the table stringbuilder =========>
            
            //====================== printing the body of the table ==========================>
            
            foreach(var item in CourseData)
            {
                printDetails<CourseClass>(item,header_values,TableValue);
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.WriteLine(TableValue.ToString());






        }
        
        
        // print bar section of the table
        private static void printBar(List<string> header_values, StringBuilder TableValue,string brick)
        {
            for (int i = 0; i < header_values.Count; i++)
            {
                int headerLength = header_values[i].Length + 9;
                for (int x = 0; x < headerLength; x++)
                {
                    TableValue.Append(brick);
                }
            }
            TableValue.Append(brick);
        }

        private static void printDetails<T>(T values,List<string> header_Values, StringBuilder TableValue) where T : class
        {
            
            TableValue.Append("\n   |");
            int i = 0;
             foreach(PropertyInfo val in values.GetType().GetProperties())
            {
                var value = val.GetValue(values,null).ToString();
                if (val.Name != "Score")
                {
                    string indValue = Justification.Center(value, header_Values[i].Length + 8);
                    TableValue.Append(indValue);
                    TableValue.Append("|");
                    i++;
                }
            }
            TableValue.Append("\n   ");
            printBar(header_Values, TableValue, "-");
        }
    }
}
