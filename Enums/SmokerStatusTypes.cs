using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum SmokerStatusTypes
    {
        [Display(Name = "Non-Smoker")]
        NonSmoker = 0,

        Smoker = 1,
        
        [Display(Name="Previously Smoked")]
        PreviousSmoker = 2
    }
}