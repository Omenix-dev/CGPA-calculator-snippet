using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
