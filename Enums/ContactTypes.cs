using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum ContactTypes
    {
        [Display(Name = "Email Address")]
        Email = 0,

        [Display(Name = "Mobile Number")]
        Mobile = 1,

        [Display(Name = "Home Number")]
        Home = 2,

        [Display(Name = "Work Number")]
        Work = 3

    }
}