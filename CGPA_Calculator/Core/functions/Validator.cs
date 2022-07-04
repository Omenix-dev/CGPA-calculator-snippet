using System;

namespace CGPA_Calculator.Core.functions
{
    public class Validator
    {

        // ... a generic method that different values and return a conversion
        public static T Validate<T>(string mssg) where T:IConvertible
        {
            Console.Write(mssg);
            string value = Console.ReadLine();

            // loops till all value is filled; correct
            while (true)
            {
                // checks if the value is null or not
                if(value.Length == 0)
                {
                    PrintValidationMessage.Messg("this value is required", false);
                    Console.Write(mssg);
                    value = Console.ReadLine();
                }
                else
                {
                    T result;
                    try
                    {
                        // this section is built majorly for the floating point value grade
                        //it tests wether the code is outside range that is 0 and 100
                        if (typeof(T).ToString() == "System.Single")
                        {
                            if (float.Parse(value) > 100 || float.Parse(value) < 0)
                            {
                                throw new IndexOutOfRangeException("insert a value between 0 and 100");
                                continue;
                            }
                            else
                            {
                                result = (T)Convert.ChangeType(value, typeof(T));
                                return result;  
                            }
                        }
                          // does a convertion for a generic type
                          result = (T)Convert.ChangeType(value,typeof(T));   
                          return result;
                    }
                    catch(Exception e )
                    {
                        PrintValidationMessage.Messg(e.Message);
                        Console.Write(mssg);
                        value = Console.ReadLine();
                    }
                }
            }

            
                
        }
    }
}
