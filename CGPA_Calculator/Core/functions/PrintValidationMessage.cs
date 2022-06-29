using System;


namespace CGPA_Calculator.Core.functions
{
    public class PrintValidationMessage
    {
        public static void Messg( string Messg, bool val = false)
        {
            if (val)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(Messg);
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
