using System;
using System.Collections.Generic;
using CGPA_Calculator.Core.contructs;

namespace CGPA_Calculator.Core.functions
{
    public static class TotalWeightPoint
    {
        public static int Calculate(List<CourseClass> ArrayValue)
        {
            int totalWeight = 0;
            if (ArrayValue != null)
            {
                foreach(var Course in ArrayValue)
                {
                    totalWeight += Course.Weight_pt;
                }
            }
            return totalWeight;
        }
    }
}
