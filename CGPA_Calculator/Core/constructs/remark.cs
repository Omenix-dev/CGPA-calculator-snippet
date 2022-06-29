using System.ComponentModel.DataAnnotations;

namespace CGPA_Calculator.Core.contructs
{
    public enum Remark
    {
        Fail,
        Pass,
        Fair,
        Good,
        [Display(Name = "Very Good")]// using data anontation to display the space between very and Good
        VeryGood,
        Excellent
    }
}
