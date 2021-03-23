using System.ComponentModel.DataAnnotations;

namespace finly.Enums
{
    public enum ClientResidentialStatusTypes
    {
        [Display(Name="Owner with mortgage")]
        OwnerWithMorgtage = 0,

        [Display(Name="Owner no mortgage")]
        OwnerNoMortgage = 1,

        [Display(Name="Tenant - private")]
        TenantPrivate = 2,

        [Display(Name="Tenant - local authority")]
        TenantLocalAuthority = 3,

        [Display(Name="Living with family")]
        LivingWithFamily = 4,

        [Display(Name="Living with friends")]
        LivgingWithFriends = 5,

        [Display(Name="Tied accommodation")]
        TiedaAcommodation = 6,
    }
}