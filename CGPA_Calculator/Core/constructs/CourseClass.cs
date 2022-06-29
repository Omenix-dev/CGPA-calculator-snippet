
namespace CGPA_Calculator.Core.contructs
{
    public class CourseClass
    {
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public float Score { get; set; }
        public Grading Grade 
        { 
            get
            {
                // validation to get where the range score falls into
                if(Score >= 70 && Score <= 100)
                {
                    return Grading.A;
                }
                else if (Score >= 60 && Score <= 69)
                {
                    return Grading.B;
                }else if (Score >= 50 && Score <= 59)
                {
                    return Grading.C;
                }else if (Score >= 45 && Score <= 49)
                {
                    return Grading.D;
                }else if (Score >= 40 && Score <= 44)
                {
                    return Grading.E;
                }
                return Grading.F;
            } 
        }
        public int GradeUnit 
        { 
            get
            {
                return (int)Grade;// parse the enum type to get the order in its enum struct
            } 
        }
        public int Weight_pt 
        {
            get
            {
                return GradeUnit * CourseUnit;
            }
        }
        public Remark Remark
        {
            get
            {
                return (Remark)GradeUnit;// parse the value using Remark enum class that hold the value for the remark
            }
        }

        public CourseClass(string CourseCode,int CourseUnit, float score)
        {
            this.CourseCode = CourseCode;
            this.CourseUnit = CourseUnit;
            this.Score = score;
        }
     }



}
