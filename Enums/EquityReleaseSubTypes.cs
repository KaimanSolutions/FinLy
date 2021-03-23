using System.ComponentModel.DataAnnotations;

namespace finly.enums
{
    public enum EquityReleaseSubTypes
    {
        [Display(Name="Lump-sum lifetime mortgage")]
        LumpSumLifetime = 0,

        [Display(Name="Interest-serviced lifetime mortgage")]
        InterestServicedLifetime = 1,

        [Display(Name="Drawdown lifetime mortgage")]
        DrawdownLifetime = 2,

        [Display(Name="Home reveersion plan")]
        HomeReversionPlan = 3,

    }
}