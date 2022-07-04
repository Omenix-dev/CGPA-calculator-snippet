using System;
using System.Collections.Generic;

namespace CGPA_Calculator.Core.functions
{
    public class ColoredString
    {
        public static void Singular(string a,bool val)
        {
            if (val)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(a);
            Console.ResetColor();
        }


    }
}
