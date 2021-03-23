using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum EmployedFullTimeTypes
    {
        [Display(Name = "Full time")]
        FullTime = 0,

        [Display(Name = "Part time")]
        PartTime = 1
    }
}