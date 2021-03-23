using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum EmploymentStatusTypes
    {
        Employed = 0,

        [Display(Name="Self-Employed")]
        SelfEmployed = 1,

        Retired = 2,

        [Display(Name="Not Working")]
        NotWorking = 3
    }
}