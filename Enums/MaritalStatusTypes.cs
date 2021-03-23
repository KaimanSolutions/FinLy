using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum MaritalStatusTypes
    {
        Single = 0,

        Married = 1,

        [Display(Name="Civil Partner")]
        CivilPartner = 2,

        Cohabiting = 3,

        Divorced = 4,

        Widowed = 5,

        Separated = 6

    }
}